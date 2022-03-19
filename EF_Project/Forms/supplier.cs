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
    public partial class supplier : Form
    {
        int SelectedSupplier_ID;
        public supplier()
        {
            InitializeComponent();
        }
        /**************************** Fill Suppliers in grid view *****************************/
        public void FillSupplierGrid()
        {
            SupplierGridView.Rows.Clear();
            foreach (Supplier s in AppManger.Entities.Suppliers)
            {
                SupplierGridView.Rows.Add(s.S_ID,s.S_Name,s.S_Email,s.S_Website,s.S_Mobile,s.S_Phone,s.S_Fax);
            }
            SupplierName.Text = supplierEmail.Text = SupplierWebsite.Text = suppliermobile.Text = Supplierphone.Text = SupplierFax.Text = string.Empty;
            this.SupplierGridView.ClearSelection();
        }
        /******************************************************************************************/
        /***************** Fill TextBoxes with info of selected row in gridview ******************/
        private void SupplierGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in SupplierGridView.SelectedRows)
            {
                SelectedSupplier_ID = (int)drow.Cells[0].Value;
                SupplierName.Text  = drow.Cells[1].Value.ToString(); 
                supplierEmail.Text = drow.Cells[2].Value.ToString(); 
                SupplierWebsite.Text = drow.Cells[3].Value.ToString(); 
                suppliermobile.Text = drow.Cells[4].Value.ToString(); 
                Supplierphone.Text = drow.Cells[5].Value.ToString(); 
                SupplierFax.Text = drow.Cells[6].Value.ToString();
            }
        }
        /*******************************************Events********************************************/
        /************************************* Add new Supplier **************************************/
        private void Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SupplierName.Text) || String.IsNullOrWhiteSpace(supplierEmail.Text) || String.IsNullOrWhiteSpace(SupplierWebsite.Text)
             || String.IsNullOrWhiteSpace(suppliermobile.Text) || String.IsNullOrWhiteSpace(Supplierphone.Text) || String.IsNullOrWhiteSpace(SupplierFax.Text))
            {
                MessageBox.Show("Please Enter All Data", "Error", AppManger.OKButton, AppManger.ErrorIcon);
            }
            else
            {
                Supplier NewSupplier = new Supplier();
                NewSupplier.S_Name = SupplierName.Text.Trim();
                NewSupplier.S_Email = supplierEmail.Text.Trim();
                NewSupplier.S_Website = SupplierWebsite.Text.Trim();
                NewSupplier.S_Mobile = int.Parse(suppliermobile.Text.Trim());
                NewSupplier.S_Phone = int.Parse(Supplierphone.Text.Trim());
                NewSupplier.S_Fax = int.Parse(SupplierFax.Text.Trim());
                AppManger.Entities.Suppliers.Add(NewSupplier);
                AppManger.Entities.SaveChanges();
                FillSupplierGrid();
                MessageBox.Show("Supplier is added", "Done", AppManger.OKButton, AppManger.InfoIcon);
            }
        }

        /******************************************************************************************/
        /****************************** Update Supplier by Supplier ID ****************************/
        private void Edit_Click(object sender, EventArgs e)
        {
            if (SelectedSupplier_ID != 0)
            {
                Supplier OldSupplier =   (from s in AppManger.Entities.Suppliers
                                          where s.S_ID == SelectedSupplier_ID
                                          select s).First();
                if (OldSupplier != null)
                {
                    if (String.IsNullOrWhiteSpace(SupplierName.Text)  || String.IsNullOrWhiteSpace(supplierEmail.Text) || String.IsNullOrWhiteSpace(SupplierWebsite.Text) 
                     || String.IsNullOrWhiteSpace(suppliermobile.Text)|| String.IsNullOrWhiteSpace(Supplierphone.Text) || String.IsNullOrWhiteSpace(SupplierFax.Text))
                    {
                        MessageBox.Show("Please Enter All Data", "Error", AppManger.OKButton, AppManger.ErrorIcon);
                    }
                    else
                    {
                        OldSupplier.S_Name = SupplierName.Text.Trim();
                        OldSupplier.S_Email = supplierEmail.Text.Trim();
                        OldSupplier.S_Website = SupplierWebsite.Text.Trim();
                        OldSupplier.S_Mobile = int.Parse(suppliermobile.Text.Trim());
                        OldSupplier.S_Phone = int.Parse(Supplierphone.Text.Trim());
                        OldSupplier.S_Fax = int.Parse(SupplierFax.Text.Trim());
                        AppManger.Entities.SaveChanges();
                        FillSupplierGrid();
                        MessageBox.Show("Supplier is updated", "Done", AppManger.OKButton, AppManger.InfoIcon);
                    }
                }
                else
                {
                    MessageBox.Show("Supplier is not Found", "Error", AppManger.OKButton, AppManger.ErrorIcon);
                }
            }
            else
            {
                MessageBox.Show("Please Select the Supplier wanted to update", "Error", AppManger.OKButton, AppManger.ErrorIcon);
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

        private void supplier_Load(object sender, EventArgs e)
        {
            FillSupplierGrid();
        }

       
    }
}
