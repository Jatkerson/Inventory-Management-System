using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Inventory_Management_System.model
{
    public class Product
    {

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        public BindingList<Part> AssociatedParts { get; set; }


        static Product()
        {

        }

        public Product(int productID, string productName, decimal productPrice, int productInStock, int productMin, int productMax, BindingList<Part> associatedParts)
        {
            ProductID = productID;
            Name = productName;
            Price = productPrice;
            InStock = productInStock;
            Min = productMin;
            Max = productMax;
            AssociatedParts = associatedParts;
        }


        public void addAssociatedPart(Part part)
        {

        }


        public bool removeAssociatedPart(int index)
        {
            return false;
        }


        public BindingList<Part> lookupAssociatedPart(int index)
        {
            return new BindingList<Part>();
        }

    }
}
