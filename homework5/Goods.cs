using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5
{
    class Goods
    {
        private double price;  //商品价格

        public int Id { get; set; }  //商品ID
        public string Name { get; set; }  //商品名称
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value must >= 0!");
                price = value;
            }
        }

        public Goods(int id,string name,double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
        public Goods() { }
        //重写ToString方法
        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Value:{Price}";
        }
    }
}
