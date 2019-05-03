using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data.Entity;

namespace ordertest {
  /// <summary>
  /// OrderService
  /// </summary>
  public class OrderService:DbContext {

    private List<Order> orderList;
    /// <summary>
    /// constructor
    /// </summary>
    public OrderService(){
      orderList = new List<Order>();
    }
    /// <summary>
    /// add new order
    /// </summary>
    /// <param name="order">the order to be added</param>
    public void AddOrder(Order order) {
            /*  if (orderList.Contains(order)) {
                throw new ApplicationException($"the orderList contains an order with ID {order.Id} !");
              }
              orderList.Add(order);  */
            using (var db = new OrderDBContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
    }

    /// <summary>
    /// update the order
    /// </summary>
    /// <param name="order">the order to be updated</param>
    public void Update(Order order) {
            /*  RemoveOrder(order.Id);
              orderList.Add(order);  */
            using (var db = new OrderDBContext())
            {
                db.Orders.Attach(order);
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
            }
    }

    /// <summary>
    /// query by orderId
    /// </summary>
    /// <param name="orderId">id of the order to find</param>
    /// <returns>List<Order></returns> 
    public Order GetById(int orderId) {
            //  return orderList.FirstOrDefault(o => o.Id == orderId);
            using (var db = new OrderDBContext())
            {
                var query = from o in db.Orders where o.Id == orderId select o;
                if (query != null)
                    return (Order)query;
                else return null;
            }
    }

    /// <summary>
    /// remove order
    /// </summary>
    /// <param name="orderId">id of the order which will be removed</param> 
    public void RemoveOrder(int orderId) {
            //  orderList.RemoveAll(o => o.Id == orderId);
            using (var db = new OrderDBContext())
            {
                var order = db.Orders.SingleOrDefault(o => o.Id == orderId);
                db.Orders.Remove(order);
                db.SaveChanges();
            }
    }

    /// <summary>
    /// query all orders
    /// </summary>
    /// <returns>List<Order>:all the orders</returns> 
    public DbSet<Order> QueryAll() {
            //  return orderList;
            using (var db = new OrderDBContext())
            {
                return db.Orders;
            }
    }


    /// <summary>
    /// query by goodsName
    /// </summary>
    /// <param name="goodsName">the name of goods in order's orderDetail</param>
    /// <returns></returns> 
    public List<Order> QueryByGoodsName(string goodsName) {
    /*          var query = orderList.Where(
                o => o.Details.Exists(
                  d => d.Goods.Name == goodsName));
              return query.ToList();
     */
     using(var db=new OrderDBContext())
            {
                var query = db.Orders.Where(o => o.Details.Exists(d => d.Goods.Name == goodsName));
                return query.ToList();
            } 
    }

    /// <summary>
    /// query orders whose totalAmount >= totalAmount
    /// </summary>
    /// <param name="totalAmount">the minimum totalAmount</param>
    /// <returns></returns> 
    public List<Order> QueryByTotalAmount(float totalAmount) {
            /*  var query = orderList.Where(o=>o.TotalAmount>=totalAmount);
              return query.ToList(); */
            using (var db = new OrderDBContext())
            {
                var query = db.Orders.Where(o => o.TotalAmount >= totalAmount);
                return query.ToList();
            }
    }

    /// <summary>
    /// query by customerName
    /// </summary>
    /// <param name="customerName">customer name</param>
    /// <returns></returns> 
    public List<Order> QueryByCustomerName(string customerName) {
            /*  var query = orderList
                  .Where(o => o.Customer.Name == customerName);
              return query.ToList();
            */
            using (var db = new OrderDBContext())
            {
                var query = db.Orders.Where(o => o.Customer.Name == customerName);
                return query.ToList();
            }
    }

    public void Sort(Comparison<Order> comparison) {
              orderList.Sort(comparison);
    }

    /// <summary>
    /// Exprot the orders to an xml file.
    /// </summary>
    public void Export(String fileName) {
      if (Path.GetExtension(fileName) != ".xml")
        throw new ArgumentException("the exported file must be a xml file!");
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(fileName, FileMode.Create)) {
        xs.Serialize(fs, this.orderList);
      }
    }

    /// <summary>
    /// import from an xml file
    /// </summary>
    public List<Order> Import(string path) {
      if (Path.GetExtension(path) != ".xml")
        throw new ArgumentException($"{path} isn't a xml file!");
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      List<Order> result = new List<Order>();
      try {
        using (FileStream fs = new FileStream(path, FileMode.Open)) {
          return (List<Order>)xs.Deserialize(fs);
        }
      }catch(Exception e) {
        throw new ApplicationException("import error:" + e.Message);
      }
     
    }

  }
}
