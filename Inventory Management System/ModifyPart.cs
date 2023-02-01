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

    public partial class ModifyPart : Form
    {

        // Intialize valid variables to false
        private bool valid_name = false;
        private bool valid_inventory = false;
        private bool valid_price = false;
        private bool valid_max = false;
        private bool valid_min = false;
        private bool valid_machine_or_company = false;


        public ModifyPart()
        {
            InitializeComponent();


            // Load selected part
            modify_part_id_text_box.Text = Inventory.allParts[MainScreen.selected_part_index].PartID.ToString();
            modify_part_name_text_box.Text = Inventory.allParts[MainScreen.selected_part_index].Name;
            modify_part_inventory_numeric.Value = Inventory.allParts[MainScreen.selected_part_index].InStock;
            modify_part_price_text_box.Text = Inventory.allParts[MainScreen.selected_part_index].Price.ToString();
            modify_part_max_numeric.Value = Inventory.allParts[MainScreen.selected_part_index].Max;
            modify_part_min_numeric.Value = Inventory.allParts[MainScreen.selected_part_index].Min;


            if(Inventory.allParts[MainScreen.selected_part_index].GetType().Name.ToString() == "InHouse")
            {
                modify_part_in_house_radio_button.Checked = true;
                modify_part_outsourced_radio_button.Checked = false;
                modify_part_machine_or_company_label.Text = "Machine ID";

            }
            else if(Inventory.allParts[MainScreen.selected_part_index].GetType().Name.ToString() == "Outsourced")
            {
                modify_part_in_house_radio_button.Checked = false;
                modify_part_outsourced_radio_button.Checked = true;
                modify_part_machine_or_company_label.Text = "Company Name";
            }

            modify_part_machine_or_company_text_box.Text = Inventory.allParts[MainScreen.selected_part_index].ToString();


            modify_part_id_text_box.Enabled = false;
        }

        private void button_modify_part_cancel_Click(object sender, EventArgs e)
        {
            // Hide main screen and display new form
            this.Visible = false;
            MainScreen newForm = new MainScreen();
            newForm.Show();
        }

        private void modify_part_name_text_box_TextChanged(object sender, EventArgs e)
        {
            if(modify_part_name_text_box.Text.Length > 0)
            {
                modify_part_name_text_box.BackColor = SystemColors.Window;
                valid_name = true;
            }
            else
            {
                modify_part_name_text_box.BackColor = Color.IndianRed;
                valid_name = false;
            }


            // Check if part can be added
            check_modify_part_complete();
        }

        private void modify_part_inventory_numeric_ValueChanged(object sender, EventArgs e)
        {
            // Check all inventory values
            check_modify_part_inventory();
        }

        private void modify_part_max_numeric_ValueChanged(object sender, EventArgs e)
        {
            // Check all inventory values
            check_modify_part_inventory();
        }

        private void modify_part_min_numeric_ValueChanged(object sender, EventArgs e)
        {
            // Check all inventory values
            check_modify_part_inventory();
        }

        public void check_modify_part_inventory()
        {

            // Check if max is less than min or min is more than max
            if (modify_part_max_numeric.Value < modify_part_min_numeric.Value || modify_part_min_numeric.Value > modify_part_max_numeric.Value)
            {
                modify_part_max_numeric.BackColor = Color.IndianRed;
                modify_part_min_numeric.BackColor = Color.IndianRed;
                valid_max = false;
                valid_min = false;
            }
            else
            {
                // Check min is between 1 - 10000
                if (modify_part_min_numeric.Value > 0 && modify_part_min_numeric.Value <= 10000)
                {
                    modify_part_min_numeric.BackColor = SystemColors.Window;
                    valid_min = true;
                }
                else
                {
                    modify_part_min_numeric.BackColor = Color.IndianRed;
                    valid_min = false;
                }

                // Check max is between 1 - 10000
                if (modify_part_max_numeric.Value > 0 && modify_part_max_numeric.Value <= 10000)
                {
                    modify_part_max_numeric.BackColor = SystemColors.Window;
                    valid_max = true;
                }
                else
                {
                    modify_part_max_numeric.BackColor = Color.IndianRed;
                    valid_max = false;
                }
            }


            // Check if inventory is outside min and max
            if(modify_part_inventory_numeric.Value > modify_part_max_numeric.Value || modify_part_inventory_numeric.Value < modify_part_min_numeric.Value)
            {
                modify_part_inventory_numeric.BackColor = Color.IndianRed;
                valid_inventory = false;
            }
            else
            {
                modify_part_inventory_numeric.BackColor = SystemColors.Window;
                valid_inventory = true;
            }


            // Check if part can be added
            check_modify_part_complete();

        }

        private void modify_part_price_text_box_TextChanged(object sender, EventArgs e)
        {

            string pattern = @"^[0-9]*(\.[0-9]{2})$";

            Regex rg = new Regex(pattern);

            if(Regex.Match(modify_part_price_text_box.Text, pattern).Success)
            {
                modify_part_price_text_box.BackColor = SystemColors.Window;
                valid_price = true;
            }
            else
            {
                modify_part_price_text_box.BackColor = Color.IndianRed;
                valid_price = false;
            }


            // Check if part can be added
            check_modify_part_complete();
        }

        private void modify_part_in_house_radio_button_Click(object sender, EventArgs e)
        {
            modify_part_machine_or_company_label.Text = "Machine ID";
            check_machine_or_company();
        }

        private void modify_part_outsourced_radio_button_Click(object sender, EventArgs e)
        {
            modify_part_machine_or_company_label.Text = "Company ID";
            check_machine_or_company();
        }

        private void modify_part_machine_or_company_text_box_TextChanged(object sender, EventArgs e)
        {
            check_machine_or_company();
        }


        public void check_machine_or_company()
        {

            // Prevent invalid color if field is empty
            if(modify_part_machine_or_company_text_box.Text.Length == 0)
            {
                return;
            }


            if (modify_part_in_house_radio_button.Checked)
            {
                // Numbers only regex
                string pattern = @"^\d+$";
                Regex rg = new Regex(pattern);


                // Check if input matches regex
                if (Regex.Match(modify_part_machine_or_company_text_box.Text, pattern).Success)
                {
                    modify_part_machine_or_company_text_box.BackColor = SystemColors.Window;
                    valid_machine_or_company = true;
                }
                else
                {
                    modify_part_machine_or_company_text_box.BackColor = Color.IndianRed;
                    valid_machine_or_company = false;
                }
            }
            else if (modify_part_outsourced_radio_button.Checked)
            {
                // Check if input matches regex
                if (modify_part_machine_or_company_text_box.Text.Length > 0)
                {
                    modify_part_machine_or_company_text_box.BackColor = SystemColors.Window;
                    valid_machine_or_company = true;
                }
                else
                {
                    modify_part_machine_or_company_text_box.BackColor = Color.IndianRed;
                    valid_machine_or_company = false;
                }
            }


            // Check if part can be added
            check_modify_part_complete();
        }


        public void check_modify_part_complete()
        {

            // Enable save button if all inputs are valid - otherwise disable
            if (valid_name && valid_inventory && valid_price && valid_max && valid_min && valid_machine_or_company)
            {
                button_modify_part_save.Enabled = true;
            }
            else
            {
                button_modify_part_save.Enabled = false;
            }
        }

        private void button_modify_part_save_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(modify_part_id_text_box.Text);
            int index = -1;

            for (int i = 0; i < Inventory.allParts.Count; i++)
            {
                if(Inventory.allParts[i].PartID == id)
                {
                    index = i;
                    break;
                }
            }


            if (modify_part_in_house_radio_button.Checked)
            {
                // Attempt to modify part
                InHouse modPart = new InHouse(Convert.ToInt32(modify_part_id_text_box.Text), modify_part_name_text_box.Text, Convert.ToDecimal(modify_part_price_text_box.Text), (int)modify_part_inventory_numeric.Value, (int)modify_part_min_numeric.Value, (int)modify_part_max_numeric.Value, Convert.ToInt32(modify_part_machine_or_company_text_box.Text));

                Inventory.allParts[index] = modPart;
            }
            else if (modify_part_outsourced_radio_button.Checked)
            {
                // Attempt to modify part
                Outsourced modPart = new Outsourced(Convert.ToInt32(modify_part_id_text_box.Text), modify_part_name_text_box.Text, Convert.ToDecimal(modify_part_price_text_box.Text), (int)modify_part_inventory_numeric.Value, (int)modify_part_min_numeric.Value, (int)modify_part_max_numeric.Value, modify_part_machine_or_company_text_box.Text);

                Inventory.allParts[index] = modPart;
            }


            MessageBox.Show("Part Updated");


            // Display main screen
            this.Visible = false;
            MainScreen newForm = new MainScreen();
            newForm.Show();

        }

    }
}
