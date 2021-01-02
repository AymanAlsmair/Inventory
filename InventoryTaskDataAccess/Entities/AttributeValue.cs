using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InventoryTaskDataAccess.Entities
{
    public class AttributeValue
    {
        public int ID { set; get; }
        public string Att_Nae { set; get; }

        [ForeignKey("getAtt")]
        public int att_id { set; get; }

        [InverseProperty("size")]
        public List<Product> lisize { set; get; }

        [InverseProperty("color")]
        public List<Product> licolor { set; get; }

        public Attributes getAtt { set; get; }
    }
}
