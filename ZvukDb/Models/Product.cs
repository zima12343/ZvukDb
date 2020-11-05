using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace ZvukDb.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public ProductType ProductType { get; set; }
        public List<ProductChatacteristic> productChatacteristics { get; set; }
    }
}
