
namespace EF_Project
{
    partial class Reports
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WareHouse = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Warehouses = new System.Windows.Forms.ComboBox();
            this.Show = new System.Windows.Forms.Button();
            this.Items = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.WareHousecheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ItemsMovement = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.Showbutton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.warehousecheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.SpecificItems = new System.Windows.Forms.TabPage();
            this.OldItems = new System.Windows.Forms.TabPage();
            this.ExitWareHouse = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SelectWareHouse_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsWareHouse_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsMovement_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsMovement1_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.showbutton2 = new System.Windows.Forms.Button();
            this.IntervalcomboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DurationtextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.WareHouse.SuspendLayout();
            this.Items.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ItemsMovement.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SpecificItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitWareHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectWareHouse_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsWareHouse_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsMovement_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsMovement1_ResultBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.WareHouse);
            this.tabControl1.Controls.Add(this.Items);
            this.tabControl1.Controls.Add(this.ItemsMovement);
            this.tabControl1.Controls.Add(this.SpecificItems);
            this.tabControl1.Controls.Add(this.OldItems);
            this.tabControl1.Location = new System.Drawing.Point(12, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1637, 631);
            this.tabControl1.TabIndex = 14;
            // 
            // WareHouse
            // 
            this.WareHouse.Controls.Add(this.reportViewer1);
            this.WareHouse.Controls.Add(this.label1);
            this.WareHouse.Controls.Add(this.Warehouses);
            this.WareHouse.Controls.Add(this.Show);
            this.WareHouse.Location = new System.Drawing.Point(4, 25);
            this.WareHouse.Name = "WareHouse";
            this.WareHouse.Padding = new System.Windows.Forms.Padding(3);
            this.WareHouse.Size = new System.Drawing.Size(1629, 602);
            this.WareHouse.TabIndex = 0;
            this.WareHouse.Text = "WareHouses";
            this.WareHouse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "WareHouses";
            // 
            // Warehouses
            // 
            this.Warehouses.FormattingEnabled = true;
            this.Warehouses.ItemHeight = 16;
            this.Warehouses.Location = new System.Drawing.Point(251, 22);
            this.Warehouses.Name = "Warehouses";
            this.Warehouses.Size = new System.Drawing.Size(437, 24);
            this.Warehouses.TabIndex = 3;
            this.Warehouses.SelectedIndexChanged += new System.EventHandler(this.Warehouses_SelectedIndexChanged);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(694, 13);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(126, 40);
            this.Show.TabIndex = 1;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Items
            // 
            this.Items.Controls.Add(this.reportViewer2);
            this.Items.Controls.Add(this.groupBox1);
            this.Items.Location = new System.Drawing.Point(4, 25);
            this.Items.Name = "Items";
            this.Items.Padding = new System.Windows.Forms.Padding(3);
            this.Items.Size = new System.Drawing.Size(1629, 602);
            this.Items.TabIndex = 1;
            this.Items.Text = "Items";
            this.Items.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisplayButton);
            this.groupBox1.Controls.Add(this.WareHousecheckedListBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(7, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 470);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select WareHouse";
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.DisplayButton.ForeColor = System.Drawing.Color.White;
            this.DisplayButton.Location = new System.Drawing.Point(26, 403);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(284, 55);
            this.DisplayButton.TabIndex = 17;
            this.DisplayButton.Text = "Show";
            this.DisplayButton.UseVisualStyleBackColor = false;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // WareHousecheckedListBox
            // 
            this.WareHousecheckedListBox.FormattingEnabled = true;
            this.WareHousecheckedListBox.Location = new System.Drawing.Point(12, 39);
            this.WareHousecheckedListBox.Name = "WareHousecheckedListBox";
            this.WareHousecheckedListBox.Size = new System.Drawing.Size(311, 354);
            this.WareHousecheckedListBox.TabIndex = 16;
            // 
            // ItemsMovement
            // 
            this.ItemsMovement.Controls.Add(this.reportViewer3);
            this.ItemsMovement.Controls.Add(this.groupBox2);
            this.ItemsMovement.Location = new System.Drawing.Point(4, 25);
            this.ItemsMovement.Name = "ItemsMovement";
            this.ItemsMovement.Size = new System.Drawing.Size(1629, 602);
            this.ItemsMovement.TabIndex = 2;
            this.ItemsMovement.Text = "items movement";
            this.ItemsMovement.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.to);
            this.groupBox2.Controls.Add(this.Showbutton1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.warehousecheckedListBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.from);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(24, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 516);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select WareHouse";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(17, 388);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(401, 30);
            this.to.TabIndex = 18;
            // 
            // Showbutton1
            // 
            this.Showbutton1.Location = new System.Drawing.Point(68, 436);
            this.Showbutton1.Name = "Showbutton1";
            this.Showbutton1.Size = new System.Drawing.Size(279, 58);
            this.Showbutton1.TabIndex = 5;
            this.Showbutton1.Text = "Show";
            this.Showbutton1.UseVisualStyleBackColor = true;
            this.Showbutton1.Click += new System.EventHandler(this.Showbutton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "To";
            // 
            // warehousecheckedListBox1
            // 
            this.warehousecheckedListBox1.FormattingEnabled = true;
            this.warehousecheckedListBox1.Location = new System.Drawing.Point(18, 40);
            this.warehousecheckedListBox1.Name = "warehousecheckedListBox1";
            this.warehousecheckedListBox1.Size = new System.Drawing.Size(389, 229);
            this.warehousecheckedListBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "From";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(17, 311);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(401, 30);
            this.from.TabIndex = 9;
            // 
            // SpecificItems
            // 
            this.SpecificItems.Controls.Add(this.groupBox3);
            this.SpecificItems.Location = new System.Drawing.Point(4, 25);
            this.SpecificItems.Name = "SpecificItems";
            this.SpecificItems.Size = new System.Drawing.Size(1629, 602);
            this.SpecificItems.TabIndex = 4;
            this.SpecificItems.Text = "Specific Items";
            this.SpecificItems.UseVisualStyleBackColor = true;
            // 
            // OldItems
            // 
            this.OldItems.Location = new System.Drawing.Point(4, 25);
            this.OldItems.Name = "OldItems";
            this.OldItems.Size = new System.Drawing.Size(1629, 602);
            this.OldItems.TabIndex = 3;
            this.OldItems.Text = "Old Items";
            this.OldItems.UseVisualStyleBackColor = true;
            // 
            // ExitWareHouse
            // 
            this.ExitWareHouse.Image = ((System.Drawing.Image)(resources.GetObject("ExitWareHouse.Image")));
            this.ExitWareHouse.Location = new System.Drawing.Point(1559, 12);
            this.ExitWareHouse.Name = "ExitWareHouse";
            this.ExitWareHouse.Size = new System.Drawing.Size(86, 81);
            this.ExitWareHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitWareHouse.TabIndex = 16;
            this.ExitWareHouse.TabStop = false;
            this.ExitWareHouse.Click += new System.EventHandler(this.ExitWareHouse_Click);
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(86, 81);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 15;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.SelectWareHouse_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EF_Project.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(140, 76);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1327, 454);
            this.reportViewer1.TabIndex = 5;
            // 
            // reportViewer2
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.ItemsWareHouse_ResultBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "EF_Project.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(342, 38);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1001, 486);
            this.reportViewer2.TabIndex = 17;
            // 
            // reportViewer3
            // 
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.ItemsMovement_ResultBindingSource;
            reportDataSource8.Name = "DataSet2";
            reportDataSource8.Value = this.ItemsMovement1_ResultBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "EF_Project.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(455, 31);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1158, 567);
            this.reportViewer3.TabIndex = 18;
            // 
            // SelectWareHouse_ResultBindingSource
            // 
            this.SelectWareHouse_ResultBindingSource.DataSource = typeof(EF_Project.SelectWareHouse_Result);
            // 
            // ItemsWareHouse_ResultBindingSource
            // 
            this.ItemsWareHouse_ResultBindingSource.DataSource = typeof(EF_Project.ItemsWareHouse_Result);
            // 
            // ItemsMovement_ResultBindingSource
            // 
            this.ItemsMovement_ResultBindingSource.DataSource = typeof(EF_Project.ItemsMovement_Result);
            // 
            // ItemsMovement1_ResultBindingSource
            // 
            this.ItemsMovement1_ResultBindingSource.DataSource = typeof(EF_Project.ItemsMovement1_Result);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.showbutton2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.DurationtextBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.IntervalcomboBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 218);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Period";
            // 
            // showbutton2
            // 
            this.showbutton2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.showbutton2.ForeColor = System.Drawing.Color.White;
            this.showbutton2.Location = new System.Drawing.Point(366, 64);
            this.showbutton2.Name = "showbutton2";
            this.showbutton2.Size = new System.Drawing.Size(149, 75);
            this.showbutton2.TabIndex = 17;
            this.showbutton2.Text = "Show";
            this.showbutton2.UseVisualStyleBackColor = false;
            this.showbutton2.Click += new System.EventHandler(this.Showbutton2_Click);
            // 
            // IntervalcomboBox1
            // 
            this.IntervalcomboBox1.FormattingEnabled = true;
            this.IntervalcomboBox1.Location = new System.Drawing.Point(146, 47);
            this.IntervalcomboBox1.Name = "IntervalcomboBox1";
            this.IntervalcomboBox1.Size = new System.Drawing.Size(193, 33);
            this.IntervalcomboBox1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Interval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Duration";
            // 
            // DurationtextBox1
            // 
            this.DurationtextBox1.Location = new System.Drawing.Point(146, 113);
            this.DurationtextBox1.Name = "DurationtextBox1";
            this.DurationtextBox1.Size = new System.Drawing.Size(193, 30);
            this.DurationtextBox1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(369, 30);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 754);
            this.Controls.Add(this.ExitWareHouse);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.WareHouse.ResumeLayout(false);
            this.WareHouse.PerformLayout();
            this.Items.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ItemsMovement.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SpecificItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitWareHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectWareHouse_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsWareHouse_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsMovement_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsMovement1_ResultBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage WareHouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Warehouses;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.TabPage Items;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.CheckedListBox WareHousecheckedListBox;
        private System.Windows.Forms.TabPage ItemsMovement;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.Button Showbutton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox warehousecheckedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.TabPage SpecificItems;
        private System.Windows.Forms.TabPage OldItems;
        private System.Windows.Forms.PictureBox ExitWareHouse;
        private System.Windows.Forms.PictureBox Back;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SelectWareHouse_ResultBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource ItemsWareHouse_ResultBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource ItemsMovement_ResultBindingSource;
        private System.Windows.Forms.BindingSource ItemsMovement1_ResultBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button showbutton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DurationtextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox IntervalcomboBox1;
    }
}