
namespace EF_Project.Forms
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ExitWareHouse = new System.Windows.Forms.PictureBox();
            this.CustomerData = new System.Windows.Forms.GroupBox();
            this.Faxlabel1 = new System.Windows.Forms.Label();
            this.CustomerFax = new System.Windows.Forms.TextBox();
            this.Websitelabel1 = new System.Windows.Forms.Label();
            this.CustomerWebsite = new System.Windows.Forms.TextBox();
            this.Phonelabel1 = new System.Windows.Forms.Label();
            this.SupplierMobilelabel2 = new System.Windows.Forms.Label();
            this.Customerphone = new System.Windows.Forms.TextBox();
            this.Customermobile = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.PictureBox();
            this.SupplierEmailLabel = new System.Windows.Forms.Label();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.CustomerEmail = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.W_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_Responsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitWareHouse)).BeginInit();
            this.CustomerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitWareHouse
            // 
            this.ExitWareHouse.Image = ((System.Drawing.Image)(resources.GetObject("ExitWareHouse.Image")));
            this.ExitWareHouse.Location = new System.Drawing.Point(828, 10);
            this.ExitWareHouse.Name = "ExitWareHouse";
            this.ExitWareHouse.Size = new System.Drawing.Size(86, 81);
            this.ExitWareHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitWareHouse.TabIndex = 12;
            this.ExitWareHouse.TabStop = false;
            this.ExitWareHouse.Click += new System.EventHandler(this.ExitWareHouse_Click);
            // 
            // CustomerData
            // 
            this.CustomerData.Controls.Add(this.Faxlabel1);
            this.CustomerData.Controls.Add(this.CustomerFax);
            this.CustomerData.Controls.Add(this.Websitelabel1);
            this.CustomerData.Controls.Add(this.CustomerWebsite);
            this.CustomerData.Controls.Add(this.Phonelabel1);
            this.CustomerData.Controls.Add(this.SupplierMobilelabel2);
            this.CustomerData.Controls.Add(this.Customerphone);
            this.CustomerData.Controls.Add(this.Customermobile);
            this.CustomerData.Controls.Add(this.Edit);
            this.CustomerData.Controls.Add(this.Add);
            this.CustomerData.Controls.Add(this.SupplierEmailLabel);
            this.CustomerData.Controls.Add(this.SupplierNameLabel);
            this.CustomerData.Controls.Add(this.CustomerEmail);
            this.CustomerData.Controls.Add(this.CustomerName);
            this.CustomerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerData.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.CustomerData.Location = new System.Drawing.Point(20, 432);
            this.CustomerData.Name = "CustomerData";
            this.CustomerData.Size = new System.Drawing.Size(902, 298);
            this.CustomerData.TabIndex = 11;
            this.CustomerData.TabStop = false;
            this.CustomerData.Text = "Info";
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
            // CustomerFax
            // 
            this.CustomerFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFax.Location = new System.Drawing.Point(596, 149);
            this.CustomerFax.Multiline = true;
            this.CustomerFax.Name = "CustomerFax";
            this.CustomerFax.Size = new System.Drawing.Size(264, 40);
            this.CustomerFax.TabIndex = 14;
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
            // CustomerWebsite
            // 
            this.CustomerWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerWebsite.Location = new System.Drawing.Point(145, 149);
            this.CustomerWebsite.Multiline = true;
            this.CustomerWebsite.Name = "CustomerWebsite";
            this.CustomerWebsite.Size = new System.Drawing.Size(264, 40);
            this.CustomerWebsite.TabIndex = 12;
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
            // Customerphone
            // 
            this.Customerphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customerphone.Location = new System.Drawing.Point(596, 89);
            this.Customerphone.Multiline = true;
            this.Customerphone.Name = "Customerphone";
            this.Customerphone.Size = new System.Drawing.Size(264, 40);
            this.Customerphone.TabIndex = 9;
            // 
            // Customermobile
            // 
            this.Customermobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customermobile.Location = new System.Drawing.Point(596, 31);
            this.Customermobile.Multiline = true;
            this.Customermobile.Name = "Customermobile";
            this.Customermobile.Size = new System.Drawing.Size(264, 40);
            this.Customermobile.TabIndex = 8;
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
            // CustomerEmail
            // 
            this.CustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerEmail.Location = new System.Drawing.Point(145, 93);
            this.CustomerEmail.Multiline = true;
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(264, 40);
            this.CustomerEmail.TabIndex = 1;
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(145, 35);
            this.CustomerName.Multiline = true;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(264, 40);
            this.CustomerName.TabIndex = 0;
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.AllowUserToAddRows = false;
            this.CustomerGridView.AllowUserToDeleteRows = false;
            this.CustomerGridView.AllowUserToResizeColumns = false;
            this.CustomerGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.CustomerGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.CustomerGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.W_ID,
            this.W_Name,
            this.W_Responsible,
            this.W_Address,
            this.Mobile,
            this.Phone,
            this.Fax});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.CustomerGridView.GridColor = System.Drawing.Color.White;
            this.CustomerGridView.Location = new System.Drawing.Point(20, 113);
            this.CustomerGridView.MultiSelect = false;
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.ReadOnly = true;
            this.CustomerGridView.RowHeadersWidth = 51;
            this.CustomerGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CustomerGridView.RowTemplate.Height = 24;
            this.CustomerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGridView.Size = new System.Drawing.Size(902, 313);
            this.CustomerGridView.TabIndex = 10;
            this.CustomerGridView.SelectionChanged += new System.EventHandler(this.CustomerGridView_SelectionChanged);
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
            this.Back.Location = new System.Drawing.Point(20, 10);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(86, 81);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 13;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 740);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ExitWareHouse);
            this.Controls.Add(this.CustomerData);
            this.Controls.Add(this.CustomerGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitWareHouse)).EndInit();
            this.CustomerData.ResumeLayout(false);
            this.CustomerData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitWareHouse;
        private System.Windows.Forms.GroupBox CustomerData;
        private System.Windows.Forms.Label Faxlabel1;
        private System.Windows.Forms.TextBox CustomerFax;
        private System.Windows.Forms.Label Websitelabel1;
        private System.Windows.Forms.TextBox CustomerWebsite;
        private System.Windows.Forms.Label Phonelabel1;
        private System.Windows.Forms.Label SupplierMobilelabel2;
        private System.Windows.Forms.TextBox Customerphone;
        private System.Windows.Forms.TextBox Customermobile;
        private System.Windows.Forms.PictureBox Edit;
        private System.Windows.Forms.PictureBox Add;
        private System.Windows.Forms.Label SupplierEmailLabel;
        private System.Windows.Forms.Label SupplierNameLabel;
        private System.Windows.Forms.TextBox CustomerEmail;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_Responsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.PictureBox Back;
    }
}