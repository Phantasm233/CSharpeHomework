using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5
{
    class OrderDetails
    {
        private Goods myGoods;  //商品
        private int myCount;  //商品数量

        public int id { get; set; }  //订单明细ID
        public Goods goods
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

        public OrderDetails(int id,Goods goods,int count)
        {
            this.id = id;
            this.goods = goods;
            this.count = count;
        }
        public OrderDetails() { }
        //重写Equals方法
        public override bool Equals(object obj)
        {
            if(obj is OrderDetails)
            {
                OrderDetails m = (OrderDetails)obj;
                if (m.id == this.id)
                    return true;
            }
            return false;
        }
        //重写ToString方法
        public override string ToString()
        {
            string result = "";
            result += $"orderDetailId:{id}:  ";
            result += goods + $", count:{count}";
            return result;
        }
    }
}
