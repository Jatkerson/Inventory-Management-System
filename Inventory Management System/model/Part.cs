using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Inventory_Management_System.model
{
    public abstract class Part
    {

        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        public Part()
        {

        }

        public Part(int partID, string partName, decimal partPrice, int partInStock, int partMin, int partMax)
        {
            PartID = partID;
            Name = partName;
            Price = partPrice;
            InStock = partInStock;
            Min = partMin;
            Max = partMax;
        }

    }
}
