using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.DI.Autofac.FirstDemo
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            //builder.RegisterType<Bus>().As<IVehicle>();
            builder.RegisterType<Train>().As<IVehicle>();
            builder.RegisterType<Student>().As<IPassenger>();
            Container = builder.Build();

            Travel();

            Console.ReadLine();
        }


        public static void Travel()
        {
            //创建了一个生命周期范围（scope）, 从中可以解析依赖项。 
            using (var scope = Container.BeginLifetimeScope())
            {
                //从生命周期范围（scope）中解析IPassenger，
                //Autofac发现IPassenger对应Student，因此开始创建Student
                //Autofac发现Student的构造方法需要一个IVehicle（这就是“构造方法注入”）
                //Autofac发现IVehicle对应Bus，因此开始创建新的Bus实例
                //Autofac使用新的Bus实例完成Student的创建
                //Autofac返回完整构建的 Student 给"Travel"方法使用
                var passenger = scope.Resolve<IPassenger>();
                //调用 passenger.ByVehicleTo("Beijing") 就是一个全新的 passenger.ByVehicleTo("Beijing") 因为这是在生命周期中解析出的.
                passenger.ByVehicleTo("Beijing");

                //Autofac生命周期被释放. 任何从生命周期解析出的可释放对象也都被同时释放。
                //例如这里的Bus实现了IDisposable接口，在scope生命周期被释放的同时会调用Bus的Dispose。
            }
        }
    }
}
