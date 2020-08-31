using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.DI.Autofac.FirstDemo
{
    /// <summary>
    /// 乘客/旅客接口
    /// </summary>
    public interface IPassenger
    {
        /// <summary>
        /// 乘坐交通工具去{targetAddr}(目的地)
        /// </summary>
        /// <param name="targetAddr">目的地</param>
        void ByVehicleTo(string targetAddr);
    }
}
