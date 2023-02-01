namespace Inventory_Management_System
{
    partial class MainScreen
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
            this.button_main_screen_search_parts = new System.Windows.Forms.Button();
            this.textbox_main_screen_search_parts = new System.Windows.Forms.TextBox();
            this.datagrid_main_screen_parts = new System.Windows.Forms.DataGridView();
            this.datagrid_main_screen_products = new System.Windows.Forms.DataGridView();
            this.textbox_main_screen_search_products = new System.Windows.Forms.TextBox();
            this.button_main_screen_search_products = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_main_screen_add_parts = new System.Windows.Forms.Button();
            this.button_main_screen_modify_parts = new System.Windows.Forms.Button();
            this.button_main_screen_delete_parts = new System.Windows.Forms.Button();
            this.button_main_screen_delete_products = new System.Windows.Forms.Button();
            this.button_main_screen_modify_products = new System.Windows.Forms.Button();
            this.button_main_screen_add_products = new System.Windows.Forms.Button();
            this.button_main_screen_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_main_screen_parts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_main_screen_products)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parts";
            // 
            // button_main_screen_search_parts
            // 
            this.button_main_screen_search_parts.Location = new System.Drawing.Point(199, 66);
            this.button_main_screen_search_parts.Name = "button_main_screen_search_parts";
            this.button_main_screen_search_parts.Size = new System.Drawing.Size(75, 23);
            this.button_main_screen_search_parts.TabIndex = 2;
            this.button_main_screen_search_parts.Text = "Search";
            this.button_main_screen_search_parts.UseVisualStyleBackColor = true;
            this.button_main_screen_search_parts.Click += new System.EventHandler(this.button_main_screen_search_parts_Click);
            // 
            // textbox_main_screen_search_parts
            // 
            this.textbox_main_screen_search_parts.Location = new System.Drawing.Point(280, 68);
            this.textbox_main_screen_search_parts.Name = "textbox_main_screen_search_parts";
            this.textbox_main_screen_search_parts.Size = new System.Drawing.Size(190, 20);
            this.textbox_main_screen_search_parts.TabIndex = 3;
            // 
            // datagrid_main_screen_parts
            // 
            this.datagrid_main_screen_parts.AllowUserToAddRows = false;
            this.datagrid_main_screen_parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_main_screen_parts.Location = new System.Drawing.Point(16, 102);
            this.datagrid_main_screen_parts.MultiSelect = false;
            this.datagrid_main_screen_parts.Name = "datagrid_main_screen_parts";
            this.datagrid_main_screen_parts.ReadOnly = true;
            this.datagrid_main_screen_parts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_main_screen_parts.Size = new System.Drawing.Size(454, 238);
            this.datagrid_main_screen_parts.TabIndex = 4;
            this.datagrid_main_screen_parts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_main_screen_parts_CellClick);
            this.datagrid_main_screen_parts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.datagrid_main_screen_parts_DataBindingComplete);
            // 
            // datagrid_main_screen_products
            // 
            this.datagrid_main_screen_products.AllowUserToAddRows = false;
            this.datagrid_main_screen_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_main_screen_products.Location = new System.Drawing.Point(518, 102);
            this.datagrid_main_screen_products.MultiSelect = false;
            this.datagrid_main_screen_products.Name = "datagrid_main_screen_products";
            this.datagrid_main_screen_products.ReadOnly = true;
            this.datagrid_main_screen_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_main_screen_products.Size = new System.Drawing.Size(454, 238);
            this.datagrid_main_screen_products.TabIndex = 8;
            this.datagrid_main_screen_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_main_screen_products_CellClick);
            this.datagrid_main_screen_products.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.datagrid_main_screen_products_DataBindingComplete);
            // 
            // textbox_main_screen_search_products
            // 
            this.textbox_main_screen_search_products.Location = new System.Drawing.Point(782, 68);
            this.textbox_main_screen_search_products.Name = "textbox_main_screen_search_products";
            this.textbox_main_screen_search_products.Size = new System.Drawing.Size(190, 20);
            this.textbox_main_screen_search_products.TabIndex = 7;
            // 
            // button_main_screen_search_products
            // 
            this.button_main_screen_search_products.Location = new System.Drawing.Point(701, 66);
            this.button_main_screen_search_products.Name = "button_main_screen_search_products";
            this.button_main_screen_search_products.Size = new System.Drawing.Size(75, 23);
            this.button_main_screen_search_products.TabIndex = 6;
            this.button_main_screen_search_products.Text = "Search";
            this.button_main_screen_search_products.UseVisualStyleBackColor = true;
            this.button_main_screen_search_products.Click += new System.EventHandler(this.button_main_screen_search_products_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Products";
            // 
            // button_main_screen_add_parts
            // 
            this.button_main_screen_add_parts.Location = new System.Drawing.Point(233, 357);
            this.button_main_screen_add_parts.Name = "button_main_screen_add_parts";
            this.button_main_screen_add_parts.Size = new System.Drawing.Size(75, 23);
            this.button_main_screen_add_parts.TabIndex = 9;
            this.button_main_screen_add_parts.Text = "Add";
            this.button_main_screen_add_parts.UseVisualStyleBackColor = true;
            this.button_main_screen_add_parts.Click += new System.EventHandler(this.button_main_screen_add_parts_Click);
            // 
            // button_main_screen_modify_parts
            // 
            this.button_main_screen_modify_parts.Location = new System.Drawing.Point(314, 357);
            this.button_main_screen_modify_parts.Name = "button_main_screen_modify_parts";
            this.button_main_screen_modify_parts.Size = new System.Drawing.Size(75, 23);
            this.button_main_screen_modify_parts.TabIndex = 10;
            this.button_main_screen_modify_parts.Text = "Modify";
            this.button_main_screen_modify_parts.UseVisualStyleBackColor = true;
            this.button_main_screen_modify_parts.Click += new System.EventHandler(this.button_main_screen_modify_parts_Click);
            // 
            // button_main_screen_delete_parts
            // 
            this.button_main_screen_delete_parts.Location = new System.Drawing.Point(395, 357);
            this.button_main_screen_delete_parts.Name = "button_main_screen_delete_parts";
            this.button_main_screen_delete_parts.Size = new System.Drawing.Size(75, 23);
            this.button_main_screen_delete_parts.TabIndex = 11;
            this.button_main_screen_delete_parts.Text = "Delete";
            this.button_main_screen_delete_parts.UseVisualStyleBackColor = true;
            this.button_main_screen_delete_parts.Click += new System.EventHandler(this.button_main_screen_delete_parts_Click);
            // 
            // button_main_screen_delete_products
            // 
            this.button_main_screen_delete_products.Location = new System.Drawing.Point(897, 357);
            this.button_main_screen_delete_products.Name = "button_main_screen_delete_products";
            this.button_main_screen_delete_products.Size = new System.Drawing.Size(75, 23);
            this.button_main_screen_delete_products.TabIndex = 14;
            this.button_main_screen_delete_products.Text = "Delete";
            this.button_main_screen_delete_products.UseVisualStyleBackColor = true;
            this.button_main_screen_delete_products.Click += new System.EventHandler(this.button_main_screen_delete_products_Click);
            // 
            // button_main_screen_modify_products
            // 
            this.button_main_screen_modify_products.Location = new System.Drawing.Point(816, 357);
            this.button_main_screen_modify_products.Name = "button_main_screen_modify_products";
            this.button_main_screen_modify_products.Size = new System.Drawing.Size(75, 23);
            this.button_main_screen_modify_products.TabIndex = 13;
            this.button_main_screen_modify_products.Text = "Modify";
            this.button_main_screen_modify_products.UseVisualStyleBackColor = true;
            this.button_main_screen_modify_products.Click += new System.EventHandler(this.button_main_screen_modify_products_Click);
            // 
            // button_main_screen_add_products
            // 
            this.button_main_screen_add_products.Location = new System.Drawing.Point(735, 357);
            this.button_main_screen_add_products.Name = "button_main_screen_add_products";
            this.button_main_screen_add_products.Size = new System.Drawing.Size(75, 23);
            this.button_main_screen_add_products.TabIndex = 12;
            this.button_main_screen_add_products.Text = "Add";
            this.button_main_screen_add_products.UseVisualStyleBackColor = true;
            this.button_main_screen_add_products.Click += new System.EventHandler(this.button_main_screen_add_products_Click);
            // 
            // button_main_screen_exit
            // 
            this.button_main_screen_exit.Location = new System.Drawing.Point(897, 426);
            this.button_main_screen_exit.Name = "button_main_screen_exit";
            this.button_main_screen_exit.Size = new System.Drawing.Size(75, 23);
            this.button_main_screen_exit.TabIndex = 15;
            this.button_main_screen_exit.Text = "Exit";
            this.button_main_screen_exit.UseVisualStyleBackColor = true;
            this.button_main_screen_exit.Click += new System.EventHandler(this.button_main_screen_exit_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.button_main_screen_exit);
            this.Controls.Add(this.button_main_screen_delete_products);
            this.Controls.Add(this.button_main_screen_modify_products);
            this.Controls.Add(this.button_main_screen_add_products);
            this.Controls.Add(this.button_main_screen_delete_parts);
            this.Controls.Add(this.button_main_screen_modify_parts);
            this.Controls.Add(this.button_main_screen_add_parts);
            this.Controls.Add(this.datagrid_main_screen_products);
            this.Controls.Add(this.textbox_main_screen_search_products);
            this.Controls.Add(this.button_main_screen_search_products);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datagrid_main_screen_parts);
            this.Controls.Add(this.textbox_main_screen_search_parts);
            this.Controls.Add(this.button_main_screen_search_parts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_main_screen_parts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_main_screen_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_main_screen_search_parts;
        private System.Windows.Forms.TextBox textbox_main_screen_search_parts;
        private System.Windows.Forms.DataGridView datagrid_main_screen_parts;
        private System.Windows.Forms.DataGridView datagrid_main_screen_products;
        private System.Windows.Forms.TextBox textbox_main_screen_search_products;
        private System.Windows.Forms.Button button_main_screen_search_products;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_main_screen_add_parts;
        private System.Windows.Forms.Button button_main_screen_modify_parts;
        private System.Windows.Forms.Button button_main_screen_delete_parts;
        private System.Windows.Forms.Button button_main_screen_delete_products;
        private System.Windows.Forms.Button button_main_screen_modify_products;
        private System.Windows.Forms.Button button_main_screen_add_products;
        private System.Windows.Forms.Button button_main_screen_exit;
    }
}

