function onItemClick(s, e) {
    if (e.ItemName == "cardSalesByProduct") {
        $("#tabsContainer").data('dxTabs').option('onItemClick', function (args) {
            onTabChanged(args, e);
        });
        var title = getTitle(e),
            detailsData = getDetailsData(e);
        showPopup(title, detailsData);
    }
}

function onItemVisualInteractivity(s, e) {
    if (e.ItemName == 'cardSalesByProduct') {
        e.SetTargetAxes([DashboardDataAxisNames.DefaultAxis]);
        e.EnableHighlighting(true);
    }
}

function getDetailsData(args) {
    var data = args.GetData(),
        dimensions = args.GetDimensions(),
        productAxisPoint = args.GetAxisPoint(),
        categoryAxisPoint = productAxisPoint.GetParent(),
        categoryName = "Other " + categoryAxisPoint.GetDisplayText(),
        productName = productAxisPoint.GetDisplayText(),
        delta = args.GetDeltas()[0],
        productSlice = data.GetSlice(productAxisPoint),
        categorySlice = data.GetSlice(categoryAxisPoint),
        categoryTotal = categorySlice.GetDeltaValue(delta.Id).GetActualValue().GetValue(),
        productValue = productSlice.GetDeltaValue(delta.Id).GetActualValue().GetValue(),
        sparkLineAxis = data.GetAxis('Sparkline'),
        sparkLineAxisPoints = sparkLineAxis.GetPoints(),
        sparkLineDimensions = sparkLineAxis.GetDimensions(),
        chartArguments = [],
        chartActualValues = [],
        chartTargetValues = [],
        deltas = args.GetDeltas(),
        chartDataSource = [],
        measures = data.GetMeasures(),
        unitsInStockMeasure = $.grep(measures, function (measure) {
            return measure.Name == "Units In Stock";
        })[0],
        unitsInStockMeasureValue = productSlice.GetMeasureValue(unitsInStockMeasure.Id).GetDisplayText(),
        actualMeasure = $.grep(measures, function (measure) {
            return measure.Id == deltas[0].ActualMeasureId;
        })[0],
        actualMeasureName = actualMeasure.Name,
        targetMeasure = $.grep(measures, function (measure) {
            return measure.Id == deltas[0].TargetMeasureId;
        })[0],
        targetMeasureName = targetMeasure.Name;

    $.each(sparkLineAxisPoints, function (_, axisPoint) {
        var deltaValue = productSlice.GetSlice(axisPoint).GetDeltaValue(deltas[0].Id);
        chartArguments.push(axisPoint.GetDisplayText());
        chartActualValues.push(deltaValue.GetActualValue().GetValue());
        chartTargetValues.push(deltaValue.GetTargetValue().GetValue());
        chartDataSource.push({
            time: axisPoint.GetDisplayText(),
            actual: deltaValue.GetActualValue().GetValue(),
            target: deltaValue.GetTargetValue().GetValue()
        });
    });
    var pieDataSource = [
        { category: categoryName, value: categoryTotal - productValue },
        { category: productName, value: productValue }
    ];
    return {
        unitsInStockMeasureValue: unitsInStockMeasureValue,
        chartDataSource: chartDataSource,
        pieDataSource: pieDataSource,
        actualMeasureName: actualMeasureName,
        targetMeasureName: targetMeasureName,
        measureFormatCallback: function (value) {
            return actualMeasure.Format(value);
        }
    }
}

function underlyingDataRequest(args) {
    var columnNames = args.GetData().GetDataMembers(),
        underlyingData = [];
    $("#loadPanel").data('dxLoadPanel').show();
    args.RequestUnderlyingData(function (data) {
        dataMembers = data.GetDataMembers();
        for (var i = 0; i < data.GetRowCount() ; i++) {
            var dataTableRow = {};
            $.each(dataMembers, function (_, dataMember) {
                dataTableRow[dataMember] = data.GetRowValue(i, dataMember);
            });
            underlyingData.push(dataTableRow);
        }
        updateUnderlyingData(underlyingData, dataMembers);
    }, columnNames);
}

function getTitle(e) {
    var data = e.GetData(),
        dimensions = e.GetDimensions(),
        productAxisPoint = e.GetAxisPoint(),
        categoryAxisPoint = productAxisPoint.GetParent(),
        categoryName = categoryAxisPoint.GetDisplayText(),
        productName = productAxisPoint.GetDisplayText();
    return categoryName + ", " + productName;
}