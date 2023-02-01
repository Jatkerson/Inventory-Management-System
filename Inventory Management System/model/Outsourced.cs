using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Management_System.model;

namespace Inventory_Management_System
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }


        public Outsourced(int partID, string partName, decimal partPrice, int partInStock, int partMin, int partMax, string companyName)
        {
            PartID = partID;
            Name = partName;
            Price = partPrice;
            InStock = partInStock;
            Min = partMin;
            Max = partMax;
            CompanyName = companyName;
        }

        public Outsourced()
        {

        }

        public override string ToString()
        {
            return CompanyName.ToString();
        }
    }
}
