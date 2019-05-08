using System;
using System.ComponentModel.DataAnnotations;

namespace OrderApi.Models {
    public class OrderDetail {
        [Key]
        public long Id { get; set; }
        public string Product { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        public OrderDetail(long id, string product, double unitPrice, int quantity) {
            Id = id;
            Product = product;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        public override bool Equals(object obj) {
          var item = obj as OrderDetail;
          return item != null &&
                 Id == item.Id;
        }
  }
}