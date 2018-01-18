using System;
using System.Globalization;
using System.Windows.Data;
using DevExpress.DevAV;
using Lsz.MES.Data;

namespace DevExpress.DevAV {
    public class PictureConverter : IValueConverter {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            Lsz.MES.Data.Models.Picture picture = value as Lsz.MES.Data.Models.Picture;
            return picture == null ? null : picture.Data;
        }
        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            byte[] data = value as byte[];
            return data == null ? null : new Lsz.MES.Data.Models.Picture() { Data = data };
        }
    }
}
