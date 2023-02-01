using Inventory_Management_System.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class MainScreen : Form
    {

        public static int selected_part_index = -1;
        public static int selected_product_index = -1;

        public MainScreen()
        {
            InitializeComponent();


            // Display parts datagrid
            datagrid_main_screen_parts.DataSource = Inventory.allParts;
            datagrid_main_screen_products.DataSource = Inventory.products;

        }

        private void button_main_screen_add_parts_Click(object sender, EventArgs e)
        {

            // Hide main screen and display new form
            this.Visible = false;
            AddPart newForm = new AddPart();
            newForm.Show();

        }

        private void button_main_screen_modify_parts_Click(object sender, EventArgs e)
        {
            if (selected_part_index != -1)
            {

                // Hide main screen and display new form
                this.Visible = false;
                ModifyPart newForm = new ModifyPart();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Select a part to modify");
            }
        }

        private void button_main_screen_add_products_Click(object sender, EventArgs e)
        {
            // Hide main screen and display new form
            this.Visible = false;
            AddProduct newForm = new AddProduct();
            newForm.Show();
        }

        private void button_main_screen_modify_products_Click(object sender, EventArgs e)
        {
            

            if (selected_product_index == -1)
            {
                MessageBox.Show("Select a product to modify");
            }
            else
            {
                // Hide main screen and display new form
                this.Visible = false;
                ModifyProduct newForm = new ModifyProduct();
                newForm.Show();
            }
        }

        private void button_main_screen_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void datagrid_main_screen_parts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            datagrid_main_screen_parts.ClearSelection();
        }

        private void datagrid_main_screen_products_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            datagrid_main_screen_products.ClearSelection();
        }

        private void datagrid_main_screen_parts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Check if row was not selected - return
            if (!datagrid_main_screen_parts.CurrentRow.Selected)
            {
                return;
            }


            // Set selected part index
            selected_part_index = datagrid_main_screen_parts.CurrentCell.RowIndex;

        }

        private void button_main_screen_delete_parts_Click(object sender, EventArgs e)
        {

            // Prevent delete if new index has not been set
            if (selected_part_index == -1)
            {

                MessageBox.Show("Select a part to delete"); 
                return;
            }


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                // Loop through all products and remove associated part
                foreach (Product product in Inventory.products)
                {
                    int i = 0;

                    while(i < product.AssociatedParts.Count())
                    {
                        if (product.AssociatedParts[i].PartID == Inventory.allParts[selected_part_index].PartID)
                        {
                            product.AssociatedParts.RemoveAt(i);
                        }

                        i++;
                    }
                }


                // Remove part by index
                Inventory.allParts.RemoveAt(selected_part_index);


                // Reset part index
                selected_part_index = -1;

            }

        }


        private void datagrid_main_screen_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if row was not selected - return
            if (!datagrid_main_screen_products.CurrentRow.Selected)
            {
                return;
            }


            // Set selected part index
            selected_product_index = datagrid_main_screen_products.CurrentCell.RowIndex;

        }

        private void button_main_screen_delete_products_Click(object sender, EventArgs e)
        {

            // Prevent delete if new index has not been set
            if (selected_product_index == -1)
            {
                return;
            }


            // Ensure product has no associated parts
            if(Inventory.products[selected_product_index].AssociatedParts.Count() != 0)
            {
                MessageBox.Show("Unable to delete a product with associated parts");
                return;
            }


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                // Delete the selected part
                Inventory.products.RemoveAt(selected_product_index);


                // Reset part index
                selected_product_index = -1;

            }

        }

        private void button_main_screen_search_parts_Click(object sender, EventArgs e)
        {

            // Previous search system - removes all non-matching rows
            string part_name;
            string search_string = textbox_main_screen_search_parts.Text;


            // Use currency manager to suspend binding until rows are hidden
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[datagrid_main_screen_parts.DataSource];
            currencyManager.SuspendBinding();


            // Show all rows
            for (int i = 0; i < datagrid_main_screen_parts.RowCount; i++)
            {
                datagrid_main_screen_parts.Rows[i].Visible = true;
            }


            // Loop through all rows
            for (int i = 0; i < datagrid_main_screen_parts.RowCount; i++)
            {

                // Get list item part name
                part_name = datagrid_main_screen_parts.Rows[i].Cells[1].Value.ToString();


                // Check if part name container search string - hide 
                if (!part_name.Contains(search_string))
                {
                    datagrid_main_screen_parts.Rows[i].Visible = false;
                }
            }


            // Rows hidden - resume binding
            currencyManager.ResumeBinding();
            
        }

        private void button_main_screen_search_products_Click(object sender, EventArgs e)
        {
            string product_name;
            string search_string = textbox_main_screen_search_products.Text;


            // Use currency manager to suspend binding until rows are hidden
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[datagrid_main_screen_products.DataSource];
            currencyManager.SuspendBinding();


            // Show all rows
            for (int i = 0; i < datagrid_main_screen_products.RowCount; i++)
            {
                datagrid_main_screen_products.Rows[i].Visible = true;
            }


            // Loop through all rows
            for (int i = 0; i < datagrid_main_screen_products.RowCount; i++)
            {

                // Get list item product name
                product_name = datagrid_main_screen_products.Rows[i].Cells[1].Value.ToString();

                //MessageBox.Show(product_name + " '" + search_string + "'");

                // Check if product name container search string - hide 
                if (!product_name.Contains(search_string))
                {
                    datagrid_main_screen_products.Rows[i].Visible = false;
                }
            }


            // Rows hidden - resume binding
            currencyManager.ResumeBinding();
        }
    }
}
