using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ZvukDb.Models;

namespace ZvukDb
{
   public class SoundEquipmentContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<CharacteristicType> CharacteristicTypes{ get; set; }
        public DbSet<ProductChatacteristic> ProductChatacteristics { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<User> Users { get; set; }

        public SoundEquipmentContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS01;Initial Catalog=SoundEquipment;Integrated Security=True");
        }
    }
}
