
namespace EF_Project.Forms
{
    partial class supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ExitWareHouse = new System.Windows.Forms.PictureBox();
            this.SupplierData = new System.Windows.Forms.GroupBox();
            this.Faxlabel1 = new System.Windows.Forms.Label();
            this.SupplierFax = new System.Windows.Forms.TextBox();
            this.Websitelabel1 = new System.Windows.Forms.Label();
            this.SupplierWebsite = new System.Windows.Forms.TextBox();
            this.Phonelabel1 = new System.Windows.Forms.Label();
            this.SupplierMobilelabel2 = new System.Windows.Forms.Label();
            this.Supplierphone = new System.Windows.Forms.TextBox();
            this.suppliermobile = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.PictureBox();
            this.SupplierEmailLabel = new System.Windows.Forms.Label();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.supplierEmail = new System.Windows.Forms.TextBox();
            this.SupplierName = new System.Windows.Forms.TextBox();
            this.SupplierGridView = new System.Windows.Forms.DataGridView();
            this.W_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_Responsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitWareHouse)).BeginInit();
            this.SupplierData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitWareHouse
            // 
            this.ExitWareHouse.Image = ((System.Drawing.Image)(resources.GetObject("ExitWareHouse.Image")));
            this.ExitWareHouse.Location = new System.Drawing.Point(828, 16);
            this.ExitWareHouse.Name = "ExitWareHouse";
            this.ExitWareHouse.Size = new System.Drawing.Size(86, 81);
            this.ExitWareHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitWareHouse.TabIndex = 9;
            this.ExitWareHouse.TabStop = false;
            this.ExitWareHouse.Click += new System.EventHandler(this.ExitWareHouse_Click);
            // 
            // SupplierData
            // 
            this.SupplierData.Controls.Add(this.Faxlabel1);
            this.SupplierData.Controls.Add(this.SupplierFax);
            this.SupplierData.Controls.Add(this.Websitelabel1);
            this.SupplierData.Controls.Add(this.SupplierWebsite);
            this.SupplierData.Controls.Add(this.Phonelabel1);
            this.SupplierData.Controls.Add(this.SupplierMobilelabel2);
            this.SupplierData.Controls.Add(this.Supplierphone);
            this.SupplierData.Controls.Add(this.suppliermobile);
            this.SupplierData.Controls.Add(this.Edit);
            this.SupplierData.Controls.Add(this.Add);
            this.SupplierData.Controls.Add(this.SupplierEmailLabel);
            this.SupplierData.Controls.Add(this.SupplierNameLabel);
            this.SupplierData.Controls.Add(this.supplierEmail);
            this.SupplierData.Controls.Add(this.SupplierName);
            this.SupplierData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierData.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.SupplierData.Location = new System.Drawing.Point(20, 438);
            this.SupplierData.Name = "SupplierData";
            this.SupplierData.Size = new System.Drawing.Size(902, 298);
            this.SupplierData.TabIndex = 8;
            this.SupplierData.TabStop = false;
            this.SupplierData.Text = "Info";
            // 
            // Faxlabel1
            // 
            this.Faxlabel1.AutoSize = true;
            this.Faxlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Faxlabel1.ForeColor = System.Drawing.Color.Black;
            this.Faxlabel1.Location = new System.Drawing.Point(489, 155);
            this.Faxlabel1.Name = "Faxlabel1";
            this.Faxlabel1.Size = new System.Drawing.Size(48, 25);
            this.Faxlabel1.TabIndex = 15;
            this.Faxlabel1.Text = "Fax";
            // 
            // SupplierFax
            // 
            this.SupplierFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierFax.Location = new System.Drawing.Point(596, 149);
            this.SupplierFax.Multiline = true;
            this.SupplierFax.Name = "SupplierFax";
            this.SupplierFax.Size = new System.Drawing.Size(264, 40);
            this.SupplierFax.TabIndex = 14;
            // 
            // Websitelabel1
            // 
            this.Websitelabel1.AutoSize = true;
            this.Websitelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Websitelabel1.ForeColor = System.Drawing.Color.Black;
            this.Websitelabel1.Location = new System.Drawing.Point(38, 155);
            this.Websitelabel1.Name = "Websitelabel1";
            this.Websitelabel1.Size = new System.Drawing.Size(91, 25);
            this.Websitelabel1.TabIndex = 13;
            this.Websitelabel1.Text = "Website";
            // 
            // SupplierWebsite
            // 
            this.SupplierWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierWebsite.Location = new System.Drawing.Point(145, 149);
            this.SupplierWebsite.Multiline = true;
            this.SupplierWebsite.Name = "SupplierWebsite";
            this.SupplierWebsite.Size = new System.Drawing.Size(264, 40);
            this.SupplierWebsite.TabIndex = 12;
            // 
            // Phonelabel1
            // 
            this.Phonelabel1.AutoSize = true;
            this.Phonelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonelabel1.ForeColor = System.Drawing.Color.Black;
            this.Phonelabel1.Location = new System.Drawing.Point(489, 95);
            this.Phonelabel1.Name = "Phonelabel1";
            this.Phonelabel1.Size = new System.Drawing.Size(74, 25);
            this.Phonelabel1.TabIndex = 11;
            this.Phonelabel1.Text = "Phone";
            // 
            // SupplierMobilelabel2
            // 
            this.SupplierMobilelabel2.AutoSize = true;
            this.SupplierMobilelabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierMobilelabel2.ForeColor = System.Drawing.Color.Black;
            this.SupplierMobilelabel2.Location = new System.Drawing.Point(489, 37);
            this.SupplierMobilelabel2.Name = "SupplierMobilelabel2";
            this.SupplierMobilelabel2.Size = new System.Drawing.Size(76, 25);
            this.SupplierMobilelabel2.TabIndex = 10;
            this.SupplierMobilelabel2.Text = "Mobile";
            // 
            // Supplierphone
            // 
            this.Supplierphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplierphone.Location = new System.Drawing.Point(596, 89);
            this.Supplierphone.Multiline = true;
            this.Supplierphone.Name = "Supplierphone";
            this.Supplierphone.Size = new System.Drawing.Size(264, 40);
            this.Supplierphone.TabIndex = 9;
            // 
            // suppliermobile
            // 
            this.suppliermobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliermobile.Location = new System.Drawing.Point(596, 31);
            this.suppliermobile.Multiline = true;
            this.suppliermobile.Name = "suppliermobile";
            this.suppliermobile.Size = new System.Drawing.Size(264, 40);
            this.suppliermobile.TabIndex = 8;
            // 
            // Edit
            // 
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Location = new System.Drawing.Point(475, 211);
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
            this.Add.Location = new System.Drawing.Point(335, 211);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 81);
            this.Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add.TabIndex = 6;
            this.Add.TabStop = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // SupplierEmailLabel
            // 
            this.SupplierEmailLabel.AutoSize = true;
            this.SupplierEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierEmailLabel.ForeColor = System.Drawing.Color.Black;
            this.SupplierEmailLabel.Location = new System.Drawing.Point(38, 99);
            this.SupplierEmailLabel.Name = "SupplierEmailLabel";
            this.SupplierEmailLabel.Size = new System.Drawing.Size(65, 25);
            this.SupplierEmailLabel.TabIndex = 4;
            this.SupplierEmailLabel.Text = "Email";
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.AutoSize = true;
            this.SupplierNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierNameLabel.ForeColor = System.Drawing.Color.Black;
            this.SupplierNameLabel.Location = new System.Drawing.Point(38, 41);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(68, 25);
            this.SupplierNameLabel.TabIndex = 3;
            this.SupplierNameLabel.Text = "Name";
            // 
            // supplierEmail
            // 
            this.supplierEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierEmail.Location = new System.Drawing.Point(145, 93);
            this.supplierEmail.Multiline = true;
            this.supplierEmail.Name = "supplierEmail";
            this.supplierEmail.Size = new System.Drawing.Size(264, 40);
            this.supplierEmail.TabIndex = 1;
            // 
            // SupplierName
            // 
            this.SupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierName.Location = new System.Drawing.Point(145, 35);
            this.SupplierName.Multiline = true;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Size = new System.Drawing.Size(264, 40);
            this.SupplierName.TabIndex = 0;
            // 
            // SupplierGridView
            // 
            this.SupplierGridView.AllowUserToAddRows = false;
            this.SupplierGridView.AllowUserToDeleteRows = false;
            this.SupplierGridView.AllowUserToResizeColumns = false;
            this.SupplierGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.SupplierGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.SupplierGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.SupplierGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.W_ID,
            this.W_Name,
            this.W_Responsible,
            this.W_Address,
            this.Mobile,
            this.Phone,
            this.Fax});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplierGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.SupplierGridView.GridColor = System.Drawing.Color.White;
            this.SupplierGridView.Location = new System.Drawing.Point(20, 119);
            this.SupplierGridView.MultiSelect = false;
            this.SupplierGridView.Name = "SupplierGridView";
            this.SupplierGridView.ReadOnly = true;
            this.SupplierGridView.RowHeadersWidth = 51;
            this.SupplierGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SupplierGridView.RowTemplate.Height = 24;
            this.SupplierGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SupplierGridView.Size = new System.Drawing.Size(902, 313);
            this.SupplierGridView.TabIndex = 7;
            this.SupplierGridView.SelectionChanged += new System.EventHandler(this.SupplierGridView_SelectionChanged);
            // 
            // W_ID
            // 
            this.W_ID.HeaderText = "ID";
            this.W_ID.MinimumWidth = 6;
            this.W_ID.Name = "W_ID";
            this.W_ID.ReadOnly = true;
            this.W_ID.Visible = false;
            this.W_ID.Width = 6;
            // 
            // W_Name
            // 
            this.W_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.W_Name.HeaderText = "Name";
            this.W_Name.MinimumWidth = 6;
            this.W_Name.Name = "W_Name";
            this.W_Name.ReadOnly = true;
            this.W_Name.Width = 106;
            // 
            // W_Responsible
            // 
            this.W_Responsible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.W_Responsible.HeaderText = "Email";
            this.W_Responsible.MinimumWidth = 6;
            this.W_Responsible.Name = "W_Responsible";
            this.W_Responsible.ReadOnly = true;
            this.W_Responsible.Width = 106;
            // 
            // W_Address
            // 
            this.W_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.W_Address.HeaderText = "WebSite";
            this.W_Address.MinimumWidth = 6;
            this.W_Address.Name = "W_Address";
            this.W_Address.ReadOnly = true;
            this.W_Address.Width = 137;
            // 
            // Mobile
            // 
            this.Mobile.HeaderText = "Mobile";
            this.Mobile.MinimumWidth = 6;
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            this.Mobile.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 125;
            // 
            // Fax
            // 
            this.Fax.HeaderText = "Fax";
            this.Fax.MinimumWidth = 6;
            this.Fax.Name = "Fax";
            this.Fax.ReadOnly = true;
            this.Fax.Width = 125;
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(20, 16);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(86, 81);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 6;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 740);
            this.Controls.Add(this.ExitWareHouse);
            this.Controls.Add(this.SupplierData);
            this.Controls.Add(this.SupplierGridView);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitWareHouse)).EndInit();
            this.SupplierData.ResumeLayout(false);
            this.SupplierData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitWareHouse;
        private System.Windows.Forms.GroupBox SupplierData;
        private System.Windows.Forms.PictureBox Edit;
        private System.Windows.Forms.PictureBox Add;
        private System.Windows.Forms.Label SupplierEmailLabel;
        private System.Windows.Forms.Label SupplierNameLabel;
        private System.Windows.Forms.TextBox supplierEmail;
        private System.Windows.Forms.TextBox SupplierName;
        private System.Windows.Forms.DataGridView SupplierGridView;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_Responsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.Label Phonelabel1;
        private System.Windows.Forms.Label SupplierMobilelabel2;
        private System.Windows.Forms.TextBox Supplierphone;
        private System.Windows.Forms.TextBox suppliermobile;
        private System.Windows.Forms.Label Faxlabel1;
        private System.Windows.Forms.TextBox SupplierFax;
        private System.Windows.Forms.Label Websitelabel1;
        private System.Windows.Forms.TextBox SupplierWebsite;
    }
}