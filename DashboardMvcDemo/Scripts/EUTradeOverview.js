function setPieInsidePosition(s, e) {
    if (e.ItemName == 'pieImportVsExport') {
        e.GetWidget()[0].option('series[0].label.position', 'inside')
    }
}