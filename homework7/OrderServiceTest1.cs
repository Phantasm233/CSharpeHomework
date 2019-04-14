using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5.Test1
{
    [TestClass()]
    public class OrderServiceTest1
    {
        [TestMethod()]
        public void InsertTest1()
        {
            Customer jack = new Customer(1, "Jack");
            Goods pen = new Goods(1, "Pen", 150);
            Goods pencil = new Goods(2, "Pencil", 5.99);
            Goods notebook = new Goods(3, "Notebook", 15.59);
            OrderDetails orderDetails1 = new OrderDetails(1, pen, 15);
            OrderDetails orderDetails2 = new OrderDetails(2, pencil, 60);
            OrderDetails orderDetails3 = new OrderDetails(3, notebook, 50);
            Order order = new Order(1, jack);
            order.AddDetails(orderDetails1);
            order.AddDetails(orderDetails2);
            order.AddDetails(orderDetails3);
            OrderService os = new OrderService();
            os.Insert(order);
            Assert.IsNotNull(os.orderList);
        }

        [TestMethod()]
        public void GetByIdTest1()
        {
            Customer jack = new Customer(1, "Jack");
            Goods pen = new Goods(1, "Pen", 150);
            Goods pencil = new Goods(2, "Pencil", 5.99);
            Goods notebook = new Goods(3, "Notebook", 15.59);
            OrderDetails orderDetails1 = new OrderDetails(1, pen, 15);
            OrderDetails orderDetails2 = new OrderDetails(2, pencil, 60);
            OrderDetails orderDetails3 = new OrderDetails(3, notebook, 50);
            Order order = new Order(1, jack);
            order.AddDetails(orderDetails1);
            order.AddDetails(orderDetails2);
            order.AddDetails(orderDetails3);
            OrderService os = new OrderService();
            os.Insert(order);
            Order od = os.GetById(order.orderId);
            Assert.IsNotNull(od);
        }

        [TestMethod()]
        public void FindByCustomerNameTest1()
        {
            Customer jack = new Customer(1, "Jack");
            Goods pen = new Goods(1, "Pen", 150);
            Goods pencil = new Goods(2, "Pencil", 5.99);
            Goods notebook = new Goods(3, "Notebook", 15.59);
            OrderDetails orderDetails1 = new OrderDetails(1, pen, 15);
            OrderDetails orderDetails2 = new OrderDetails(2, pencil, 60);
            OrderDetails orderDetails3 = new OrderDetails(3, notebook, 50);
            Order order = new Order(1, jack);
            order.AddDetails(orderDetails1);
            order.AddDetails(orderDetails2);
            order.AddDetails(orderDetails3);
            OrderService os = new OrderService();
            os.Insert(order);
            List<Order> odList = os.FindByCustomerName(order.customer.Name);
            Assert.IsNotNull(odList);
        }

        [TestMethod()]
        public void FindByGoodsNameTest1()
        {
            Customer jack = new Customer(1, "Jack");
            Goods pen = new Goods(1, "Pen", 150);
            Goods pencil = new Goods(2, "Pencil", 5.99);
            Goods notebook = new Goods(3, "Notebook", 15.59);
            OrderDetails orderDetails1 = new OrderDetails(1, pen, 15);
            OrderDetails orderDetails2 = new OrderDetails(2, pencil, 60);
            OrderDetails orderDetails3 = new OrderDetails(3, notebook, 50);
            Order order = new Order(1, jack);
            order.AddDetails(orderDetails1);
            order.AddDetails(orderDetails2);
            order.AddDetails(orderDetails3);
            OrderService os = new OrderService();
            os.Insert(order);
            List<Order> odList = os.FindByGoodsName("Pen");
            Assert.IsNotNull(odList);
        }

        [TestMethod()]
        public void RemoveTest1()
        {
            Customer jack = new Customer(1, "Jack");
            Goods pen = new Goods(1, "Pen", 150);
            Goods pencil = new Goods(2, "Pencil", 5.99);
            Goods notebook = new Goods(3, "Notebook", 15.59);
            OrderDetails orderDetails1 = new OrderDetails(1, pen, 15);
            OrderDetails orderDetails2 = new OrderDetails(2, pencil, 60);
            OrderDetails orderDetails3 = new OrderDetails(3, notebook, 50);
            Order order = new Order(1, jack);
            order.AddDetails(orderDetails1);
            order.AddDetails(orderDetails2);
            order.AddDetails(orderDetails3);
            OrderService os = new OrderService();
            os.Insert(order);
            os.Remove(1);
            Order od = os.GetById(1);
            Assert.IsNull(od);
        }
    }
}