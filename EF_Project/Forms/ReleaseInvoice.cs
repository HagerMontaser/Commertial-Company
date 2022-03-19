using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project.Forms
{
    public partial class ReleaseInvoice : Form
    {
        KeyValuePair<int, string> SelectedWareHouse;
        KeyValuePair<int, string> SelectedSupplier;
        KeyValuePair<int, string> SelectedItem;
        CheckedListBox.CheckedItemCollection CheckedItems;
        List<int> IDs = new List<int>();
        int SelectedInvoice_ID;

        public ReleaseInvoice()
        {
            InitializeComponent();
        }
        /**************************** Fill Invoices in grid view *****************************/
        public void FillInvoiceGrid()
        {
            InvoiceGridView.Rows.Clear();
            AppManger.Entities = new EFProjectEntities();
            foreach (var I in AppManger.Entities.Release_Select())
            {
                InvoiceGridView.Rows.Add(I.R_ID,I.R_Date,I.S_Name,I.W_Name,I.I_Name,I.I_Quantity,I.I_ProdDate,I.I_Expire);
            }
            this.InvoiceGridView.ClearSelection();
            InvoiceIDtextBox.Text=quantitytextBox.Text=ExpireDurTextBox.Text =WareHousecomboBox.Text = SuppliercomboBox.Text = ItemscomboBox.Text = string.Empty;
        }
        /**************************** Fill warehouses in combobox *****************************/
        public void FillWareHouseComboBox()
        {
            WareHousecomboBox.Items.Clear();
            foreach (var w in AppManger.Entities.Warehouses)
            {
                WareHousecomboBox.Items.Add(new KeyValuePair<int, string>(w.W_ID, w.W_Name));
            }
            WareHousecomboBox.ValueMember = "Key";
            WareHousecomboBox.DisplayMember = "Value";
            WareHousecomboBox.Text = string.Empty;
        }
        private void WareHousecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedWareHouse = (KeyValuePair<int, string>)WareHousecomboBox.SelectedItem;
        }
        /**************************** Fill Suppliers in combobox *****************************/
        public void FillSupplierComboBox()
        {
            SuppliercomboBox.Items.Clear();
            foreach (var s in AppManger.Entities.Suppliers)
            {
                SuppliercomboBox.Items.Add(new KeyValuePair<int, string>(s.S_ID, s.S_Name));
            }
            SuppliercomboBox.ValueMember = "Key";
            SuppliercomboBox.DisplayMember = "Value";
            SuppliercomboBox.Text = string.Empty;
        }
        private void SuppliercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSupplier = (KeyValuePair<int, string>)SuppliercomboBox.SelectedItem;
        }
        /**************************** Fill Items in combobox *****************************/
        public void FillItemComboBox()
        {
            ItemscomboBox.Items.Clear();
            foreach (var n in CheckedItems)
            {
                var Products = from prod in AppManger.Entities.Items
                               where prod.I_Name == n.ToString()
                               select new { prod.I_ID, prod.I_Name };
                foreach (var p in Products)
                {
                    ItemscomboBox.Items.Add(new KeyValuePair<int, string>(p.I_ID, p.I_Name));
                }
            }
            ItemscomboBox.ValueMember = "Key";
            ItemscomboBox.DisplayMember = "Value";
            ItemscomboBox.Text = string.Empty;
        }
        private void ItemscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = (KeyValuePair<int, string>)ItemscomboBox.SelectedItem;

        }
        /**************************** Fill Items in Checkbox list **************************/
        public void FillItemCheckList()
        {
            ItemscheckedListBox.Items.Clear();
            foreach (var i in AppManger.Entities.Items)
            {
                ItemscheckedListBox.Items.Add(i.I_Name);
            }
            ItemscheckedListBox.Text = string.Empty;
        }
        
        /******************************************************************************************/
        /************************************ Add Invoice **********************************/
        private void ReleaseConfigButton_Click(object sender, EventArgs e)
        {
            CheckedItems = ItemscheckedListBox.CheckedItems;
            foreach (var n in CheckedItems)
            {
                var it = (from i in AppManger.Entities.Items
                          where i.I_Name == n.ToString()
                          select i).First();

                IDs.Add(it.I_ID);
            }
            FillItemComboBox();
            FillItemCheckList();
            if (String.IsNullOrWhiteSpace(InvoiceIDtextBox.Text) || SelectedWareHouse.Key == 0 || SelectedSupplier.Key == 0 || dateTimePicker1.Value == null || IDs[0] == 0)
            {
                MessageBox.Show("Please Enter All Data", "Error", AppManger.OKButton, AppManger.ErrorIcon);
            }
            else
            {
                foreach (int i in IDs)
                {
                    AppManger.Entities.Release_Insert(int.Parse(InvoiceIDtextBox.Text), i, SelectedWareHouse.Key, SelectedSupplier.Key, dateTimePicker1.Value);
                }
                MessageBox.Show("Set Items Info", "Warning", AppManger.OKButton, AppManger.WarningIcon);
                ItemscomboBox.Enabled = true;
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            AppManger.Entities = new EFProjectEntities();
            if (String.IsNullOrWhiteSpace(ItemscomboBox.Text) || String.IsNullOrWhiteSpace(InvoiceIDtextBox.Text) || String.IsNullOrWhiteSpace(quantitytextBox.Text) || String.IsNullOrWhiteSpace(ExpireDurTextBox.Text) || dateTimePicker2.Value == null)
            {
                MessageBox.Show("Please Enter All Data", "Error", AppManger.OKButton, AppManger.ErrorIcon);
            }
            else
            {
                AppManger.Entities.ReleaseInfo_Insert(int.Parse(InvoiceIDtextBox.Text), SelectedItem.Key, int.Parse(quantitytextBox.Text), dateTimePicker2.Value, int.Parse(ExpireDurTextBox.Text));
                quantitytextBox.Text = ExpireDurTextBox.Text = String.Empty;
                ItemscomboBox.Items.Remove(SelectedItem);
                if (ItemscomboBox.Items.Count == 0)
                {
                    MessageBox.Show("Release Invoice is added", "Done", AppManger.OKButton, AppManger.InfoIcon);
                    FillInvoiceGrid();
                }
                else
                {
                    MessageBox.Show("Continue the reset items info", "Warning", AppManger.OKButton, AppManger.WarningIcon);
                    FillInvoiceGrid();
                }
            }
        }
        /******************************************************************************************/
        /************************************ Edit Invoice **********************************/
        private void InvoiceGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in InvoiceGridView.SelectedRows)
            {
                SelectedInvoice_ID = (int)drow.Cells[0].Value;
                InvoiceIDtextBox.Text = drow.Cells[0].Value.ToString();
                dateTimePicker1.Text = drow.Cells[1].Value.ToString();
                SuppliercomboBox.Text = drow.Cells[2].Value.ToString();
                WareHousecomboBox.Text = drow.Cells[3].Value.ToString();
                ItemscomboBox.Text = drow.Cells[4].Value.ToString();
                quantitytextBox.Text = drow.Cells[5].Value.ToString();
                dateTimePicker2.Text = drow.Cells[6].Value.ToString();
                ExpireDurTextBox.Text = drow.Cells[7].Value.ToString();

            }
            ItemscomboBox.Enabled = false;
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedInvoice_ID != 0)
                {
                    Release OldInvoice = (from R in AppManger.Entities.Releases
                                          join I in AppManger.Entities.Items
                                          on R.I_ID equals I.I_ID
                                          where R.R_ID == SelectedInvoice_ID
                                          where I.I_Name == ItemscomboBox.Text
                                          select R).First();

                    Release_Info OldInvoiceInfo = (from R in AppManger.Entities.Release_Info
                                                   join I in AppManger.Entities.Items
                                                   on R.I_ID equals I.I_ID
                                                   where R.R_ID == SelectedInvoice_ID
                                                   where I.I_Name == ItemscomboBox.Text
                                                   select R).First();

                    if (OldInvoice != null && OldInvoiceInfo != null)
                    {
                        if (String.IsNullOrWhiteSpace(InvoiceIDtextBox.Text) || String.IsNullOrWhiteSpace(WareHousecomboBox.Text) || String.IsNullOrWhiteSpace(SuppliercomboBox.Text) || dateTimePicker1.Value == null
                            || String.IsNullOrWhiteSpace(ItemscomboBox.Text) || String.IsNullOrWhiteSpace(quantitytextBox.Text) || String.IsNullOrWhiteSpace(ExpireDurTextBox.Text)
                            || dateTimePicker2.Value == null)
                        {
                            MessageBox.Show("Please Select the needed row to edit", "Error", AppManger.OKButton, AppManger.ErrorIcon);
                        }
                        else
                        {
                            OldInvoice.R_Date = dateTimePicker1.Value;
                            OldInvoice.W_ID = (from W in AppManger.Entities.Warehouses
                                               where W.W_Name == WareHousecomboBox.Text
                                               select W).First().W_ID;
                            OldInvoice.S_ID = (from s in AppManger.Entities.Suppliers
                                               where s.S_Name == SuppliercomboBox.Text
                                               select s).First().S_ID;

                            OldInvoice.I_ID = (from i in AppManger.Entities.Items
                                               where i.I_Name == ItemscomboBox.Text
                                               select i).First().I_ID;

                            OldInvoiceInfo.I_Quantity = int.Parse(quantitytextBox.Text);
                            OldInvoiceInfo.I_ProdDate = dateTimePicker2.Value;
                            OldInvoiceInfo.I_Expire = int.Parse(ExpireDurTextBox.Text);

                            AppManger.Entities.SaveChanges();
                            MessageBox.Show("Invoice is updated", "Done", AppManger.OKButton, AppManger.InfoIcon);
                            FillInvoiceGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invoice is not Found", "Error", AppManger.OKButton, AppManger.ErrorIcon);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select the Invoice wanted to update", "Error", AppManger.OKButton, AppManger.ErrorIcon);
                }
            }
            catch
            {
                MessageBox.Show("Check the input data", "Error", AppManger.OKButton, AppManger.ErrorIcon);
            }
        }

        /******************************************************************************************/
        /************************************ Back to Entry Form **********************************/
        private void Back_Click(object sender, EventArgs e)
        {
            AppManger.EntryForm.Show();
            this.Hide();
        }
        /******************************************************************************************/
        /*************************************** Exit Entry Form **********************************/
        private void ExitWareHouse_Click(object sender, EventArgs e)
        {
            this.Close();
            AppManger.EntryForm.Close();
        }

        private void ReleaseInvoice_Load(object sender, EventArgs e)
        {
            FillInvoiceGrid();
            FillWareHouseComboBox();
            FillSupplierComboBox();
            FillItemCheckList();
            InvoiceIDtextBox.Text = string.Empty;

        }


    }
}
