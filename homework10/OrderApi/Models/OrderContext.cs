using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApi.Models {
    public class OrderContext:DbContext {
        public OrderContext(DbContextOptions<OrderContext> options):base(options) {
        }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderItems { get; set; }
    
    }
}