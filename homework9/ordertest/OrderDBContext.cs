using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ordertest
{
    class OrderDBContext : DbContext
    {
        public OrderDBContext() : base("OrderDB")
        { }
        public DbSet<Order>Orders
        {
            get; set;
        }
        public DbSet<OrderDetail>OrderDetails
        {
            get; set;
        }
        public DbSet<Customer>Customers
        {
            get; set;
        }
        public DbSet<Goods>Goodses
        {
            get; set;
        }
    }
}
