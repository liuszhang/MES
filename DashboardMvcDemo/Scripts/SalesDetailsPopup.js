function initPopup() {
    $("body").append($("<div/>", { id: 'popup' }));
    $("body").append($("<div/>", { id: 'loadPanel' }));
    $("body").append($("<div/>", { id: 'hiddenDiv', style: "width: 900px; height: 450px; opacity:0; position: absolute; z-index: -1" }));

    $("#popup").dxPopup({
        width: 900,
        height: 600,
        shading: false,
        showCloseButton: true,
        //buttons: [ { shortcut: 'close' }],// ensure DevExtreme modifications
        onHidden: function () {
            $("#contentContainer1").empty();
            $("#contentContainer2").empty();
        },
        container: $(".LayoutContainer")
    });

    var $popupContent = $("#popup").data('dxPopup').content();
    $popupContent.append($('<div/>', { id: 'tabsContainer' }));
    $popupContent.append($('<div/>', { id: 'contentContainer1' }));
    $popupContent.append($('<div/>', { id: 'contentContainer2' }));

    var $tabsContainer = $("#tabsContainer");
    $tabsContainer.dxTabs({
        items: [{ id: "1", text: "Details" }, { id: "2", text: "Underlying Data" }]
    });
    $("#tabsContainer .dx-tab").css('width', '50%');
    $tabsContainer.css('background-color', $tabsContainer.parent().css('background-color'));

    $("#loadPanel").dxLoadPanel({
        message: 'Loading...',
        shading: false,
        visible: false,
        position: {
            of: $popupContent
        }
    });
}

function showPopup(title, detailsData) {
    var popupInstance = $("#popup").data('dxPopup');
    if (!popupInstance.option('visible')) {
        popupInstance.option('title', title);
        $("#tabsContainer").data('dxTabs').option('selectedIndex', 0);
        updateDetailsData(detailsData);
        $("#contentContainer1").show();
        $("#contentContainer2").hide();
        setTimeout(function () {
            popupInstance.show();
        });
    }
}

function onTabChanged(args, e) {
    if (args.itemData.id == "1") {
        $("#contentContainer1").show();
        $("#contentContainer2").hide();
    }
    if (args.itemData.id == "2") {
        if ($("#contentContainer2").html() == "") {
            underlyingDataRequest(e);
        }
        $("#contentContainer1").hide();
        $("#contentContainer2").show();
    }
}

function updateDetailsData(detailsData) {
    var $chart = createChart(detailsData.chartDataSource, detailsData.actualMeasureName, detailsData.targetMeasureName, detailsData.measureFormatCallback),
        $pie = createPie(detailsData.pieDataSource, detailsData.actualMeasureName, detailsData.measureFormatCallback),
        $div = $("<div/>"),
        $div1 = $("<div/>", {
            style: "display: inline-block; float: left; width: 310px; margin-top: 53px; margin-left: 40px; font-size: 32px;"
        }),
        $div2 = $("<div/>", {
            style: "display: inline-block;"
        });

    $div1.html("Units in Stock : " + detailsData.unitsInStockMeasureValue);
    $div1.appendTo($div);
    $div2.html($pie);
    $div2.appendTo($div);

    setTimeout(function () {
        $("#contentContainer1").html($div);
        $("#contentContainer1").append($('<div/>', { 'class': "Clear" }));
        $("#contentContainer1").append($chart);
    });
}

function updateUnderlyingData(underlyingData, dataMembers) {
    var $grid = createGrid(underlyingData, dataMembers);
    setTimeout(function () {
        $("#contentContainer2").html($grid);
        $("#loadPanel").data('dxLoadPanel').hide();
    });
}

function createGrid(dataSource, dataMembers) {
    var $grid = $('<div/>');
    $grid.appendTo($("#hiddenDiv"));
    $grid.dxDataGrid({
        height: 450,
        scrolling: {
            mode: 'virtual'
        },
        dataSource: dataSource
    });
    $grid.data('dxDataGrid').option('columns', [
        { dataField: dataMembers[7], width: "80px" },
        { dataField: dataMembers[1], width: "100px" },
        { dataField: dataMembers[5], width: "80px" },
        { dataField: dataMembers[6], width: "110px" },
        { dataField: dataMembers[9], width: "80px" },
        { dataField: dataMembers[10], width: "120px" },
        { dataField: dataMembers[3], width: "65px" },
        { dataField: dataMembers[4], width: "110px" },
        { dataField: dataMembers[8], width: "110px" }
    ]);
    return $grid;
}

function createChart(dataSource, actualMeasureName, targetMeasureName, measureFormatCallback) {
    var $chart = $('<div/>');
    $chart.appendTo($("#hiddenDiv"));
    $chart.dxChart({
        dataSource: dataSource,
        animation: false,
        size: {
            width: 850,
            height: 280
        },
        adaptiveLayout: {
            height: 0,
            keepLabels: true
        },
        legend: {
            orientation: 'horizontal',
            horizontalAlignment: 'left',
            itemTextPosition: 'right',
            position: 'inside',
            backgroundColor: 'none'
        },
        argumentAxis: {
            showZero: false,
            type: 'discrete'
        },
        valueAxis: {
            showZero: false,
            type: 'continuous',
            label: {
                customizeText: function () {
                    return measureFormatCallback(this.value);
                }
            }
        },
        commonSeriesSettings: {
            argumentField: 'time'
        },
        series: [
            {
                type: 'bar',
                valueField: 'target',
                name: targetMeasureName
            },
            {
                type: 'spline',
                valueField: 'actual',
                name: actualMeasureName,
                hoverMode: 'none',
                label: {
                    visible: true,
                    connector: {
                        visible: true,
                        width: 1
                    },
                    customizeText: function () {
                        return measureFormatCallback(this.value);
                    }
                },
                point: {
                    hoverMode: 'none'
                }
            }
        ],
        tooltip: {
            enabled: true,
            customizeText: function () {
                return (this.seriesName == actualMeasureName) ? null : measureFormatCallback(this.value);
            },
            zIndex: 1001
        }
    });
    return $chart;
}

function createPie(dataSource, actualMeasureName, measureFormatCallback) {
    var $pie = $('<div/>');
    $pie.appendTo($("#hiddenDiv"));

    var myPalette = ['rgb(82, 132, 240)', 'rgb(250, 128, 114)'];
    DevExpress.viz.registerPalette('mySuperPalette', myPalette);

    $pie.dxPieChart({
        dataSource: dataSource,
        title: {
            text: actualMeasureName,
            font: {
                size: 20
            }
        },
        animation: false,
        palette: 'mySuperPalette',
        size: {
            width: 500,
            height: 150
        },
        adaptiveLayout: {
            height: 120,
            keepLabels: true
        },
        legend: {
            visible: false,
        },
        series: [
            {
                argumentField: "category",
                valueField: "value",
                label: {
                    visible: true,
                    position: 'outside',
                    percentPrecision: 2,
                    connector: {
                        visible: true,
                        width: 1
                    },
                    customizeText: function (label) {
                        return label.argumentText + "<br/>" + label.percentText;
                    }
                }
            }
        ],
        tooltip: {
            enabled: true,
            customizeText: function () {
                return measureFormatCallback(this.value);
            }
        }
    });
    return $pie;
}