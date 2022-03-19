
namespace EF_Project.Forms
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ExitWareHouse = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            this.WarehouseData = new System.Windows.Forms.GroupBox();
            this.ProdUnitcomboBox = new System.Windows.Forms.ComboBox();
            this.ProductUnitlabel = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.PictureBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WareHousecheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ProductDisplayButton = new System.Windows.Forms.Button();
            this.I_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductIDlabel1 = new System.Windows.Forms.Label();
            this.ProdCodetextBox = new System.Windows.Forms.TextBox();
            this.ProdUnittextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitWareHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.WarehouseData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitWareHouse
            // 
            this.ExitWareHouse.Image = ((System.Drawing.Image)(resources.GetObject("ExitWareHouse.Image")));
            this.ExitWareHouse.Location = new System.Drawing.Point(828, 10);
            this.ExitWareHouse.Name = "ExitWareHouse";
            this.ExitWareHouse.Size = new System.Drawing.Size(86, 81);
            this.ExitWareHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitWareHouse.TabIndex = 8;
            this.ExitWareHouse.TabStop = false;
            this.ExitWareHouse.Click += new System.EventHandler(this.ExitWareHouse_Click);
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(20, 10);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(86, 81);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 6;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // WarehouseData
            // 
            this.WarehouseData.Controls.Add(this.ProdUnittextBox);
            this.WarehouseData.Controls.Add(this.ProdCodetextBox);
            this.WarehouseData.Controls.Add(this.ProductIDlabel1);
            this.WarehouseData.Controls.Add(this.ProdUnitcomboBox);
            this.WarehouseData.Controls.Add(this.ProductUnitlabel);
            this.WarehouseData.Controls.Add(this.Edit);
            this.WarehouseData.Controls.Add(this.Add);
            this.WarehouseData.Controls.Add(this.ProductNameLabel);
            this.WarehouseData.Controls.Add(this.ProductName);
            this.WarehouseData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarehouseData.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.WarehouseData.Location = new System.Drawing.Point(17, 479);
            this.WarehouseData.Name = "WarehouseData";
            this.WarehouseData.Size = new System.Drawing.Size(911, 213);
            this.WarehouseData.TabIndex = 10;
            this.WarehouseData.TabStop = false;
            this.WarehouseData.Text = "Info";
            // 
            // ProdUnitcomboBox
            // 
            this.ProdUnitcomboBox.FormattingEnabled = true;
            this.ProdUnitcomboBox.Location = new System.Drawing.Point(221, 150);
            this.ProdUnitcomboBox.Name = "ProdUnitcomboBox";
            this.ProdUnitcomboBox.Size = new System.Drawing.Size(131, 33);
            this.ProdUnitcomboBox.TabIndex = 11;
            this.ProdUnitcomboBox.SelectedIndexChanged += new System.EventHandler(this.ProdUnitcomboBox_SelectedIndexChanged);
            // 
            // ProductUnitlabel
            // 
            this.ProductUnitlabel.AutoSize = true;
            this.ProductUnitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductUnitlabel.ForeColor = System.Drawing.Color.Black;
            this.ProductUnitlabel.Location = new System.Drawing.Point(22, 150);
            this.ProductUnitlabel.Name = "ProductUnitlabel";
            this.ProductUnitlabel.Size = new System.Drawing.Size(130, 25);
            this.ProductUnitlabel.TabIndex = 11;
            this.ProductUnitlabel.Text = "Product Unit";
            // 
            // Edit
            // 
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Location = new System.Drawing.Point(740, 41);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(86, 81);
            this.Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Edit.TabIndex = 7;
            this.Edit.TabStop = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.Location = new System.Drawing.Point(626, 41);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 81);
            this.Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add.TabIndex = 6;
            this.Add.TabStop = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductNameLabel.Location = new System.Drawing.Point(22, 97);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(148, 25);
            this.ProductNameLabel.TabIndex = 3;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(221, 94);
            this.ProductName.Multiline = true;
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(311, 40);
            this.ProductName.TabIndex = 0;
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.AllowUserToResizeColumns = false;
            this.ProductGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.ProductGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ProductGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.I_ID,
            this.I_Name,
            this.WarehouseName});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.ProductGridView.GridColor = System.Drawing.Color.White;
            this.ProductGridView.Location = new System.Drawing.Point(294, 114);
            this.ProductGridView.MultiSelect = false;
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.RowHeadersWidth = 51;
            this.ProductGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductGridView.RowTemplate.Height = 24;
            this.ProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGridView.Size = new System.Drawing.Size(637, 359);
            this.ProductGridView.TabIndex = 9;
            this.ProductGridView.SelectionChanged += new System.EventHandler(this.ProductGridView_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductDisplayButton);
            this.groupBox1.Controls.Add(this.WareHousecheckedListBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 359);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select WareHouse";
            // 
            // WareHousecheckedListBox
            // 
            this.WareHousecheckedListBox.FormattingEnabled = true;
            this.WareHousecheckedListBox.Location = new System.Drawing.Point(12, 40);
            this.WareHousecheckedListBox.Name = "WareHousecheckedListBox";
            this.WareHousecheckedListBox.Size = new System.Drawing.Size(253, 254);
            this.WareHousecheckedListBox.TabIndex = 16;
            // 
            // ProductDisplayButton
            // 
            this.ProductDisplayButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ProductDisplayButton.ForeColor = System.Drawing.Color.White;
            this.ProductDisplayButton.Location = new System.Drawing.Point(25, 305);
            this.ProductDisplayButton.Name = "ProductDisplayButton";
            this.ProductDisplayButton.Size = new System.Drawing.Size(227, 40);
            this.ProductDisplayButton.TabIndex = 17;
            this.ProductDisplayButton.Text = "OK";
            this.ProductDisplayButton.UseVisualStyleBackColor = false;
            this.ProductDisplayButton.Click += new System.EventHandler(this.ProductDisplayButton_Click);
            // 
            // I_ID
            // 
            this.I_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.I_ID.HeaderText = "Code";
            this.I_ID.MinimumWidth = 6;
            this.I_ID.Name = "I_ID";
            this.I_ID.ReadOnly = true;
            this.I_ID.Width = 102;
            // 
            // I_Name
            // 
            this.I_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.I_Name.HeaderText = "Name";
            this.I_Name.MinimumWidth = 6;
            this.I_Name.Name = "I_Name";
            this.I_Name.ReadOnly = true;
            this.I_Name.Width = 106;
            // 
            // WarehouseName
            // 
            this.WarehouseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.WarehouseName.HeaderText = "WareHouse";
            this.WarehouseName.MinimumWidth = 6;
            this.WarehouseName.Name = "WarehouseName";
            this.WarehouseName.ReadOnly = true;
            this.WarehouseName.Width = 172;
            // 
            // ProductIDlabel1
            // 
            this.ProductIDlabel1.AutoSize = true;
            this.ProductIDlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDlabel1.ForeColor = System.Drawing.Color.Black;
            this.ProductIDlabel1.Location = new System.Drawing.Point(22, 41);
            this.ProductIDlabel1.Name = "ProductIDlabel1";
            this.ProductIDlabel1.Size = new System.Drawing.Size(144, 25);
            this.ProductIDlabel1.TabIndex = 12;
            this.ProductIDlabel1.Text = "Product Code";
            // 
            // ProdCodetextBox
            // 
            this.ProdCodetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdCodetextBox.Location = new System.Drawing.Point(221, 29);
            this.ProdCodetextBox.Multiline = true;
            this.ProdCodetextBox.Name = "ProdCodetextBox";
            this.ProdCodetextBox.Size = new System.Drawing.Size(311, 40);
            this.ProdCodetextBox.TabIndex = 13;
            // 
            // ProdUnittextBox
            // 
            this.ProdUnittextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdUnittextBox.Location = new System.Drawing.Point(358, 150);
            this.ProdUnittextBox.Multiline = true;
            this.ProdUnittextBox.Name = "ProdUnittextBox";
            this.ProdUnittextBox.Size = new System.Drawing.Size(174, 33);
            this.ProdUnittextBox.TabIndex = 14;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 704);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WarehouseData);
            this.Controls.Add(this.ProductGridView);
            this.Controls.Add(this.ExitWareHouse);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitWareHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.WarehouseData.ResumeLayout(false);
            this.WarehouseData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitWareHouse;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.GroupBox WarehouseData;
        private System.Windows.Forms.PictureBox Edit;
        private System.Windows.Forms.PictureBox Add;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.Label ProductUnitlabel;
        private System.Windows.Forms.ComboBox ProdUnitcomboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox WareHousecheckedListBox;
        private System.Windows.Forms.Button ProductDisplayButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseName;
        private System.Windows.Forms.TextBox ProdUnittextBox;
        private System.Windows.Forms.TextBox ProdCodetextBox;
        private System.Windows.Forms.Label ProductIDlabel1;
    }
}