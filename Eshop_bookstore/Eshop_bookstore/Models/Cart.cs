using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_Bookstore.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        [DisplayFormat(DataFormatString = "{0:#,##0} VNĐ")]
        public int Total => Product.Price * Quantity;
    }
}
