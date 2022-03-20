using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project
{
    public partial class Reports : Form
    {
        KeyValuePair<int, string> SelectedWareHouse;
        List<ItemsWareHouse_Result> I = new List<ItemsWareHouse_Result>();
        List<ItemsMovement_Result> Itemsrelease = new List<ItemsMovement_Result>();
        List<ItemsMovement1_Result> ItemsExchange = new List<ItemsMovement1_Result>();

        public Reports()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Warehouses.Items.Clear();
            WareHousecheckedListBox.Items.Clear();
            foreach (var w in AppManger.Entities.Warehouses)
            {
                Warehouses.Items.Add(new KeyValuePair<int, string>(w.W_ID, w.W_Name));
                WareHousecheckedListBox.Items.Add(w.W_Name);
                warehousecheckedListBox1.Items.Add(w.W_Name);
            }
            Warehouses.ValueMember = "Key";
            Warehouses.DisplayMember = "value";

            IntervalcomboBox1.Items.Add("year");
            IntervalcomboBox1.Items.Add("month");
            IntervalcomboBox1.Items.Add("Day");

        }
        #region Warehouse tab
        private void Warehouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedWareHouse = (KeyValuePair<int, string>)Warehouses.SelectedItem;
        }
        private void Show_Click(object sender, EventArgs e)
        {
            SelectWareHouse_ResultBindingSource.DataSource = AppManger.Entities.SelectWareHouse(SelectedWareHouse.Key).ToList();
            ReportParameter[] param = new ReportParameter[]
            {
                    new ReportParameter("WareHouseName",SelectedWareHouse.Value.ToString())
            };
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();

        }
        #endregion
        #region ItemsTab
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection SelectedWarehouses = WareHousecheckedListBox.CheckedItems;
            foreach (var n in SelectedWarehouses)
            {
                var it = (from w in AppManger.Entities.Warehouses
                          where w.W_Name == n.ToString()
                          select w).First();

                I.AddRange(AppManger.Entities.ItemsWareHouse(it.W_ID).ToList());
            }

            ItemsWareHouse_ResultBindingSource.DataSource = I.ToList();
            this.reportViewer2.RefreshReport();
            I.Clear();
            WareHousecheckedListBox.ClearSelected();
        }
        #endregion
        #region itemsMovement tab
        private void Showbutton1_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection SelectedWarehouses = warehousecheckedListBox1.CheckedItems;
            foreach (var n in SelectedWarehouses)
            {
                var it = (from w in AppManger.Entities.Warehouses
                          where w.W_Name == n.ToString()
                          select w).First();

                Itemsrelease.AddRange(AppManger.Entities.ItemsMovement(from.Value, to.Value,it.W_ID).ToList());
                ItemsExchange.AddRange(AppManger.Entities.ItemsMovement1(from.Value, to.Value, it.W_ID).ToList());
            }
            ItemsMovement_ResultBindingSource.DataSource = Itemsrelease.ToList();
            ItemsMovement1_ResultBindingSource.DataSource = ItemsExchange.ToList();

            this.reportViewer3.RefreshReport();
            Itemsrelease.Clear();
            ItemsExchange.Clear();

            warehousecheckedListBox1.ClearSelected();
        }
        #endregion

        #region specificItem tab
        private void Showbutton2_Click(object sender, EventArgs e)
        {

        }

        #endregion
        private void ExitWareHouse_Click(object sender, EventArgs e)
        {

            this.Close();
            AppManger.EntryForm.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AppManger.EntryForm.Show();
            this.Hide();
        }

        
    }
}
