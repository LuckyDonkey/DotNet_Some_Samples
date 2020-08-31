using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.DI.Autofac.FirstDemo
{
    /// <summary>
    /// 大巴
    /// </summary>
    public class Bus : IVehicle, IDisposable
    {
        private string _vehicleName { get; }

        public Bus()
        {
            _vehicleName = "大巴";
        }

        public void GoTo(string targetAddress)
        {
            Console.WriteLine($"乘 {_vehicleName} 去 {targetAddress}");
        }

        public void Dispose()
        {
            Console.WriteLine($"{nameof(Bus)} dispose");
        }
    }
}
