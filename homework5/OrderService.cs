using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5
{
    class OrderService
    {
        public List<Order> orderList;  //用于存储订单数据

        public OrderService()
        {
            orderList = new List<Order>();
        }

        //添加订单
        public void Insert(Order order)
        {
            foreach (Order o in orderList)
            {
                if (o.orderId.Equals(order.orderId))
                {
                    throw new Exception($"order-{order.orderId} is already existed!");
                }
            }
            orderList.Add(order);
        }
        //根据订单号查询订单
        public Order GetById(int orderId)
        {
            foreach (Order o in orderList)
            {
                if (o.orderId == orderId)
                {
                    return o;
                }
            }
            return null;
        }
        //修改订单
        public void Modify(int orderId,Order order)
        {
            Order o = GetById(orderId);
            if (o == null) return;
            o = order;
        }
        //按客户名查询订单
        public List<Order> FindByCustomerName(string customerName)
        {
            var query = orderList
         .Where(order => order.customer.Name == customerName);
            return query.ToList();
        }
        //按商品名查询订单
        public List<Order> FindByGoodsName(string goodsName)
        {
            List<Order> result = new List<Order>();
            foreach (Order order in orderList)
            {
                foreach (OrderDetails detail in order.details)
                {
                    if (detail.goods.Name == goodsName)
                    {
                        result.Add(order);
                        break;
                    }
                }
            }
            return result;
        }
        //删除订单
        public void Remove(int orderId)
        {
            Order order = GetById(orderId);
            if (order == null) return;
            orderList.Remove(order);
        }
    }
}
