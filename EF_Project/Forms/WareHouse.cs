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
    public partial class WareHouse : Form
    {
        int SelectedWareHouse_ID;  //id of selected warehouse in datagrid view

        public WareHouse()
        {
            InitializeComponent();
        }


        #region WareHouse_Tab
        /**************************** Fill WareHouses in grid view *****************************/
        public void FillWareHouseGrid()
        {
            WareHouseGridView.Rows.Clear();
            foreach (Warehouse w in AppManger.Entities.Warehouses)
            {
                WareHouseGridView.Rows.Add(w.W_ID, w.W_Name, w.W_Responsible, w.W_Address);
            }
            WareHouseName.Text = WareHouseAddress.Text = ResponsiblePerson.Text = string.Empty;
            this.WareHouseGridView.ClearSelection();
        }

        /***************** Fill TextBoxes with info of selected row in gridview ******************/
        private void WareHouseGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in WareHouseGridView.SelectedRows)
            {
                SelectedWareHouse_ID = (int)drow.Cells[0].Value;
                WareHouseName.Text = drow.Cells[1].Value.ToString();
                ResponsiblePerson.Text = drow.Cells[2].Value.ToString();
                WareHouseAddress.Text = drow.Cells[3].Value.ToString();
            }
        }
        /*******************************************Events********************************************/
        /***********************************Add new WareHouse ************************************/
        private void AddWareHouseButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(WareHouseName.Text)  || String.IsNullOrWhiteSpace(WareHouseAddress.Text) || String.IsNullOrWhiteSpace(ResponsiblePerson.Text))
            {
                MessageBox.Show("Please Enter All Data", "Error", AppManger.OKButton, AppManger.ErrorIcon);
            }
            else
            {
                Warehouse NewWareHouse = new Warehouse();
                NewWareHouse.W_Name = WareHouseName.Text.Trim();
                NewWareHouse.W_Address = WareHouseAddress.Text.Trim();
                NewWareHouse.W_Responsible = ResponsiblePerson.Text.Trim();
                AppManger.Entities.Warehouses.Add(NewWareHouse);
                AppManger.Entities.SaveChanges();
                FillWareHouseGrid();
                MessageBox.Show("WareHouse is added", "Done", AppManger.OKButton, AppManger.InfoIcon);
            }

        }
        /******************************************************************************************/
        /******************************Update WareHouse by Warehouse ID****************************/
        private void EditWareHouseButton_Click(object sender, EventArgs e)
        {
            if (SelectedWareHouse_ID != 0)
            {
                Warehouse OldWareHouse = (from W in AppManger.Entities.Warehouses
                                          where W.W_ID == SelectedWareHouse_ID
                                          select W).First();
                if (OldWareHouse != null)
                {
                    if (String.IsNullOrWhiteSpace(WareHouseName.Text) || String.IsNullOrWhiteSpace(WareHouseAddress.Text) || String.IsNullOrWhiteSpace(ResponsiblePerson.Text))
                    {
                        MessageBox.Show("Please Enter All Data", "Error", AppManger.OKButton, AppManger.ErrorIcon);
                    }
                    else
                    {
                        OldWareHouse.W_Name = WareHouseName.Text.Trim();
                        OldWareHouse.W_Address = WareHouseAddress.Text.Trim();
                        OldWareHouse.W_Responsible = ResponsiblePerson.Text.Trim();
                        AppManger.Entities.SaveChanges();
                        FillWareHouseGrid();
                        MessageBox.Show("WareHouse is updated", "Done", AppManger.OKButton, AppManger.InfoIcon);
                    }
                }
                else
                {
                    MessageBox.Show("WareHouse is not Found", "Error", AppManger.OKButton, AppManger.ErrorIcon);
                }
            }
            else
            {
                MessageBox.Show("Please Select the warehouse wanted to update", "Error", AppManger.OKButton, AppManger.ErrorIcon);
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

        private void ExitWareHouse_Click(object sender, EventArgs e)
        {
            this.Close();
            AppManger.EntryForm.Close();
        }
        #endregion


        /**************************** WareHouse Load Form ****************************/
        private void WareHouse_Load(object sender, EventArgs e)
        {
            FillWareHouseGrid();
        }

        
    }
}
