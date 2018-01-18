using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MES_DAL.Models
{
    public enum TaskStatus
    {
        未开始=0,
        已下发=1,
        进行中=2,
        已完成=3,
        异常中=4
    }
}