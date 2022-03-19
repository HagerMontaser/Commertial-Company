﻿
namespace EF_Project.Forms
{
    partial class ExchangeInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeInvoice));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.InvoiceGridView = new System.Windows.Forms.DataGridView();
            this.R_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.quantitytextBox = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.PictureBox();
            this.ExitWareHouse = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ItemscomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Back = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.InvoiceIDtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReleaseConfigButton = new System.Windows.Forms.Button();
            this.ClientcomboBox = new System.Windows.Forms.ComboBox();
            this.ItemscheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductUnitlabel = new System.Windows.Forms.Label();
            this.WareHousecomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitWareHouse)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.InvoiceGridView);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox3.Location = new System.Drawing.Point(492, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(855, 367);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoices";
            // 
            // InvoiceGridView
            // 
            this.InvoiceGridView.AllowUserToAddRows = false;
            this.InvoiceGridView.AllowUserToDeleteRows = false;
            this.InvoiceGridView.AllowUserToResizeColumns = false;
            this.InvoiceGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.InvoiceGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.InvoiceGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoiceGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.InvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.R_ID,
            this.R_Date,
            this.C_Name,
            this.W_Name,
            this.I_Name,
            this.I_Quantity});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InvoiceGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.InvoiceGridView.GridColor = System.Drawing.Color.White;
            this.InvoiceGridView.Location = new System.Drawing.Point(6, 29);
            this.InvoiceGridView.MultiSelect = false;
            this.InvoiceGridView.Name = "InvoiceGridView";
            this.InvoiceGridView.ReadOnly = true;
            this.InvoiceGridView.RowHeadersWidth = 51;
            this.InvoiceGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InvoiceGridView.RowTemplate.Height = 24;
            this.InvoiceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvoiceGridView.Size = new System.Drawing.Size(843, 332);
            this.InvoiceGridView.TabIndex = 28;
            this.InvoiceGridView.SelectionChanged += new System.EventHandler(this.InvoiceGridView_SelectionChanged);
            // 
            // R_ID
            // 
            this.R_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.R_ID.HeaderText = "ID";
            this.R_ID.MinimumWidth = 6;
            this.R_ID.Name = "R_ID";
            this.R_ID.ReadOnly = true;
            this.R_ID.Width = 62;
            // 
            // R_Date
            // 
            this.R_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.R_Date.HeaderText = "Date";
            this.R_Date.MinimumWidth = 6;
            this.R_Date.Name = "R_Date";
            this.R_Date.ReadOnly = true;
            this.R_Date.Width = 86;
            // 
            // C_Name
            // 
            this.C_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.C_Name.HeaderText = "Client";
            this.C_Name.MinimumWidth = 6;
            this.C_Name.Name = "C_Name";
            this.C_Name.ReadOnly = true;
            this.C_Name.Width = 97;
            // 
            // W_Name
            // 
            this.W_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.W_Name.HeaderText = "WareHouse";
            this.W_Name.MinimumWidth = 6;
            this.W_Name.Name = "W_Name";
            this.W_Name.ReadOnly = true;
            this.W_Name.Width = 155;
            // 
            // I_Name
            // 
            this.I_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.I_Name.HeaderText = "Item";
            this.I_Name.MinimumWidth = 6;
            this.I_Name.Name = "I_Name";
            this.I_Name.ReadOnly = true;
            this.I_Name.Width = 82;
            // 
            // I_Quantity
            // 
            this.I_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.I_Quantity.HeaderText = "Quantity";
            this.I_Quantity.MinimumWidth = 6;
            this.I_Quantity.Name = "I_Quantity";
            this.I_Quantity.ReadOnly = true;
            this.I_Quantity.Width = 122;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Quantity";
            // 
            // quantitytextBox
            // 
            this.quantitytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytextBox.Location = new System.Drawing.Point(194, 117);
            this.quantitytextBox.Multiline = true;
            this.quantitytextBox.Name = "quantitytextBox";
            this.quantitytextBox.Size = new System.Drawing.Size(244, 36);
            this.quantitytextBox.TabIndex = 30;
            // 
            // Edit
            // 
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Location = new System.Drawing.Point(670, 53);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(86, 81);
            this.Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Edit.TabIndex = 33;
            this.Edit.TabStop = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.Location = new System.Drawing.Point(536, 53);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 81);
            this.Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add.TabIndex = 32;
            this.Add.TabStop = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ExitWareHouse
            // 
            this.ExitWareHouse.Image = ((System.Drawing.Image)(resources.GetObject("ExitWareHouse.Image")));
            this.ExitWareHouse.Location = new System.Drawing.Point(1261, 34);
            this.ExitWareHouse.Name = "ExitWareHouse";
            this.ExitWareHouse.Size = new System.Drawing.Size(86, 81);
            this.ExitWareHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitWareHouse.TabIndex = 28;
            this.ExitWareHouse.TabStop = false;
            this.ExitWareHouse.Click += new System.EventHandler(this.ExitWareHouse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Item";
            // 
            // ItemscomboBox
            // 
            this.ItemscomboBox.FormattingEnabled = true;
            this.ItemscomboBox.Location = new System.Drawing.Point(98, 51);
            this.ItemscomboBox.Name = "ItemscomboBox";
            this.ItemscomboBox.Size = new System.Drawing.Size(340, 33);
            this.ItemscomboBox.TabIndex = 24;
            this.ItemscomboBox.SelectedIndexChanged += new System.EventHandler(this.ItemscomboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Edit);
            this.groupBox2.Controls.Add(this.Add);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.quantitytextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ItemscomboBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(495, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 168);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items Options";
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(26, 34);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(86, 81);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 29;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 344);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 30);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 19, 15, 21, 19, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID";
            // 
            // InvoiceIDtextBox
            // 
            this.InvoiceIDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceIDtextBox.Location = new System.Drawing.Point(160, 286);
            this.InvoiceIDtextBox.Multiline = true;
            this.InvoiceIDtextBox.Name = "InvoiceIDtextBox";
            this.InvoiceIDtextBox.Size = new System.Drawing.Size(281, 36);
            this.InvoiceIDtextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date";
            // 
            // ReleaseConfigButton
            // 
            this.ReleaseConfigButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ReleaseConfigButton.ForeColor = System.Drawing.Color.White;
            this.ReleaseConfigButton.Location = new System.Drawing.Point(108, 506);
            this.ReleaseConfigButton.Name = "ReleaseConfigButton";
            this.ReleaseConfigButton.Size = new System.Drawing.Size(227, 40);
            this.ReleaseConfigButton.TabIndex = 24;
            this.ReleaseConfigButton.Text = "Continue";
            this.ReleaseConfigButton.UseVisualStyleBackColor = false;
            this.ReleaseConfigButton.Click += new System.EventHandler(this.ReleaseConfigButton_Click);
            // 
            // ClientcomboBox
            // 
            this.ClientcomboBox.FormattingEnabled = true;
            this.ClientcomboBox.Location = new System.Drawing.Point(160, 461);
            this.ClientcomboBox.Name = "ClientcomboBox";
            this.ClientcomboBox.Size = new System.Drawing.Size(278, 33);
            this.ClientcomboBox.TabIndex = 21;
            this.ClientcomboBox.SelectedIndexChanged += new System.EventHandler(this.ClientcomboBox_SelectedIndexChanged);
            // 
            // ItemscheckedListBox
            // 
            this.ItemscheckedListBox.FormattingEnabled = true;
            this.ItemscheckedListBox.Location = new System.Drawing.Point(21, 51);
            this.ItemscheckedListBox.Name = "ItemscheckedListBox";
            this.ItemscheckedListBox.Size = new System.Drawing.Size(417, 229);
            this.ItemscheckedListBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Client";
            // 
            // ProductUnitlabel
            // 
            this.ProductUnitlabel.AutoSize = true;
            this.ProductUnitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductUnitlabel.ForeColor = System.Drawing.Color.Black;
            this.ProductUnitlabel.Location = new System.Drawing.Point(16, 404);
            this.ProductUnitlabel.Name = "ProductUnitlabel";
            this.ProductUnitlabel.Size = new System.Drawing.Size(126, 25);
            this.ProductUnitlabel.TabIndex = 19;
            this.ProductUnitlabel.Text = "WareHouse";
            // 
            // WareHousecomboBox
            // 
            this.WareHousecomboBox.FormattingEnabled = true;
            this.WareHousecomboBox.Location = new System.Drawing.Point(160, 401);
            this.WareHousecomboBox.Name = "WareHousecomboBox";
            this.WareHousecomboBox.Size = new System.Drawing.Size(278, 33);
            this.WareHousecomboBox.TabIndex = 18;
            this.WareHousecomboBox.SelectedIndexChanged += new System.EventHandler(this.WareHousecomboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.InvoiceIDtextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ReleaseConfigButton);
            this.groupBox1.Controls.Add(this.ClientcomboBox);
            this.groupBox1.Controls.Add(this.ItemscheckedListBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ProductUnitlabel);
            this.groupBox1.Controls.Add(this.WareHousecomboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(26, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 556);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // ExchangeInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 720);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ExitWareHouse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExchangeInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExchangeInvoice";
            this.Load += new System.EventHandler(this.ExchangeInvoice_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitWareHouse)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView InvoiceGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_Quantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox quantitytextBox;
        private System.Windows.Forms.PictureBox Edit;
        private System.Windows.Forms.PictureBox Add;
        private System.Windows.Forms.PictureBox ExitWareHouse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ItemscomboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InvoiceIDtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ReleaseConfigButton;
        private System.Windows.Forms.ComboBox ClientcomboBox;
        private System.Windows.Forms.CheckedListBox ItemscheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductUnitlabel;
        private System.Windows.Forms.ComboBox WareHousecomboBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}