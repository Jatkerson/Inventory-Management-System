using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System.model;
using System.Text.RegularExpressions;


namespace Inventory_Management_System
{
    public partial class ModifyProduct : Form
    {
        public int selected_associated_part_index = -1;
        public int selected_associated_part_id = -1;


        // Intialize valid variables to false
        private bool valid_name = false;
        private bool valid_inventory = false;
        private bool valid_price = false;
        private bool valid_max = false;
        private bool valid_min = false;


        public ModifyProduct()
        {
            InitializeComponent();


            // Load selected part
            modify_product_id_text_box.Text = Inventory.products[MainScreen.selected_product_index].ProductID.ToString();
            modify_product_name_text_box.Text = Inventory.products[MainScreen.selected_product_index].Name;
            modify_product_inventory_numeric.Value = Inventory.products[MainScreen.selected_product_index].InStock;
            modify_product_price_text_box.Text = Inventory.products[MainScreen.selected_product_index].Price.ToString();
            modify_product_max_numeric.Value = Inventory.products[MainScreen.selected_product_index].Max;
            modify_product_min_numeric.Value = Inventory.products[MainScreen.selected_product_index].Min;


            // Initialize part list
            BindingList<Part> allPartsWithoutAssociated = new BindingList<Part>();


            // Loop through all parts and add
            foreach (Part partToAdd in Inventory.allParts)
            {
                allPartsWithoutAssociated.Add(partToAdd);
            }


            // Loop through all associated parts and remove from without associated list
            foreach (Part partToRemove in Inventory.products[MainScreen.selected_product_index].AssociatedParts)
            {
                allPartsWithoutAssociated.Remove(partToRemove);
            }


            // Set datasources
            datagrid_modify_product_all_parts.DataSource = allPartsWithoutAssociated;
            datagrid_modify_product_associate_parts.DataSource = Inventory.products[MainScreen.selected_product_index].AssociatedParts;


            // Ensure buttons are disabled
            modify_product_part_delete_button.Enabled = false;
            modify_product_save_button.Enabled = false;
        }

        private void button_add_product_cancel_Click(object sender, EventArgs e)
        {
            // Reset values
            MainScreen.selected_part_index = -1;
            MainScreen.selected_product_index = -1;
            selected_associated_part_index = -1;
            selected_associated_part_id = -1;


            // Hide main screen and display new form
            this.Visible = false;
            MainScreen newForm = new MainScreen();
            newForm.Show();
        }


        private void datagrid_modify_product_associate_parts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Check if row was not selected - return
            if (!datagrid_modify_product_associate_parts.CurrentRow.Selected)
            {
                return;
            }


            // Set selected part index
            selected_associated_part_index = datagrid_modify_product_associate_parts.CurrentCell.RowIndex;

            modify_product_part_delete_button.Enabled = true;
        }

        private void datagrid_modify_product_all_parts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if row was not selected - return
            if (!datagrid_modify_product_all_parts.CurrentRow.Selected)
            {
                return;
            }


            // Set selected part index
            selected_associated_part_id = Convert.ToInt32(datagrid_modify_product_all_parts.CurrentRow.Cells[0].Value);

            modify_product_part_add_button.Enabled = true;
        }

        private void modify_product_part_delete_button_Click(object sender, EventArgs e)
        {

            // Remove associated part from product
            Inventory.products[MainScreen.selected_product_index].AssociatedParts.RemoveAt(selected_associated_part_index);


            // Initialize part list
            BindingList <Part> allPartsWithoutAssociated = new BindingList<Part>();


            // Add all parts
            foreach (Part part in Inventory.allParts)
            {
                allPartsWithoutAssociated.Add(part);
            }

            // Loop through all associated parts and remove from without associated list
            foreach (Part partToRemove in Inventory.products[MainScreen.selected_product_index].AssociatedParts)
            {
                allPartsWithoutAssociated.Remove(partToRemove);
            }


            // Set datasources
            datagrid_modify_product_all_parts.DataSource = allPartsWithoutAssociated;
            datagrid_modify_product_associate_parts.DataSource = Inventory.products[MainScreen.selected_product_index].AssociatedParts;


            // Reset values
            selected_associated_part_index = -1;
            selected_associated_part_id = -1;


            // Clear selections
            datagrid_modify_product_associate_parts.ClearSelection();
            datagrid_modify_product_all_parts.ClearSelection();

            MessageBox.Show("Association removed");
        }

        private void datagrid_modify_product_associate_parts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            datagrid_modify_product_associate_parts.ClearSelection();
        }

        private void datagrid_modify_product_all_parts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            datagrid_modify_product_all_parts.ClearSelection();
        }

        private void modify_product_part_add_button_Click(object sender, EventArgs e)
        {

            // Match part id to selected and add to associated
            foreach (Part part in Inventory.allParts)
            {
                if(part.PartID == selected_associated_part_id)
                {
                    Inventory.products[MainScreen.selected_product_index].AssociatedParts.Add(part);
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
            foreach (Part partToRemove in Inventory.products[MainScreen.selected_product_index].AssociatedParts)
            {
                allPartsWithoutAssociated.Remove(partToRemove);
            }


            // Set datasources
            datagrid_modify_product_all_parts.DataSource = allPartsWithoutAssociated;
            datagrid_modify_product_associate_parts.DataSource = Inventory.products[MainScreen.selected_product_index].AssociatedParts;


            // Reset values
            selected_associated_part_index = -1;
            selected_associated_part_id = -1;

            // Clear selections
            datagrid_modify_product_associate_parts.ClearSelection();
            datagrid_modify_product_all_parts.ClearSelection();

            MessageBox.Show("Association added");
        }

        private void modify_product_name_text_box_TextChanged(object sender, EventArgs e)
        {
            if (modify_product_name_text_box.Text.Length > 0)
            {
                modify_product_name_text_box.BackColor = SystemColors.Window;
                valid_name = true;
            }
            else
            {
                modify_product_name_text_box.BackColor = Color.IndianRed;
                valid_name = false;
            }


            // Check if part can be added
            check_modify_product_complete();
        }


        private void modify_product_inventory_numeric_ValueChanged(object sender, EventArgs e)
        {
            // Check all inventory values
            check_modify_product_inventory();
        }

        private void modify_product_max_numeric_ValueChanged(object sender, EventArgs e)
        {
            // Check all inventory values
            check_modify_product_inventory();
        }

        private void modify_product_min_numeric_ValueChanged(object sender, EventArgs e)
        {
            // Check all inventory values
            check_modify_product_inventory();
        }



        public void check_modify_product_inventory()
        {
            // Check if max is less than min or min is more than max
            if (modify_product_max_numeric.Value < modify_product_min_numeric.Value || modify_product_min_numeric.Value > modify_product_max_numeric.Value)
            {
                modify_product_max_numeric.BackColor = Color.IndianRed;
                modify_product_min_numeric.BackColor = Color.IndianRed;
                valid_max = false;
                valid_min = false;
            }
            else
            {
                // Check min is between 1 - 10000
                if (modify_product_min_numeric.Value > 0 && modify_product_min_numeric.Value <= 10000)
                {
                    modify_product_min_numeric.BackColor = SystemColors.Window;
                    valid_min = true;
                }
                else
                {
                    modify_product_min_numeric.BackColor = Color.IndianRed;
                    valid_min = false;
                }

                // Check max is between 1 - 10000
                if (modify_product_max_numeric.Value > 0 && modify_product_max_numeric.Value <= 10000)
                {
                    modify_product_max_numeric.BackColor = SystemColors.Window;
                    valid_max = true;
                }
                else
                {
                    modify_product_max_numeric.BackColor = Color.IndianRed;
                    valid_max = false;
                }
            }


            // Check if inventory is outside min and max
            if (modify_product_inventory_numeric.Value > modify_product_max_numeric.Value || modify_product_inventory_numeric.Value < modify_product_min_numeric.Value)
            {
                modify_product_inventory_numeric.BackColor = Color.IndianRed;
                valid_inventory = false;
            }
            else
            {
                modify_product_inventory_numeric.BackColor = SystemColors.Window;
                valid_inventory = true;
            }


            // Check if part can be added
            check_modify_product_complete();

        }


        private void modify_product_price_text_box_TextChanged(object sender, EventArgs e)
        {

            string pattern = @"^[0-9]*(\.[0-9]{2})$";

            Regex rg = new Regex(pattern);

            if (Regex.Match(modify_product_price_text_box.Text, pattern).Success)
            {
                modify_product_price_text_box.BackColor = SystemColors.Window;
                valid_price = true;
            }
            else
            {
                modify_product_price_text_box.BackColor = Color.IndianRed;
                valid_price = false;
            }


            // Check if part can be added
            check_modify_product_complete();
        }


        public void check_modify_product_complete()
        {

            // Enable save button if all inputs are valid - otherwise disable
            if (valid_name && valid_inventory && valid_price && valid_max && valid_min)
            {
                modify_product_save_button.Enabled = true;
            }
            else
            {
                modify_product_save_button.Enabled = false;
            }
        }

        private void modify_product_save_button_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(modify_product_id_text_box.Text);
            int index = -1;
            BindingList<Part> parts = new BindingList<Part>();

            for (int i = 0; i < Inventory.allParts.Count; i++)
            {
                if (Inventory.products[i].ProductID == id)
                {
                    index = i;
                    parts = Inventory.products[i].AssociatedParts;
                    break;
                }
            }


            // Attempt to modify product
            Product modProduct = new Product(Convert.ToInt32(modify_product_id_text_box.Text), modify_product_name_text_box.Text, Convert.ToDecimal(modify_product_price_text_box.Text), (int)modify_product_inventory_numeric.Value, (int)modify_product_min_numeric.Value, (int)modify_product_max_numeric.Value, parts);

            Inventory.products[index] = modProduct;


            MessageBox.Show("Product Updated");


            // Display main screen
            this.Visible = false;
            MainScreen newForm = new MainScreen();
            newForm.Show();

         
        }

        private void modify_product_search_button_Click(object sender, EventArgs e)
        {

            // Previous search system - removes all non-matching rows
            string part_name;
            string search_string = modify_product_search_text_box.Text;


            // Use currency manager to suspend binding until rows are hidden
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[datagrid_modify_product_all_parts.DataSource];
            currencyManager.SuspendBinding();


            // Show all rows
            for (int i = 0; i < datagrid_modify_product_all_parts.RowCount; i++)
            {
                datagrid_modify_product_all_parts.Rows[i].Visible = true;
            }


            // Loop through all rows
            for (int i = 0; i < datagrid_modify_product_all_parts.RowCount; i++)
            {

                // Get list item part name
                part_name = datagrid_modify_product_all_parts.Rows[i].Cells[1].Value.ToString();


                // Check if part name container search string - hide 
                if (!part_name.Contains(search_string))
                {
                    datagrid_modify_product_all_parts.Rows[i].Visible = false;
                }
            }


            // Rows hidden - resume binding
            currencyManager.ResumeBinding();

        }
    }
}
