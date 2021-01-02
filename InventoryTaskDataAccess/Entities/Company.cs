using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryTaskDataAccess.Entities
{
    public class Company
    {
        public int ID { set; get; }
        public string Company_Name { set; get; }
        public double Charge_Amount { set; get; }
        public double Vat_Charge { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }

        [ForeignKey("cnt")]
        public int Country_id { set; get; }
        public string Message { set; get; }

        [ForeignKey("curn")]
        public int Currency_id { set; get; }

        public Currency curn { set; get; }
        public Country cnt { set; get; }
    }
}
