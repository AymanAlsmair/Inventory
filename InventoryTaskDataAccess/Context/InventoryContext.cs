using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using InventoryTaskDataAccess.Entities;

namespace InventoryTaskDataAccess.Context
{
    public class InventoryContext : DbContext
    {
        public InventoryContext() : base("name = DBconnection") { }

        public virtual DbSet<Brand> Brd { set; get; }
        public virtual DbSet<Category> categ { set; get; }
        public virtual DbSet<Store> stor { set; get; }
        public virtual DbSet<Attributes> att { set; get; }
        public virtual DbSet<AttributeValue> att_val { set; get; }
        public virtual DbSet<Product> prod { set; get; }
        public virtual DbSet<Order> ordr { set; get; }
        public virtual DbSet<Company> compny { set; get; }
        public virtual DbSet<Currency> Curenc { set; get; }
        public virtual DbSet<Country> Cuntr { set; get; }

    }
}
