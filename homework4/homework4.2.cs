using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            orderService.orderList = new List<Order>();
            while(true)
            {
                Console.WriteLine("请选择所做操作（1.添加订单   2.删除订单  3.修改订单  4.查询订单  5.退出）：");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 5)
                    break;
                switch (choice)
                {
                    case 1:
                        {
                            try
                            {
                                orderService.Insert();
                            }
                            catch
                            {
                                Console.WriteLine("添加订单失败！");
                            }
                            break;
                        }
                    case 2:
                        {
                            try
                            {
                                orderService.Delete();
                            }
                            catch
                            {
                                Console.WriteLine("删除订单失败！");
                            }
                            break;
                        }
                    case 3:
                        {
                            try
                            {
                                orderService.Modify();
                            }
                            catch
                            {
                                Console.WriteLine("修改订单失败！");
                            }
                            break;
                        }
                    case 4:
                        {
                            try
                            {
                                orderService.Research();
                            }
                            catch
                            {
                                Console.WriteLine("查询订单失败！");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("输入有误！");
                            break;
                        }
                }
            }
        }
    }
    //订单类
    class Order
    {
        private int myOrderId;  //订单号
        private string myGuestName;  //客户名
        public List<OrderDetails> details;  //订单明细

        public int orderId
        {
            get
            {
                return myOrderId;
            }
            set
            {
                myOrderId = value;
            }
        }
        public string guestName
        {
            get
            {
                return myGuestName;
            }
            set
            {
                myGuestName = value;
            }
        }
    }
    //订单明细类
    class OrderDetails
    {
        private string myGoods;  //商品名
        private int myCount;  //商品数量
        private double myPrice;  //销售价格

        public string goods
        {
            get
            {
                return myGoods;
            }
            set
            {
                myGoods = value;
            }
        }
        public int count
        {
            get
            {
                return myCount;
            }
            set
            {
                myCount = value;
            }
        }
        public double price
        {
            get
            {
                return myPrice;
            }
            set
            {
                myPrice = value;
            }
        }
    }
    //订单服务类
    class OrderService
    {
        public List<Order> orderList;  //用于存储订单数据

        //添加订单
        public void Insert()
        {
            Order order = new Order();
            order.details = new List<OrderDetails>();
            Console.Write("请输入添加订单的订单号：");
            order.orderId = int.Parse(Console.ReadLine());
            Console.Write("请输入添加订单的客户名：");
            order.guestName = Console.ReadLine();
            OrderDetails orderdetails = new OrderDetails();
            Console.WriteLine("请输入订单明细：");
            Console.Write("请输入商品名：");
            orderdetails.goods = Console.ReadLine();
            Console.Write("请输入商品数量：");
            orderdetails.count = int.Parse(Console.ReadLine());
            Console.Write("请输入商品价格：");
            orderdetails.price = double.Parse(Console.ReadLine());
            order.details.Add(orderdetails);
            Console.Write("是否继续添加订单明细？(y/n)");
            char choice = char.Parse(Console.ReadLine());
            while(choice=='y')
            {
                OrderDetails orderdetails1 = new OrderDetails();
                Console.Write("请输入商品名：");
                orderdetails1.goods = Console.ReadLine();
                Console.Write("请输入商品数量：");
                orderdetails1.count = int.Parse(Console.ReadLine());
                Console.Write("请输入商品价格：");
                orderdetails1.price = double.Parse(Console.ReadLine());
                order.details.Add(orderdetails1);
                Console.Write("是否继续添加订单明细？(y/n)");
                choice = char.Parse(Console.ReadLine());
            }
            orderList.Add(order);
            Console.WriteLine("订单添加成功！");
        }
        //删除订单
        public void Delete()
        {
            Console.Write("请输入需要删除订单的订单号：");
            int deleteId=int.Parse(Console.ReadLine());
            Boolean flag = false;
            for(int i=0;i<orderList.Count;i++)
            {
                if(orderList[i].orderId==deleteId)
                {
                    orderList.Remove(orderList[i]);
                    flag = true;
                    break;
                }
            }
            if(flag==false)
            {
                throw new Exception();
            }
            Console.WriteLine("删除订单成功！");
        }
        //修改订单
        public void Modify()
        {
            Console.Write("请输入需要修改订单的订单号：");
            int modifyId = int.Parse(Console.ReadLine());
            Boolean flag = false;
            for(int i=0;i<orderList.Count;i++)
            {
                if(orderList[i].orderId==modifyId)
                {                   
                    Console.Write("请输入修改订单的客户名：");
                    orderList[i].guestName = Console.ReadLine();
                    for(int j=0;j<orderList[i].details.Count;j++)
                    {
                        Console.WriteLine("请修改第" + (j + 1) + "个订单明细：");
                        Console.Write("请输入商品名：");
                        orderList[i].details[j].goods = Console.ReadLine();
                        Console.Write("请输入商品数量：");
                        orderList[i].details[j].count = int.Parse(Console.ReadLine());
                        Console.Write("请输入商品价格：");
                        orderList[i].details[j].price = double.Parse(Console.ReadLine());
                    }
                    flag = true;
                    break;
                }
            }
            if(flag==false)
            {
                throw new Exception();
            }
            Console.WriteLine("修改订单成功！");
        }
        //查询订单
        public void Research()
        {
            Console.WriteLine("请选择查询方式（1.按订单号   2.按客户名  3.按商品名称）：");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    {
                        Console.Write("请输入需要查询订单的订单号：");
                        int id = int.Parse(Console.ReadLine());
                        Boolean flag1 = false;
                        for(int i=0;i<orderList.Count;i++)
                        {
                            if(orderList[i].orderId==id)
                            {
                                Console.WriteLine("订单号      客户名");
                                Console.WriteLine(orderList[i].orderId + "      " + orderList[i].guestName);
                                Console.WriteLine("订单明细：");
                                Console.WriteLine("商品名      商品数量      商品价格");
                                for(int j=0;j<orderList[i].details.Count;j++)
                                {
                                    Console.WriteLine(orderList[i].details[j].goods + "      " + orderList[i].details[j].count + "      " + orderList[i].details[j].price);
                                }
                                flag1 = true;
                            }
                        }
                        if(flag1==false)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Write("请输入需要查询订单的客户名：");
                        string name = Console.ReadLine();
                        Boolean flag2 = false;
                        for (int i = 0; i < orderList.Count; i++)
                        {
                            if (orderList[i].guestName == name)
                            {
                                Console.WriteLine("订单号      客户名");
                                Console.WriteLine(orderList[i].orderId + "      " + orderList[i].guestName);
                                Console.WriteLine("订单明细：");
                                Console.WriteLine("商品名      商品数量      商品价格");
                                for (int j = 0; j < orderList[i].details.Count; j++)
                                {
                                    Console.WriteLine(orderList[i].details[j].goods + "      " + orderList[i].details[j].count + "      " + orderList[i].details[j].price);
                                }
                                flag2 = true;
                            }
                        }
                        if (flag2 == false)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                case 3:
                    {
                        Console.Write("请输入需要查询订单的商品名：");
                        string goods = Console.ReadLine();
                        Boolean flag3 = false;
                        for (int i = 0; i < orderList.Count; i++)
                        {
                            for(int j=0;j<orderList[i].details.Count;j++)
                            {
                                if (orderList[i].details[j].goods == goods)
                                {
                                    Console.WriteLine("订单号      客户名");
                                    Console.WriteLine(orderList[i].orderId + "      " + orderList[i].guestName);
                                    Console.WriteLine("订单明细：");
                                    Console.WriteLine("商品名      商品数量      商品价格");
                                    for (int k = 0; k < orderList[i].details.Count; k++)
                                    {
                                        Console.WriteLine(orderList[i].details[k].goods + "      " + orderList[i].details[k].count + "      " + orderList[i].details[k].price);
                                    }
                                    flag3 = true;
                                }
                            }
                        }
                        if (flag3 == false)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("输入有误！");
                        break;
                    }
            }
        }
    }
}
