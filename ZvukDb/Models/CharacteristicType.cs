using System;
using System.Collections.Generic;
using System.Text;

namespace ZvukDb.Models
{
    public class CharacteristicType
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public List<ProductChatacteristic> productChatacteristics { get; set; }
    }
}
