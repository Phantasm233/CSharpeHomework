using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5
{
    class Customer
    {
        public int Id { get; set; }  //客户ID
        public string Name { get; set; }  //客户名

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Customer() { }
        //重写ToString方法
        public override string ToString()
        {
            return $"customerId:{Id}, CustomerName:{Name}";
        }
    }
}
