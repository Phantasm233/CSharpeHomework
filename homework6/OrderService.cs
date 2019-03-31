using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

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
/*        public List<Order> FindByGoodsName(string goodsName)
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
*/
        public List<Order>FindByGoodsName(string goodsName)
        {
            var query = from n in orderList from m in n.details where m.goods.Name == goodsName select n;
            return query.ToList();
        }
        //删除订单
        public void Remove(int orderId)
        {
            Order order = GetById(orderId);
            if (order == null) return;
            orderList.Remove(order);
        }
        //XML序列化方法
        public static void Export(XmlSerializer ser,string fileName,object obj)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            ser.Serialize(fs, obj);
            fs.Close();
        }
        //XML反序列化方法
        public static object Import(XmlSerializer ser,string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            object obj = ser.Deserialize(fs);
            fs.Close();
            return obj;
        }
    }
}
