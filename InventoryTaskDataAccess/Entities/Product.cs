using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryTaskDataAccess.Entities
{
    public class Product
    {
        public int ID { set; get; }
        public string ImagePath { set; get; }
        //public HttpPostedFileBase ImageFile { set; get; }
        public string Product_Name { set; get; }
        public string SKU { set; get; }
        public double Price { set; get; }
        public int QTY { set; get; }
        public string Description { set; get; }
        
        [ForeignKey("color")]
        public int color_id { set; get; }
        [ForeignKey("size")]
        public int Size_id { set; get; }
        [ForeignKey("brnd")]
        public int Brand_id { set; get; }
        [ForeignKey("categ")]
        public int category_id { set; get; }
        [ForeignKey("str")]
        public int stor_id { set; get; }
        public string Availability { set; get; }

        public AttributeValue color { set; get; }
        public AttributeValue size { set; get; }
        
        public Brand brnd { set; get; }
        public Category categ { set; get; }
        public Store str { set; get; }

        
        

        
    }
}
