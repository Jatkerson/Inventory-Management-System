namespace Inventory_Management_System
{
    partial class ModifyPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modify_part_id_text_box = new System.Windows.Forms.TextBox();
            this.button_modify_part_save = new System.Windows.Forms.Button();
            this.button_modify_part_cancel = new System.Windows.Forms.Button();
            this.modify_part_in_house_radio_button = new System.Windows.Forms.RadioButton();
            this.modify_part_outsourced_radio_button = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modify_part_name_text_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modify_part_price_text_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.modify_part_machine_or_company_label = new System.Windows.Forms.Label();
            this.modify_part_machine_or_company_text_box = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modify_part_inventory_numeric = new System.Windows.Forms.NumericUpDown();
            this.modify_part_max_numeric = new System.Windows.Forms.NumericUpDown();
            this.modify_part_min_numeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modify_part_inventory_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_part_max_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_part_min_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modify Part";
            // 
            // modify_part_id_text_box
            // 
            this.modify_part_id_text_box.Location = new System.Drawing.Point(179, 119);
            this.modify_part_id_text_box.Name = "modify_part_id_text_box";
            this.modify_part_id_text_box.Size = new System.Drawing.Size(190, 20);
            this.modify_part_id_text_box.TabIndex = 3;
            // 
            // button_modify_part_save
            // 
            this.button_modify_part_save.Enabled = false;
            this.button_modify_part_save.Location = new System.Drawing.Point(273, 401);
            this.button_modify_part_save.Name = "button_modify_part_save";
            this.button_modify_part_save.Size = new System.Drawing.Size(75, 30);
            this.button_modify_part_save.TabIndex = 9;
            this.button_modify_part_save.Text = "Save";
            this.button_modify_part_save.UseVisualStyleBackColor = true;
            this.button_modify_part_save.Click += new System.EventHandler(this.button_modify_part_save_Click);
            // 
            // button_modify_part_cancel
            // 
            this.button_modify_part_cancel.Location = new System.Drawing.Point(367, 401);
            this.button_modify_part_cancel.Name = "button_modify_part_cancel";
            this.button_modify_part_cancel.Size = new System.Drawing.Size(75, 30);
            this.button_modify_part_cancel.TabIndex = 10;
            this.button_modify_part_cancel.Text = "Cancel";
            this.button_modify_part_cancel.UseVisualStyleBackColor = true;
            this.button_modify_part_cancel.Click += new System.EventHandler(this.button_modify_part_cancel_Click);
            // 
            // modify_part_in_house_radio_button
            // 
            this.modify_part_in_house_radio_button.AutoSize = true;
            this.modify_part_in_house_radio_button.Location = new System.Drawing.Point(12, 19);
            this.modify_part_in_house_radio_button.Name = "modify_part_in_house_radio_button";
            this.modify_part_in_house_radio_button.Size = new System.Drawing.Size(68, 17);
            this.modify_part_in_house_radio_button.TabIndex = 1;
            this.modify_part_in_house_radio_button.Text = "In-House";
            this.modify_part_in_house_radio_button.UseVisualStyleBackColor = true;
            this.modify_part_in_house_radio_button.Click += new System.EventHandler(this.modify_part_in_house_radio_button_Click);
            // 
            // modify_part_outsourced_radio_button
            // 
            this.modify_part_outsourced_radio_button.AutoSize = true;
            this.modify_part_outsourced_radio_button.Location = new System.Drawing.Point(104, 19);
            this.modify_part_outsourced_radio_button.Name = "modify_part_outsourced_radio_button";
            this.modify_part_outsourced_radio_button.Size = new System.Drawing.Size(80, 17);
            this.modify_part_outsourced_radio_button.TabIndex = 2;
            this.modify_part_outsourced_radio_button.TabStop = true;
            this.modify_part_outsourced_radio_button.Text = "Outsourced";
            this.modify_part_outsourced_radio_button.UseVisualStyleBackColor = true;
            this.modify_part_outsourced_radio_button.Click += new System.EventHandler(this.modify_part_outsourced_radio_button_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modify_part_name_text_box
            // 
            this.modify_part_name_text_box.BackColor = System.Drawing.SystemColors.Window;
            this.modify_part_name_text_box.Location = new System.Drawing.Point(179, 164);
            this.modify_part_name_text_box.Name = "modify_part_name_text_box";
            this.modify_part_name_text_box.Size = new System.Drawing.Size(190, 20);
            this.modify_part_name_text_box.TabIndex = 4;
            this.modify_part_name_text_box.TextChanged += new System.EventHandler(this.modify_part_name_text_box_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Inventory";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Price / Cost";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modify_part_price_text_box
            // 
            this.modify_part_price_text_box.Location = new System.Drawing.Point(179, 251);
            this.modify_part_price_text_box.Name = "modify_part_price_text_box";
            this.modify_part_price_text_box.Size = new System.Drawing.Size(118, 20);
            this.modify_part_price_text_box.TabIndex = 6;
            this.modify_part_price_text_box.TextChanged += new System.EventHandler(this.modify_part_price_text_box_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Max";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(282, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Min";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modify_part_machine_or_company_label
            // 
            this.modify_part_machine_or_company_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_part_machine_or_company_label.Location = new System.Drawing.Point(23, 341);
            this.modify_part_machine_or_company_label.Name = "modify_part_machine_or_company_label";
            this.modify_part_machine_or_company_label.Size = new System.Drawing.Size(150, 20);
            this.modify_part_machine_or_company_label.TabIndex = 26;
            this.modify_part_machine_or_company_label.Text = "Machine ID";
            this.modify_part_machine_or_company_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modify_part_machine_or_company_text_box
            // 
            this.modify_part_machine_or_company_text_box.Location = new System.Drawing.Point(179, 341);
            this.modify_part_machine_or_company_text_box.Name = "modify_part_machine_or_company_text_box";
            this.modify_part_machine_or_company_text_box.Size = new System.Drawing.Size(190, 20);
            this.modify_part_machine_or_company_text_box.TabIndex = 9;
            this.modify_part_machine_or_company_text_box.TextChanged += new System.EventHandler(this.modify_part_machine_or_company_text_box_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.modify_part_outsourced_radio_button);
            this.groupBox1.Controls.Add(this.modify_part_in_house_radio_button);
            this.groupBox1.Location = new System.Drawing.Point(179, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 50);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // modify_part_inventory_numeric
            // 
            this.modify_part_inventory_numeric.Location = new System.Drawing.Point(179, 211);
            this.modify_part_inventory_numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.modify_part_inventory_numeric.Name = "modify_part_inventory_numeric";
            this.modify_part_inventory_numeric.Size = new System.Drawing.Size(118, 20);
            this.modify_part_inventory_numeric.TabIndex = 5;
            this.modify_part_inventory_numeric.ValueChanged += new System.EventHandler(this.modify_part_inventory_numeric_ValueChanged);
            this.modify_part_inventory_numeric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.modify_part_inventory_numeric_ValueChanged);
            // 
            // modify_part_max_numeric
            // 
            this.modify_part_max_numeric.Location = new System.Drawing.Point(179, 295);
            this.modify_part_max_numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.modify_part_max_numeric.Name = "modify_part_max_numeric";
            this.modify_part_max_numeric.Size = new System.Drawing.Size(80, 20);
            this.modify_part_max_numeric.TabIndex = 7;
            this.modify_part_max_numeric.ValueChanged += new System.EventHandler(this.modify_part_max_numeric_ValueChanged);
            this.modify_part_max_numeric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.modify_part_max_numeric_ValueChanged);
            // 
            // modify_part_min_numeric
            // 
            this.modify_part_min_numeric.Location = new System.Drawing.Point(334, 294);
            this.modify_part_min_numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.modify_part_min_numeric.Name = "modify_part_min_numeric";
            this.modify_part_min_numeric.Size = new System.Drawing.Size(80, 20);
            this.modify_part_min_numeric.TabIndex = 8;
            this.modify_part_min_numeric.ValueChanged += new System.EventHandler(this.modify_part_min_numeric_ValueChanged);
            this.modify_part_min_numeric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.modify_part_min_numeric_ValueChanged);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.modify_part_min_numeric);
            this.Controls.Add(this.modify_part_max_numeric);
            this.Controls.Add(this.modify_part_inventory_numeric);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modify_part_machine_or_company_label);
            this.Controls.Add(this.modify_part_machine_or_company_text_box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.modify_part_price_text_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modify_part_name_text_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_modify_part_cancel);
            this.Controls.Add(this.button_modify_part_save);
            this.Controls.Add(this.modify_part_id_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyPart";
            this.Text = "Modify Part";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modify_part_inventory_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_part_max_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_part_min_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modify_part_id_text_box;
        private System.Windows.Forms.Button button_modify_part_save;
        private System.Windows.Forms.Button button_modify_part_cancel;
        private System.Windows.Forms.RadioButton modify_part_in_house_radio_button;
        private System.Windows.Forms.RadioButton modify_part_outsourced_radio_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modify_part_name_text_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modify_part_price_text_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label modify_part_machine_or_company_label;
        private System.Windows.Forms.TextBox modify_part_machine_or_company_text_box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown modify_part_inventory_numeric;
        private System.Windows.Forms.NumericUpDown modify_part_max_numeric;
        private System.Windows.Forms.NumericUpDown modify_part_min_numeric;
    }
}

