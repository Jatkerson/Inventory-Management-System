using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Management_System.model;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Inventory_Management_System
{
    public partial class AddProduct : Form
    {

        public int selected_associated_part_index = -1;
        public int selected_associated_part_id = -1;
        public BindingList<Part> newProductParts = new BindingList<Part>();


        // Intialize valid variables to false
        private bool valid_name = false;
        private bool valid_inventory = false;
        private bool valid_price = false;
        private bool valid_max = false;
        private bool valid_min = false;


        public AddProduct()
        {
            InitializeComponent();

            int new_id = 1;

            // Loop through all parts
            // If part has a higher ID set the new_id to that part ID + 1
            for (int i = 0; i < Inventory.products.Count; i++)
            {
                if (Inventory.products[i].ProductID >= new_id)
                {
                    new_id = Inventory.products[i].ProductID + 1;
                }
            }


            // Initialize part list
            BindingList<Part> emptyParts = new BindingList<Part>();


            // Set datasources
            datagrid_add_product_all_parts.DataSource = Inventory.allParts;
            datagrid_add_product_associate_parts.DataSource = emptyParts;


            // Reset all input values, variables and buttons
            add_product_id_text_box.Enabled = false;
            add_product_id_text_box.Text = new_id.ToString();
            add_product_name_text_box.BackColor = SystemColors.Window;
            add_product_inventory_numeric.BackColor = SystemColors.Window;
            add_product_price_text_box.BackColor = SystemColors.Window;
            add_product_max_numeric.BackColor = SystemColors.Window;
            add_product_min_numeric.BackColor = SystemColors.Window;
            add_product_save_button.Enabled = false;
            add_product_name_text_box.Text = "";
            add_product_inventory_numeric.Value = 0;
            add_product_price_text_box.Text = "";
            add_product_max_numeric.Value = 0;
            add_product_min_numeric.Value = 0;
            add_product_max_numeric.Value = 0;
            add_product_min_numeric.Value = 0;



            // Ensure buttons are disabled
            add_product_part_delete_button.Enabled = false;
            add_product_save_button.Enabled = false;


        }

        private void button_add_product_cancel_Click(object sender, EventArgs e)
        {
            // Hide main screen and display new form
            this.Visible = false;
            MainScreen newForm = new MainScreen();
            newForm.Show();
        }


        private void datagrid_add_product_associate_parts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Check if row was not selected - return
            if (!datagrid_add_product_associate_parts.CurrentRow.Selected)
            {
                return;
            }


            // Set selected part index
            selected_associated_part_index = datagrid_add_product_associate_parts.CurrentCell.RowIndex;

            add_product_part_delete_button.Enabled = true;
        }

        private void datagrid_add_product_all_parts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if row was not selected - return
            if (!datagrid_add_product_all_parts.CurrentRow.Selected)
            {
                return;
            }


            // Set selected part index
            selected_associated_part_id = Convert.ToInt32(datagrid_add_product_all_parts.CurrentRow.Cells[0].Value);

            add_product_part_add_button.Enabled = true;

        }

        private void add_product_part_delete_button_Click(object sender, EventArgs e)
        {

            // Remove associated part from product
            newProductParts.RemoveAt(selected_associated_part_index);


            // Initialize part list
            BindingList<Part> allPartsWithoutAssociated = new BindingList<Part>();


            // Add all parts
            foreach (Part part in Inventory.allParts)
            {
                allPartsWithoutAssociated.Add(part);
            }

            // Loop through all associated parts and remove from without associated list
            foreach (Part partToRemove in newProductParts)
            {
                allPartsWithoutAssociated.Remove(partToRemove);
            }


            // Set datasources
            datagrid_add_product_all_parts.DataSource = allPartsWithoutAssociated;
            datagrid_add_product_associate_parts.DataSource = newProductParts;


            // Reset values
            selected_associated_part_index = -1;
            selected_associated_part_id = -1;


            // Clear selections
            datagrid_add_product_associate_parts.ClearSelection();
            datagrid_add_product_all_parts.ClearSelection();

            add_product_part_delete_button.Enabled = false;

        }

        private void datagrid_add_product_associate_parts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            datagrid_add_product_associate_parts.ClearSelection();
        }

        private void datagrid_add_product_all_parts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            datagrid_add_product_all_parts.ClearSelection();
        }

        private void add_product_part_add_button_Click(object sender, EventArgs e)
        {

            // Match part id to selected and add to associated
            foreach (Part part in Inventory.allParts)
            {
                if (part.PartID == selected_associated_part_id)
                {
                    newProductParts.Add(part);
                }
            }


            // Initialize part list
            BindingList<Part> allPartsWithoutAssociated = new BindingList<Part>();


            // Add all parts
            foreach (Part part in Inventory.allParts)
            {
                allPartsWithoutAssociated.Add(part);
            }

            // Loop through all associated parts and remove from without associated list
            foreach (Part partToRemove in newProductParts)
            {
                allPartsWithoutAssociated.Remove(partToRemove);
            }


            // Set datasources
            datagrid_add_product_all_parts.DataSource = allPartsWithoutAssociated;
            datagrid_add_product_associate_parts.DataSource = newProductParts;


            // Reset values
            selected_associated_part_index = -1;
            selected_associated_part_id = -1;

            // Clear selections
            datagrid_add_product_associate_parts.ClearSelection();
            datagrid_add_product_all_parts.ClearSelection();

            add_product_part_add_button.Enabled = false;

        }



        private void add_product_name_text_box_TextChanged(object sender, EventArgs e)
        {
            if (add_product_name_text_box.Text.Length > 0)
            {
                add_product_name_text_box.BackColor = SystemColors.Window;
                valid_name = true;
            }
            else
            {
                add_product_name_text_box.BackColor = Color.IndianRed;
                valid_name = false;
            }


            // Check if part can be added
            check_add_product_complete();
        }


        private void add_product_inventory_input_changed(object sender, EventArgs e)
        {
            // Check all inventory values
            check_add_product_inventory();
        }

        private void add_product_inventory_input_changed(object sender, KeyEventArgs e)
        {
            // Check all inventory values
            check_add_product_inventory();
        }


        public void check_add_product_inventory()
        {
            // Check if max is less than min or min is more than max
            if (add_product_max_numeric.Value < add_product_min_numeric.Value || add_product_min_numeric.Value > add_product_max_numeric.Value)
            {
                add_product_max_numeric.BackColor = Color.IndianRed;
                add_product_min_numeric.BackColor = Color.IndianRed;
                valid_max = false;
                valid_min = false;
            }
            else
            {
                // Check min is between 1 - 10000
                if (add_product_min_numeric.Value > 0 && add_product_min_numeric.Value <= 10000)
                {
                    add_product_min_numeric.BackColor = SystemColors.Window;
                    valid_min = true;
                }
                else
                {
                    add_product_min_numeric.BackColor = Color.IndianRed;
                    valid_min = false;
                }

                // Check max is between 1 - 10000
                if (add_product_max_numeric.Value > 0 && add_product_max_numeric.Value <= 10000)
                {
                    add_product_max_numeric.BackColor = SystemColors.Window;
                    valid_max = true;
                }
                else
                {
                    add_product_max_numeric.BackColor = Color.IndianRed;
                    valid_max = false;
                }
            }


            // Check if inventory is outside min and max
            if (add_product_inventory_numeric.Value > add_product_max_numeric.Value || add_product_inventory_numeric.Value < add_product_min_numeric.Value)
            {
                add_product_inventory_numeric.BackColor = Color.IndianRed;
                valid_inventory = false;
            }
            else
            {
                add_product_inventory_numeric.BackColor = SystemColors.Window;
                valid_inventory = true;
            }


            // Check if part can be added
            check_add_product_complete();

        }


        private void add_product_price_text_box_TextChanged(object sender, EventArgs e)
        {

            string pattern = @"^[0-9]*(\.[0-9]{2})$";

            Regex rg = new Regex(pattern);

            if (Regex.Match(add_product_price_text_box.Text, pattern).Success)
            {
                add_product_price_text_box.BackColor = SystemColors.Window;
                valid_price = true;
            }
            else
            {
                add_product_price_text_box.BackColor = Color.IndianRed;
                valid_price = false;
            }


            // Check if part can be added
            check_add_product_complete();
        }


        public void check_add_product_complete()
        {

            // Enable save button if all inputs are valid - otherwise disable
            if (valid_name && valid_inventory && valid_price && valid_max && valid_min)
            {
                add_product_save_button.Enabled = true;
            }
            else
            {
                add_product_save_button.Enabled = false;
            }
        }


        private void button_add_product_save_Click(object sender, EventArgs e)
        {

            // Create new product
            Product addProduct = new Product(Convert.ToInt32(add_product_id_text_box.Text), add_product_name_text_box.Text, Convert.ToDecimal(add_product_price_text_box.Text), (int)add_product_inventory_numeric.Value, (int)add_product_min_numeric.Value, (int)add_product_max_numeric.Value, newProductParts);

            // Call function to add part
            Inventory.products.Add(addProduct);


            // Message new part name
            MessageBox.Show("Added Product: " + add_product_name_text_box.Text);



            // Return to mainScreen
            this.Visible = false;
            MainScreen newForm = new MainScreen();
            newForm.Show();

        }


        private void add_product_search_button_Click(object sender, EventArgs e)
        {

            // Previous search system - removes all non-matching rows
            string part_name;
            string search_string = add_product_search_text_box.Text;


            // Use currency manager to suspend binding until rows are hidden
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[datagrid_add_product_all_parts.DataSource];
            currencyManager.SuspendBinding();


            // Show all rows
            for (int i = 0; i < datagrid_add_product_all_parts.RowCount; i++)
            {
                datagrid_add_product_all_parts.Rows[i].Visible = true;
            }


            // Loop through all rows
            for (int i = 0; i < datagrid_add_product_all_parts.RowCount; i++)
            {

                // Get list item part name
                part_name = datagrid_add_product_all_parts.Rows[i].Cells[1].Value.ToString();


                // Check if part name container search string - hide 
                if (!part_name.Contains(search_string))
                {
                    datagrid_add_product_all_parts.Rows[i].Visible = false;
                }
            }


            // Rows hidden - resume binding
            currencyManager.ResumeBinding();


        }

    }
}
