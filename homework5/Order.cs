using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5
{
    class Order:IComparable
    {
        private int myOrderId;  //订单号
        private Customer myCustomer;  //客户
        public List<OrderDetails> details = new List<OrderDetails>();  //订单明细

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
        public Customer customer
        {
            get
            {
                return myCustomer;
            }
            set
            {
                myCustomer = value;
            }
        }

        public Order(int orderId, Customer customer)
        {
            this.orderId = orderId;
            this.customer = customer;
        }
        public Order() { }
        //添加订单明细
        public void AddDetails(OrderDetails orderDetail)
        {
            if (this.details.Contains(orderDetail))
            {
                throw new Exception($"orderDetails-{orderDetail.id} is already existed!");
            }
            details.Add(orderDetail);
        }
        //删除订单明细
        public void RemoveDetails(int orderDetailId)
        {
            details.RemoveAll(d => d.id == orderDetailId);
        }
        //重写Equals方法
        public override bool Equals(object obj)
        {
            if(obj is Order)
            {
                Order m = (Order)obj;
                if (m.orderId == this.orderId)
                    return true;
            }
            return false;
        }
        //重写ToString方法
        public override string ToString()
        {
            String result = $"orderId:{orderId}, customer:({customer})";
            details.ForEach(detail => result += "\n\t" + detail);
            return result;
        }
        //实现CompareTo方法
        public int CompareTo(object obj)
        {
            return this.orderId - (obj as Order).orderId;
        }
        //获得订单的总金额
        public double GetSumPrice()
        {
            double sum=0;
            foreach (OrderDetails detail in details)
            {
                sum += detail.count * detail.goods.Price;
            }
            return sum;
        }
    }
}
