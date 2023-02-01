using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory_Management_System.model
{
    public class Inventory: Part
    {

        public static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Part> allParts = new BindingList<Part>();

        static Inventory()
        {
            _ = new Inventory(true);
        }

        public Inventory(bool populate)
        {

            // Remove any current parts
            for(int i = 0; i < allParts.Count; i++)
            {
                allParts.RemoveAt(i);
            }


            // Populate list
            if (populate)
            {
                // Create first 3 initial parts
                InHouse part1 = new InHouse(1, "Chain", 3.99M, 8, 5, 20, 123);
                InHouse part2 = new InHouse(2, "Tire", 9.99M, 4, 3, 15, 456);
                Outsourced part3 = new Outsourced(3, "Seat", 7.99M, 7, 1, 10, "Seats R Us");


                // Add initial parts
                allParts.Add(part1);
                allParts.Add(part2);
                allParts.Add(part3);


                // Create list of parts to associate with initial products
                BindingList<Part> product1Parts = new BindingList<Part>();
                BindingList<Part> product2Parts = new BindingList<Part>();
                BindingList<Part> product3Parts = new BindingList<Part>();


                // Add initial associate product parts
                product1Parts.Add(part1);
                product2Parts.Add(part1);
                product2Parts.Add(part2);
                product3Parts.Add(part1);
                product3Parts.Add(part2);
                product3Parts.Add(part3);


                // Create first 3 initial products
                Product product1 = new Product(1, "Red Bicycle", 19.99M, 9, 4, 15, product1Parts);
                Product product2 = new Product(2, "Green Bicycle", 26.99M, 5, 2, 11, product2Parts);
                Product product3 = new Product(3, "Blue Bicycle", 12.99M, 14, 9, 22, product3Parts);


                // Add initial parts
                products.Add(product1);
                products.Add(product2);
                products.Add(product3);
            }

        }


        public Inventory()
        {

        }


        public void addProduct(Product product)
        {
        
        }


        public bool removeProduct(int index)
        {
            return true;
        }


        public int lookupProduct(int index)
        {
            return 0;
        }


        public void updateProduct(int index, Product product)
        {

        }


        public void addPart(Part part)
        {
            allParts.Add(part);
        }


        public bool deletePart(Part dPart)
        {

            // Loop through allParts to determine if part to be deleted exists
            // Then delete part and return true
            foreach(Part allPartList in allParts)
            {
                if(allPartList.PartID == dPart.PartID)
                {
                    allParts.Remove(allPartList);
                    return true;
                }
            }


            // Part was not found in allParts
            return false;

        }

        public BindingList<Part> lookupPart(int search_value)
        {
            return new BindingList<Part>();
        }

        public void updatePart(int index, Part part)
        {

            allParts[index] = part;

        }




    }
}
