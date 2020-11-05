using System;
using System.Collections.Generic;
using System.Text;

namespace ZvukDb.Models
{
    public class ProductChatacteristic
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public CharacteristicType CharacteristicType { get; set; }
        public string Value { get; set; }
    }
}
