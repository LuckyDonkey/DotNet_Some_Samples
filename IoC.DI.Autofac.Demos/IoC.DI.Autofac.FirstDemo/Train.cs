using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.DI.Autofac.FirstDemo
{
    public class Train : IVehicle
    {
        public void GoTo(string targetAddress)
        {
            Console.WriteLine($"乘坐火车去 {targetAddress}");
        }
    }
}
