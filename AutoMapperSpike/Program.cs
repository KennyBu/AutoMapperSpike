using System;
using Models;

namespace AutoMapperSpike
{
    class Program
    {
        static void Main(string[] args)
        {
            //MapperBootStrap.Initialize();
            //MapperBootStrap.InitilaizeIgnore();
            MapperBootStrap.InitializeWithOptions();

            SimpleMapping();


        }
        
        private static void SimpleMapping()
        {
            var order = new Order
            {
                OrderId = Guid.NewGuid(),
                OrderDate = DateTime.Now,
                Total = 50m,
                CustomerId = Guid.NewGuid()
            };

            var dtoOrder = AutoMapper.Mapper.Map<OrderDto>(order);

            Console.WriteLine("Order Info");
            Console.WriteLine("__________");
            Console.WriteLine("OrderId: {0}", order.OrderId);
            Console.WriteLine("Order Date: {0}", order.OrderDate);
            Console.WriteLine("Total: {0}", order.Total);
            Console.WriteLine("CustomerId: {0}", order.CustomerId);
            Console.WriteLine();
            Console.WriteLine("Order Dto Info");
            Console.WriteLine("__________");
            Console.WriteLine("OrderId: {0}", dtoOrder.OrderId);
            Console.WriteLine("Order Date: {0}", dtoOrder.OrderDate);
            Console.WriteLine("Total: {0}", dtoOrder.Total);
            Console.WriteLine("CustomerNumber: {0}", dtoOrder.CustomerNumber);
            Console.WriteLine("Day Of Month: {0}", dtoOrder.OrderDay);

            Console.ReadKey();
        }
    }
}
