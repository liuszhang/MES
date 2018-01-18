using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lsz.MES.Data.Models
{

    public class MachInfo : INotifyPropertyChanged
    {
        //static MachInfo()
        //{
        //    MachWorkTimeInfo.Add(new MachWorkTime() { Name = "开机时间", Value = 100 });
        //    MachWorkTimeInfo.Add(new MachWorkTime() { Name = "工作时间", Value = 80 });
        //    MachWorkTimeInfo.Add(new MachWorkTime() { Name = "计划停机时间", Value = 15 });
        //    MachWorkTimeInfo.Add(new MachWorkTime() { Name = "异常时间", Value = 5 });
        //}

        public static string Caption { get; set; }
        public List<MachWorkTime> MachWorkTimeInfo { get; set; }
        public static DateTime time { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}