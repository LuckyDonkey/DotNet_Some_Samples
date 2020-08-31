using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.DI.Autofac.FirstDemo
{
    /// <summary>
    /// 学生旅客 实现了乘客/旅客接口
    /// </summary>
    public class Student : IPassenger
    {
        private readonly IVehicle _vehicle;

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="vehicle">交通工具</param>
        public Student(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        /// <summary>
        /// 乘坐交通工具去{targetAddr}(目的地)
        /// </summary>
        /// <param name="targetAddr"></param>
        public void ByVehicleTo(string targetAddr)
        {
            Console.WriteLine("学生旅客：");

            _vehicle.GoTo(targetAddr);
        }
    }
}
