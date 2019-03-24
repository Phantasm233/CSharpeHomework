using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Customer jack = new Customer(1, "Jack");
                Customer bill = new Customer(2, "Bill");

                Goods pen = new Goods(1, "Pen", 150);
                Goods pencil = new Goods(2, "Pencil", 5.99);
                Goods notebook = new Goods(3, "Notebook", 15.59);

                OrderDetails orderDetails1 = new OrderDetails(1, pen, 15);
                OrderDetails orderDetails2 = new OrderDetails(2, pencil, 60);
                OrderDetails orderDetails3 = new OrderDetails(3, notebook, 50);

                Order order1 = new Order(1, jack);
                Order order2 = new Order(2, bill);
                Order order3 = new Order(3, bill);
                Order order4 = new Order(4, jack);
                order1.AddDetails(orderDetails1);
                order1.AddDetails(orderDetails2);
                order1.AddDetails(orderDetails3);
                //order1.AddOrderDetails(orderDetails3);
                order2.AddDetails(orderDetails2);
                order2.AddDetails(orderDetails3);
                order3.AddDetails(orderDetails3);
                order4.AddDetails(orderDetails1);
                order4.AddDetails(orderDetails3);

                OrderService os = new OrderService();
                os.Insert(order4);
                os.Insert(order1);
                os.Insert(order2);
                os.Insert(order3);

                Console.WriteLine("输出所有订单：");
                List<Order> orders = os.orderList;
                foreach (Order order in orders)
                    Console.WriteLine(order.ToString());

                Console.WriteLine("按照客户名查询订单:Bill");
                orders = os.FindByCustomerName("Bill");
                foreach (Order order in orders)
                    Console.WriteLine(order.ToString());

                Console.WriteLine("按照商品名查询订单:Pencil");
                orders = os.FindByGoodsName("Pencil");
                foreach (Order order in orders)
                    Console.WriteLine(order);

                Console.WriteLine("移除订单(id=2) 同时输出所有订单");
                os.Remove(2);
                os.orderList.ForEach(
                    od => Console.WriteLine(od));

                Console.WriteLine("按订单号升序的顺序对订单进行排序并输出");
                os.orderList.Sort();
                os.orderList.ForEach(
                    od => Console.WriteLine(od));

                Console.WriteLine("按订单总金额升序的顺序对订单进行排序并输出");
                os.orderList.Sort((o1, o2) =>(int)(o1.GetSumPrice() - o2.GetSumPrice()));
                os.orderList.ForEach(
                    od => Console.WriteLine(od));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
