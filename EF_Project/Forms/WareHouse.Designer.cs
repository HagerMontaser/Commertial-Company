
namespace EF_Project.Forms
{
    partial class WareHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouse));
            this.WareHouseGridView = new System.Windows.Forms.DataGridView();
            this.W_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_Responsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseData = new System.Windows.Forms.GroupBox();
            this.Edit = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.PictureBox();
            this.WarreHouseResponsibleLabel = new System.Windows.Forms.Label();
            this.WareHouseAddressLabel = new System.Windows.Forms.Label();
            this.WareHouseNameLabel = new System.Windows.Forms.Label();
            this.ResponsiblePerson = new System.Windows.Forms.TextBox();
            this.WareHouseAddress = new System.Windows.Forms.TextBox();
            this.WareHouseName = new System.Windows.Forms.TextBox();
            this.ExitWareHouse = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WareHouseGridView)).BeginInit();
            this.WarehouseData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitWareHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // WareHouseGridView
            // 
            this.WareHouseGridView.AllowUserToAddRows = false;
            this.WareHouseGridView.AllowUserToDeleteRows = false;
            this.WareHouseGridView.AllowUserToResizeColumns = false;
            this.WareHouseGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.WareHouseGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.WareHouseGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WareHouseGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.WareHouseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WareHouseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.W_ID,
            this.W_Name,
            this.W_Responsible,
            this.W_Address});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WareHouseGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.WareHouseGridView.GridColor = System.Drawing.Color.White;
            this.WareHouseGridView.Location = new System.Drawing.Point(19, 115);
            this.WareHouseGridView.MultiSelect = false;
            this.WareHouseGridView.Name = "WareHouseGridView";
            this.WareHouseGridView.ReadOnly = true;
            this.WareHouseGridView.RowHeadersWidth = 51;
            this.WareHouseGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.WareHouseGridView.RowTemplate.Height = 24;
            this.WareHouseGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WareHouseGridView.Size = new System.Drawing.Size(902, 313);
            this.WareHouseGridView.TabIndex = 3;
            this.WareHouseGridView.SelectionChanged += new System.EventHandler(this.WareHouseGridView_SelectionChanged);
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
            this.W_Responsible.HeaderText = "Responsible";
            this.W_Responsible.MinimumWidth = 6;
            this.W_Responsible.Name = "W_Responsible";
            this.W_Responsible.ReadOnly = true;
            this.W_Responsible.Width = 185;
            // 
            // W_Address
            // 
            this.W_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.W_Address.HeaderText = "Address";
            this.W_Address.MinimumWidth = 6;
            this.W_Address.Name = "W_Address";
            this.W_Address.ReadOnly = true;
            this.W_Address.Width = 137;
            // 
            // WarehouseData
            // 
            this.WarehouseData.Controls.Add(this.Edit);
            this.WarehouseData.Controls.Add(this.Add);
            this.WarehouseData.Controls.Add(this.WarreHouseResponsibleLabel);
            this.WarehouseData.Controls.Add(this.WareHouseAddressLabel);
            this.WarehouseData.Controls.Add(this.WareHouseNameLabel);
            this.WarehouseData.Controls.Add(this.ResponsiblePerson);
            this.WarehouseData.Controls.Add(this.WareHouseAddress);
            this.WarehouseData.Controls.Add(this.WareHouseName);
            this.WarehouseData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarehouseData.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.WarehouseData.Location = new System.Drawing.Point(19, 434);
            this.WarehouseData.Name = "WarehouseData";
            this.WarehouseData.Size = new System.Drawing.Size(902, 165);
            this.WarehouseData.TabIndex = 4;
            this.WarehouseData.TabStop = false;
            this.WarehouseData.Text = "Info";
            // 
            // Edit
            // 
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Location = new System.Drawing.Point(808, 41);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(86, 81);
            this.Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Edit.TabIndex = 7;
            this.Edit.TabStop = false;
            this.Edit.Click += new System.EventHandler(this.EditWareHouseButton_Click);
            // 
            // Add
            // 
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.Location = new System.Drawing.Point(716, 41);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 81);
            this.Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add.TabIndex = 6;
            this.Add.TabStop = false;
            this.Add.Click += new System.EventHandler(this.AddWareHouseButton_Click);
            // 
            // WarreHouseResponsibleLabel
            // 
            this.WarreHouseResponsibleLabel.AutoSize = true;
            this.WarreHouseResponsibleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarreHouseResponsibleLabel.ForeColor = System.Drawing.Color.Black;
            this.WarreHouseResponsibleLabel.Location = new System.Drawing.Point(338, 39);
            this.WarreHouseResponsibleLabel.Name = "WarreHouseResponsibleLabel";
            this.WarreHouseResponsibleLabel.Size = new System.Drawing.Size(130, 25);
            this.WarreHouseResponsibleLabel.TabIndex = 5;
            this.WarreHouseResponsibleLabel.Text = "Responsible";
            // 
            // WareHouseAddressLabel
            // 
            this.WareHouseAddressLabel.AutoSize = true;
            this.WareHouseAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WareHouseAddressLabel.ForeColor = System.Drawing.Color.Black;
            this.WareHouseAddressLabel.Location = new System.Drawing.Point(19, 97);
            this.WareHouseAddressLabel.Name = "WareHouseAddressLabel";
            this.WareHouseAddressLabel.Size = new System.Drawing.Size(92, 25);
            this.WareHouseAddressLabel.TabIndex = 4;
            this.WareHouseAddressLabel.Text = "Address";
            // 
            // WareHouseNameLabel
            // 
            this.WareHouseNameLabel.AutoSize = true;
            this.WareHouseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WareHouseNameLabel.ForeColor = System.Drawing.Color.Black;
            this.WareHouseNameLabel.Location = new System.Drawing.Point(19, 39);
            this.WareHouseNameLabel.Name = "WareHouseNameLabel";
            this.WareHouseNameLabel.Size = new System.Drawing.Size(68, 25);
            this.WareHouseNameLabel.TabIndex = 3;
            this.WareHouseNameLabel.Text = "Name";
            // 
            // ResponsiblePerson
            // 
            this.ResponsiblePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponsiblePerson.Location = new System.Drawing.Point(487, 33);
            this.ResponsiblePerson.Multiline = true;
            this.ResponsiblePerson.Name = "ResponsiblePerson";
            this.ResponsiblePerson.Size = new System.Drawing.Size(196, 40);
            this.ResponsiblePerson.TabIndex = 2;
            // 
            // WareHouseAddress
            // 
            this.WareHouseAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WareHouseAddress.Location = new System.Drawing.Point(126, 91);
            this.WareHouseAddress.Multiline = true;
            this.WareHouseAddress.Name = "WareHouseAddress";
            this.WareHouseAddress.Size = new System.Drawing.Size(557, 40);
            this.WareHouseAddress.TabIndex = 1;
            // 
            // WareHouseName
            // 
            this.WareHouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WareHouseName.Location = new System.Drawing.Point(126, 33);
            this.WareHouseName.Multiline = true;
            this.WareHouseName.Name = "WareHouseName";
            this.WareHouseName.Size = new System.Drawing.Size(196, 40);
            this.WareHouseName.TabIndex = 0;
            // 
            // ExitWareHouse
            // 
            this.ExitWareHouse.Image = ((System.Drawing.Image)(resources.GetObject("ExitWareHouse.Image")));
            this.ExitWareHouse.Location = new System.Drawing.Point(827, 12);
            this.ExitWareHouse.Name = "ExitWareHouse";
            this.ExitWareHouse.Size = new System.Drawing.Size(86, 81);
            this.ExitWareHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitWareHouse.TabIndex = 5;
            this.ExitWareHouse.TabStop = false;
            this.ExitWareHouse.Click += new System.EventHandler(this.ExitWareHouse_Click);
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(19, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(86, 81);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 0;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // WareHouse
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 619);
            this.Controls.Add(this.ExitWareHouse);
            this.Controls.Add(this.WarehouseData);
            this.Controls.Add(this.WareHouseGridView);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WareHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WareHouse";
            this.Load += new System.EventHandler(this.WareHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WareHouseGridView)).EndInit();
            this.WarehouseData.ResumeLayout(false);
            this.WarehouseData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitWareHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView WareHouseGridView;
        private System.Windows.Forms.GroupBox WarehouseData;
        private System.Windows.Forms.Label WarreHouseResponsibleLabel;
        private System.Windows.Forms.Label WareHouseAddressLabel;
        private System.Windows.Forms.Label WareHouseNameLabel;
        private System.Windows.Forms.TextBox ResponsiblePerson;
        private System.Windows.Forms.TextBox WareHouseAddress;
        private System.Windows.Forms.TextBox WareHouseName;
        private System.Windows.Forms.PictureBox Edit;
        private System.Windows.Forms.PictureBox Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_Responsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_Address;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.PictureBox ExitWareHouse;
    }
}