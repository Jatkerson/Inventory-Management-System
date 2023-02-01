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

    public partial class AddPart : Form
    {

        // Intialize valid variables to false
        private bool valid_name = false;
        private bool valid_inventory = false;
        private bool valid_price = false;
        private bool valid_max = false;
        private bool valid_min = false;
        private bool valid_machine_or_company = false;


        public AddPart()
        {
            InitializeComponent();

            // Set initial values for display
            add_part_machine_or_company_label.Text = "Machine ID";
            set_initial_add_part_display();
        }

        private void button_add_part_cancel_Click(object sender, EventArgs e)
        {
            // Hide main screen and display new form
            this.Visible = false;
            MainScreen newForm = new MainScreen();
            newForm.Show();
        }


        public void set_initial_add_part_display()
        {

            // Initialize new ID as 1
            int new_id = 1;

            // Loop through all parts
            // If part has a higher ID set the new_id to that part ID + 1
            for(int i = 0; i < Inventory.allParts.Count; i++)
            {
                if(Inventory.allParts[i].PartID >= new_id)
                {
                    new_id = Inventory.allParts[i].PartID + 1;
                }
            }


            // Set initial values
            add_part_in_house_radio_button.Checked = true;
            add_part_outsourced_radio_button.Checked = false;
            add_part_id_text_box.Enabled = false;
            add_part_id_text_box.Text = new_id.ToString();
            add_part_name_text_box.BackColor = SystemColors.Window;
            add_part_inventory_numeric.BackColor = SystemColors.Window;
            add_part_price_text_box.BackColor = SystemColors.Window;
            add_part_max_numeric.BackColor = SystemColors.Window;
            add_part_min_numeric.BackColor = SystemColors.Window;
            add_part_machine_or_company_text_box.BackColor = SystemColors.Window;
            button_add_part_save.Enabled = false;
            add_part_name_text_box.Text = "";
            add_part_inventory_numeric.Value = 0;
            add_part_price_text_box.Text = "";
            add_part_max_numeric.Value = 0;
            add_part_min_numeric.Value = 0;
            add_part_machine_or_company_text_box.Text = "";
            valid_name = false;
            valid_inventory = false;
            valid_price = false;
            valid_max = false;
            valid_min = false;
            valid_machine_or_company = false;
            add_part_max_numeric.Value = 0;
            add_part_min_numeric.Value = 0;

        }

        private void add_part_name_text_box_TextChanged(object sender, EventArgs e)
        {
            if(add_part_name_text_box.Text.Length > 0)
            {
                add_part_name_text_box.BackColor = SystemColors.Window;
                valid_name = true;
            }
            else
            {
                add_part_name_text_box.BackColor = Color.IndianRed;
                valid_name = false;
            }


            // Check if part can be added
            check_add_part_complete();
        }

        private void add_part_inventory_numeric_ValueChanged(object sender, EventArgs e)
        {
            // Check all inventory values
            check_add_part_inventory();
        }

        private void add_part_max_numeric_ValueChanged(object sender, EventArgs e)
        {
            // Check all inventory values
            check_add_part_inventory();
        }

        private void add_part_min_numeric_ValueChanged(object sender, EventArgs e)
        {
            // Check all inventory values
            check_add_part_inventory();
        }

        public void check_add_part_inventory()
        {

            // Check if max is less than min or min is more than max
            if (add_part_max_numeric.Value < add_part_min_numeric.Value || add_part_min_numeric.Value > add_part_max_numeric.Value)
            {
                add_part_max_numeric.BackColor = Color.IndianRed;
                add_part_min_numeric.BackColor = Color.IndianRed;
                valid_max = false;
                valid_min = false;
            }
            else
            {
                // Check min is between 1 - 10000
                if (add_part_min_numeric.Value > 0 && add_part_min_numeric.Value <= 10000)
                {
                    add_part_min_numeric.BackColor = SystemColors.Window;
                    valid_min = true;
                }
                else
                {
                    add_part_min_numeric.BackColor = Color.IndianRed;
                    valid_min = false;
                }

                // Check max is between 1 - 10000
                if (add_part_max_numeric.Value > 0 && add_part_max_numeric.Value <= 10000)
                {
                    add_part_max_numeric.BackColor = SystemColors.Window;
                    valid_max = true;
                }
                else
                {
                    add_part_max_numeric.BackColor = Color.IndianRed;
                    valid_max = false;
                }
            }


            // Check if inventory is outside min and max
            if(add_part_inventory_numeric.Value > add_part_max_numeric.Value || add_part_inventory_numeric.Value < add_part_min_numeric.Value)
            {
                add_part_inventory_numeric.BackColor = Color.IndianRed;
                valid_inventory = false;
            }
            else
            {
                add_part_inventory_numeric.BackColor = SystemColors.Window;
                valid_inventory = true;
            }


            // Check if part can be added
            check_add_part_complete();
        }

        private void add_part_price_text_box_TextChanged(object sender, EventArgs e)
        {

            string pattern = @"^[0-9]*(\.[0-9]{2})$";

            Regex rg = new Regex(pattern);

            if(Regex.Match(add_part_price_text_box.Text, pattern).Success)
            {
                add_part_price_text_box.BackColor = SystemColors.Window;
                valid_price = true;
            }
            else
            {
                add_part_price_text_box.BackColor = Color.IndianRed;
                valid_price = false;
            }


            // Check if part can be added
            check_add_part_complete();
        }

        private void add_part_in_house_radio_button_Click(object sender, EventArgs e)
        {
            add_part_machine_or_company_label.Text = "Machine ID";
            check_machine_or_company();
        }

        private void add_part_outsourced_radio_button_Click(object sender, EventArgs e)
        {
            add_part_machine_or_company_label.Text = "Company";
            check_machine_or_company();
        }

        private void add_part_machine_or_company_text_box_TextChanged(object sender, EventArgs e)
        {
            check_machine_or_company();
        }


        public void check_machine_or_company()
        {

            // Prevent invalid color if field is empty
            if(add_part_machine_or_company_text_box.Text.Length == 0)
            {
                return;
            }


            if (add_part_in_house_radio_button.Checked)
            {
                // Numbers only regex
                string pattern = @"^\d+$";
                Regex rg = new Regex(pattern);


                // Check if input matches regex
                if (Regex.Match(add_part_machine_or_company_text_box.Text, pattern).Success)
                {
                    add_part_machine_or_company_text_box.BackColor = SystemColors.Window;
                    valid_machine_or_company = true;
                }
                else
                {
                    add_part_machine_or_company_text_box.BackColor = Color.IndianRed;
                    valid_machine_or_company = false;
                }
            }
            else if (add_part_outsourced_radio_button.Checked)
            {
                // Check if input matches regex
                if (add_part_machine_or_company_text_box.Text.Length > 0)
                {
                    add_part_machine_or_company_text_box.BackColor = SystemColors.Window;
                    valid_machine_or_company = true;
                }
                else
                {
                    add_part_machine_or_company_text_box.BackColor = Color.IndianRed;
                    valid_machine_or_company = false;
                }
            }


            // Check if part can be added
            check_add_part_complete();
        }


        public void check_add_part_complete()
        {

            // Enable save button if all inputs are valid - otherwise disable
            if (valid_name && valid_inventory && valid_price && valid_max && valid_min && valid_machine_or_company)
            {
                button_add_part_save.Enabled = true;
            }
            else
            {
                button_add_part_save.Enabled = false;
            }
        }

        private void button_add_part_save_Click(object sender, EventArgs e)
        {

            if (add_part_in_house_radio_button.Checked)
            {
                // Create in house part
                InHouse addPart = new InHouse(Convert.ToInt32(add_part_id_text_box.Text), add_part_name_text_box.Text, Convert.ToDecimal(add_part_price_text_box.Text), (int)add_part_inventory_numeric.Value, (int)add_part_min_numeric.Value, (int)add_part_max_numeric.Value, Convert.ToInt32(add_part_machine_or_company_text_box.Text));

                // Call function to add part
                Inventory.allParts.Add(addPart);
            }
            else if (add_part_outsourced_radio_button.Checked)
            {
                Outsourced addPart = new Outsourced(Convert.ToInt32(add_part_id_text_box.Text), add_part_name_text_box.Text, Convert.ToDecimal(add_part_price_text_box.Text), (int)add_part_inventory_numeric.Value, (int)add_part_min_numeric.Value, (int)add_part_max_numeric.Value, add_part_machine_or_company_text_box.Text);

                // Call function to add part
                Inventory.allParts.Add(addPart);
            }


            // Message new part name
            MessageBox.Show("Added Part: " + add_part_name_text_box.Text);


            // Return to mainScreen
            this.Visible = false;
            MainScreen newForm = new MainScreen();
            newForm.Show();

        }
    }
}
