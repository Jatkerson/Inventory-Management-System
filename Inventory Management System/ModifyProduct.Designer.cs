namespace Inventory_Management_System
{
    partial class ModifyProduct
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
            this.modify_product_cancel_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.modify_product_name_text_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modify_product_price_text_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.modify_product_part_add_button = new System.Windows.Forms.Button();
            this.modify_product_search_text_box = new System.Windows.Forms.TextBox();
            this.modify_product_search_button = new System.Windows.Forms.Button();
            this.datagrid_modify_product_all_parts = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.datagrid_modify_product_associate_parts = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.modify_product_part_delete_button = new System.Windows.Forms.Button();
            this.modify_product_save_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.modify_product_id_text_box = new System.Windows.Forms.TextBox();
            this.modify_product_min_numeric = new System.Windows.Forms.NumericUpDown();
            this.modify_product_max_numeric = new System.Windows.Forms.NumericUpDown();
            this.modify_product_inventory_numeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_modify_product_all_parts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_modify_product_associate_parts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_product_min_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_product_max_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_product_inventory_numeric)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modify Product";
            // 
            // modify_product_cancel_button
            // 
            this.modify_product_cancel_button.Location = new System.Drawing.Point(897, 519);
            this.modify_product_cancel_button.Name = "modify_product_cancel_button";
            this.modify_product_cancel_button.Size = new System.Drawing.Size(75, 30);
            this.modify_product_cancel_button.TabIndex = 10;
            this.modify_product_cancel_button.Text = "Cancel";
            this.modify_product_cancel_button.UseVisualStyleBackColor = true;
            this.modify_product_cancel_button.Click += new System.EventHandler(this.button_add_product_cancel_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "All candidate parts";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modify_product_name_text_box
            // 
            this.modify_product_name_text_box.Location = new System.Drawing.Point(159, 203);
            this.modify_product_name_text_box.Name = "modify_product_name_text_box";
            this.modify_product_name_text_box.Size = new System.Drawing.Size(190, 20);
            this.modify_product_name_text_box.TabIndex = 15;
            this.modify_product_name_text_box.TextChanged += new System.EventHandler(this.modify_product_name_text_box_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Inventory";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modify_product_price_text_box
            // 
            this.modify_product_price_text_box.Location = new System.Drawing.Point(159, 290);
            this.modify_product_price_text_box.Name = "modify_product_price_text_box";
            this.modify_product_price_text_box.Size = new System.Drawing.Size(190, 20);
            this.modify_product_price_text_box.TabIndex = 19;
            this.modify_product_price_text_box.TextChanged += new System.EventHandler(this.modify_product_price_text_box_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Max";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(217, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Min";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modify_product_part_add_button
            // 
            this.modify_product_part_add_button.Enabled = false;
            this.modify_product_part_add_button.Location = new System.Drawing.Point(897, 247);
            this.modify_product_part_add_button.Name = "modify_product_part_add_button";
            this.modify_product_part_add_button.Size = new System.Drawing.Size(75, 30);
            this.modify_product_part_add_button.TabIndex = 9;
            this.modify_product_part_add_button.Text = "Add";
            this.modify_product_part_add_button.UseVisualStyleBackColor = true;
            this.modify_product_part_add_button.Click += new System.EventHandler(this.modify_product_part_add_button_Click);
            // 
            // modify_product_search_text_box
            // 
            this.modify_product_search_text_box.Location = new System.Drawing.Point(782, 47);
            this.modify_product_search_text_box.Name = "modify_product_search_text_box";
            this.modify_product_search_text_box.Size = new System.Drawing.Size(190, 20);
            this.modify_product_search_text_box.TabIndex = 7;
            // 
            // modify_product_search_button
            // 
            this.modify_product_search_button.Location = new System.Drawing.Point(701, 47);
            this.modify_product_search_button.Name = "modify_product_search_button";
            this.modify_product_search_button.Size = new System.Drawing.Size(75, 23);
            this.modify_product_search_button.TabIndex = 27;
            this.modify_product_search_button.Text = "Search";
            this.modify_product_search_button.UseVisualStyleBackColor = true;
            this.modify_product_search_button.Click += new System.EventHandler(this.modify_product_search_button_Click);
            // 
            // datagrid_modify_product_all_parts
            // 
            this.datagrid_modify_product_all_parts.AllowUserToAddRows = false;
            this.datagrid_modify_product_all_parts.AllowUserToDeleteRows = false;
            this.datagrid_modify_product_all_parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_modify_product_all_parts.Location = new System.Drawing.Point(516, 92);
            this.datagrid_modify_product_all_parts.MultiSelect = false;
            this.datagrid_modify_product_all_parts.Name = "datagrid_modify_product_all_parts";
            this.datagrid_modify_product_all_parts.ReadOnly = true;
            this.datagrid_modify_product_all_parts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_modify_product_all_parts.Size = new System.Drawing.Size(456, 149);
            this.datagrid_modify_product_all_parts.TabIndex = 28;
            this.datagrid_modify_product_all_parts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_modify_product_all_parts_CellClick);
            this.datagrid_modify_product_all_parts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.datagrid_modify_product_all_parts_DataBindingComplete);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // datagrid_modify_product_associate_parts
            // 
            this.datagrid_modify_product_associate_parts.AllowUserToAddRows = false;
            this.datagrid_modify_product_associate_parts.AllowUserToDeleteRows = false;
            this.datagrid_modify_product_associate_parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_modify_product_associate_parts.Location = new System.Drawing.Point(516, 294);
            this.datagrid_modify_product_associate_parts.MultiSelect = false;
            this.datagrid_modify_product_associate_parts.Name = "datagrid_modify_product_associate_parts";
            this.datagrid_modify_product_associate_parts.ReadOnly = true;
            this.datagrid_modify_product_associate_parts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_modify_product_associate_parts.Size = new System.Drawing.Size(456, 149);
            this.datagrid_modify_product_associate_parts.TabIndex = 32;
            this.datagrid_modify_product_associate_parts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_modify_product_associate_parts_CellClick);
            this.datagrid_modify_product_associate_parts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.datagrid_modify_product_associate_parts_DataBindingComplete);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(516, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Parts associated with this product";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modify_product_part_delete_button
            // 
            this.modify_product_part_delete_button.Enabled = false;
            this.modify_product_part_delete_button.Location = new System.Drawing.Point(897, 449);
            this.modify_product_part_delete_button.Name = "modify_product_part_delete_button";
            this.modify_product_part_delete_button.Size = new System.Drawing.Size(75, 30);
            this.modify_product_part_delete_button.TabIndex = 30;
            this.modify_product_part_delete_button.Text = "Delete";
            this.modify_product_part_delete_button.UseVisualStyleBackColor = true;
            this.modify_product_part_delete_button.Click += new System.EventHandler(this.modify_product_part_delete_button_Click);
            // 
            // modify_product_save_button
            // 
            this.modify_product_save_button.Location = new System.Drawing.Point(816, 519);
            this.modify_product_save_button.Name = "modify_product_save_button";
            this.modify_product_save_button.Size = new System.Drawing.Size(75, 30);
            this.modify_product_save_button.TabIndex = 33;
            this.modify_product_save_button.Text = "Save";
            this.modify_product_save_button.UseVisualStyleBackColor = true;
            this.modify_product_save_button.Click += new System.EventHandler(this.modify_product_save_button_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "ID";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modify_product_id_text_box
            // 
            this.modify_product_id_text_box.Enabled = false;
            this.modify_product_id_text_box.Location = new System.Drawing.Point(159, 163);
            this.modify_product_id_text_box.Name = "modify_product_id_text_box";
            this.modify_product_id_text_box.ReadOnly = true;
            this.modify_product_id_text_box.Size = new System.Drawing.Size(190, 20);
            this.modify_product_id_text_box.TabIndex = 34;
            // 
            // modify_product_min_numeric
            // 
            this.modify_product_min_numeric.Location = new System.Drawing.Point(269, 331);
            this.modify_product_min_numeric.Name = "modify_product_min_numeric";
            this.modify_product_min_numeric.Size = new System.Drawing.Size(80, 20);
            this.modify_product_min_numeric.TabIndex = 37;
            this.modify_product_min_numeric.ValueChanged += new System.EventHandler(this.modify_product_min_numeric_ValueChanged);
            this.modify_product_min_numeric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.modify_product_min_numeric_ValueChanged);
            // 
            // modify_product_max_numeric
            // 
            this.modify_product_max_numeric.Location = new System.Drawing.Point(114, 331);
            this.modify_product_max_numeric.Name = "modify_product_max_numeric";
            this.modify_product_max_numeric.Size = new System.Drawing.Size(80, 20);
            this.modify_product_max_numeric.TabIndex = 38;
            this.modify_product_max_numeric.ValueChanged += new System.EventHandler(this.modify_product_max_numeric_ValueChanged);
            this.modify_product_max_numeric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.modify_product_max_numeric_ValueChanged);
            // 
            // modify_product_inventory_numeric
            // 
            this.modify_product_inventory_numeric.Location = new System.Drawing.Point(159, 247);
            this.modify_product_inventory_numeric.Name = "modify_product_inventory_numeric";
            this.modify_product_inventory_numeric.Size = new System.Drawing.Size(190, 20);
            this.modify_product_inventory_numeric.TabIndex = 39;
            this.modify_product_inventory_numeric.ValueChanged += new System.EventHandler(this.modify_product_inventory_numeric_ValueChanged);
            this.modify_product_inventory_numeric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.modify_product_inventory_numeric_ValueChanged);
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.modify_product_inventory_numeric);
            this.Controls.Add(this.modify_product_max_numeric);
            this.Controls.Add(this.modify_product_min_numeric);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.modify_product_id_text_box);
            this.Controls.Add(this.modify_product_save_button);
            this.Controls.Add(this.datagrid_modify_product_associate_parts);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.modify_product_part_delete_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datagrid_modify_product_all_parts);
            this.Controls.Add(this.modify_product_search_button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.modify_product_price_text_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modify_product_name_text_box);
            this.Controls.Add(this.modify_product_cancel_button);
            this.Controls.Add(this.modify_product_part_add_button);
            this.Controls.Add(this.modify_product_search_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_modify_product_all_parts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_modify_product_associate_parts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_product_min_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_product_max_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_product_inventory_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modify_product_cancel_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modify_product_name_text_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modify_product_price_text_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button modify_product_part_add_button;
        private System.Windows.Forms.TextBox modify_product_search_text_box;
        private System.Windows.Forms.Button modify_product_search_button;
        private System.Windows.Forms.DataGridView datagrid_modify_product_all_parts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView datagrid_modify_product_associate_parts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button modify_product_part_delete_button;
        private System.Windows.Forms.Button modify_product_save_button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox modify_product_id_text_box;
        private System.Windows.Forms.NumericUpDown modify_product_min_numeric;
        private System.Windows.Forms.NumericUpDown modify_product_max_numeric;
        private System.Windows.Forms.NumericUpDown modify_product_inventory_numeric;
    }
}

