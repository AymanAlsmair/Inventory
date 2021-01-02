using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryTaskDataAccess.Entities
{
    public class Order
    {
        public int ID { set; get; }
        public string Pill_NO { set; get; }
        public string Customer_Name { set; get; }
        public string Customer_Address { set; get; }
        public string Customer_Phone { set; get; }

        [ForeignKey("pro")]
        public int Product_id { set; get; }
        public int qty { set; get; }

        public double Amount {set; get;}
        public double Gross_Amount { set; get; }
        public double Vat { set; get; }
        public double Discount { set; get; }
        public double Net_Amount { set; get; }
        public string Status { set; get; }
        public Product pro { set; get; }
    }
}
