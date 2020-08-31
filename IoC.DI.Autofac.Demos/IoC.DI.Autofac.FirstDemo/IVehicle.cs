using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.DI.Autofac.FirstDemo
{
    /// <summary>
    /// 交通工具接口
    /// </summary>
    public interface IVehicle
    {
        /// <summary>
        /// 去哪里
        /// </summary>
        /// <param name="targetAddress">目的地</param>
        void GoTo(string targetAddress);
    }
}
