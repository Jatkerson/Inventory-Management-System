using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Management_System.model;

namespace Inventory_Management_System
{
    public class InHouse : Part
    {
        public new int MachineID { get; set; }


        public InHouse(int partID, string partName, decimal partPrice, int partInStock, int partMin, int partMax, int machineID)
        {
            PartID = partID;
            Name = partName;
            Price = partPrice;
            InStock = partInStock;
            Min = partMin;
            Max = partMax;
            MachineID = machineID;
        }

        public InHouse()
        {

        }


        public override string ToString()
        {
            return MachineID.ToString();
        }

    }
}
