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
    public partial class Product : Form
    {
        int SelectedProduct_ID;  //id of selected product in datagrid view

        public Product()
        {
            InitializeComponent();
        }
        /************************** Fill WareHouses in combobox *****************************/
        public void FillWareHouseCoboBox()
        {
            WareHousecheckedListBox.Items.Clear();
            foreach (var w in AppManger.Entities.Warehouses)
            {
                WareHousecheckedListBox.Items.Add(w.W_Name);
            }
            
            ProductGridView.Rows.Clear();
            ProdUnitcomboBox.Items.Clear();
            ProdUnitcomboBox.Text=ProdCodetextBox.Text = ProductName.Text = ProdUnittextBox.Text = string.Empty;
        }
        /**************************** Fill Items in grid view *****************************/
        public void FillProductGridView(CheckedListBox.CheckedItemCollection SelectedWarehouses)
        {
            ProductGridView.Rows.Clear();
            foreach(var n in SelectedWarehouses)
            {
                var Products = from real in AppManger.Entities.Releases
                               join ware in AppManger.Entities.Warehouses on real.W_ID equals ware.W_ID
                               join prod in AppManger.Entities.Items on real.I_ID equals prod.I_ID
                               where ware.W_Name == n.ToString()
                           select new { prod.I_ID, prod.I_Name, ware.W_Name };
                foreach (var p in Products)
                {
                    ProductGridView.Rows.Add(p.I_ID,p.I_Name,p.W_Name);
                }
            }
            ProdUnitcomboBox.Text = ProdCodetextBox.Text = ProductName.Text = ProdUnittextBox.Text = string.Empty;
            this.ProductGridView.ClearSelection();
            ProdUnitcomboBox.Items.Clear();
        }

        /*******************************************Events********************************************/
        /***************** Fill gridview with products of selected warehouses ******************/
        private void ProductDisplayButton_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection CheckedItems = WareHousecheckedListBox.CheckedItems;
            FillProductGridView(CheckedItems);
        }
        /******************************************************************************************/
        /********************** Fill unit TextBoxe with info of selected unit *********************/
        private void ProdUnitcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdUnittextBox.Text = ProdUnitcomboBox.SelectedItem.ToString();
        }
        /******************************************************************************************/
        /***************** Fill TextBoxes with info of selected row in gridview ******************/
        private void ProductGridView_SelectionChanged(object sender, EventArgs e)
        {
            ProdUnitcomboBox.Items.Clear();
            foreach (DataGridViewRow drow in ProductGridView.SelectedRows)
            {
                SelectedProduct_ID = (int)drow.Cells[0].Value;
                ProdCodetextBox.Text = drow.Cells[0].Value.ToString();
                ProductName.Text = drow.Cells[1].Value.ToString();
            }
            var infos = (from inf in AppManger.Entities.Item_Info
                         where inf.I_ID == SelectedProduct_ID
                         select inf).ToList();

            foreach (var j in infos)
            {
                ProdUnitcomboBox.Items.Add(j.unit);
            }
        }
        /******************************************************************************************/
        /************************************* Add new Product ************************************/
        private void Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ProdCodetextBox.Text) || String.IsNullOrWhiteSpace(ProductName.Text) || String.IsNullOrWhiteSpace(ProdUnittextBox.Text))
            {
                MessageBox.Show("Please Enter All Data", "Error", AppManger.OKButton, AppManger.ErrorIcon);
            }
            else
            {
                Item NewItem = new Item();
                Item_Info NewItemInfo = new Item_Info();
                NewItemInfo.I_ID = NewItem.I_ID = int.Parse(ProdCodetextBox.Text.Trim());
                NewItem.I_Name = ProductName.Text.Trim();
                AppManger.Entities.Items.Add(NewItem);
                NewItemInfo.unit = ProdUnittextBox.Text;
                AppManger.Entities.Item_Info.Add(NewItemInfo);
                AppManger.Entities.SaveChanges();
                MessageBox.Show("Item is added", "Done", AppManger.OKButton, AppManger.InfoIcon);
                FillWareHouseCoboBox();
                
            }
        }
        /******************************************************************************************/
        /******************************Update Product by Product ID****************************/
        private void Edit_Click(object sender, EventArgs e)
        {
            if (SelectedProduct_ID != 0)
            {
                Item OldProduct =   (from p in AppManger.Entities.Items
                                     where p.I_ID == SelectedProduct_ID
                                     select p).First();

                Item_Info OldProductInfo = (from I in AppManger.Entities.Item_Info
                                            where I.I_ID == SelectedProduct_ID
                                            select I).First();

                if (OldProduct != null && OldProductInfo != null)
                {
                    if (String.IsNullOrWhiteSpace(ProdCodetextBox.Text) || String.IsNullOrWhiteSpace(ProductName.Text) || String.IsNullOrWhiteSpace(ProdUnittextBox.Text))
                    {
                        MessageBox.Show("Please Enter All Data", "Error", AppManger.OKButton, AppManger.ErrorIcon);
                    }
                    else
                    {
                        OldProduct.I_Name = ProductName.Text.Trim();
                        AppManger.Entities.SaveChanges();
                        MessageBox.Show("Product is updated", "Done", AppManger.OKButton, AppManger.InfoIcon);
                        FillWareHouseCoboBox();
                    }
                }
                else
                {
                    MessageBox.Show("Product is not Found", "Error", AppManger.OKButton, AppManger.ErrorIcon);
                }
            }
            else
            {
                MessageBox.Show("Please Select the Product wanted to update", "Error", AppManger.OKButton, AppManger.ErrorIcon);
            }
        }



        private void Back_Click(object sender, EventArgs e)
        {
            AppManger.EntryForm.Show();
            this.Hide();
        }

        private void ExitWareHouse_Click(object sender, EventArgs e)
        {
            this.Close();
            AppManger.EntryForm.Close();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            FillWareHouseCoboBox();
        }

        
    }
}
