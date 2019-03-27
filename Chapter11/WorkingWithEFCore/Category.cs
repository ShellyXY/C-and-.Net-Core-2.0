using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packet.CS7
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        //define a navigation property for related rows
        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            //to enable developers to add products to a Category we must
            //initialize the navigation property to an empry list
            this.Products = new List<Product>();
        }

    }
}
