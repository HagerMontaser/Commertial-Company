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
    public partial class Customer : Form
    {
        int SelectedCustomer_ID;

        public Customer()
        {
            InitializeComponent();
        }
        /**************************** Fill Customers in grid view *****************************/
        public void FillCustomerGrid()
        {
            CustomerGridView.Rows.Clear();
            foreach (Client c in AppManger.Entities.Clients)
            {
                CustomerGridView.Rows.Add(c.C_ID, c.C_Name, c.C_Email, c.C_Website, c.C_Mobile, c.C_Phone, c.C_Fax);
            }
            CustomerName.Text = CustomerEmail.Text = CustomerWebsite.Text = Customermobile.Text = Customerphone.Text = CustomerFax.Text = string.Empty;
            this.CustomerGridView.ClearSelection();
        }
        /******************************************************************************************/
        /***************** Fill TextBoxes with info of selected row in gridview ******************/
        private void CustomerGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in CustomerGridView.SelectedRows)
            {
                SelectedCustomer_ID = (int)drow.Cells[0].Value;
                CustomerName.Text = drow.Cells[1].Value.ToString();
                CustomerEmail.Text = drow.Cells[2].Value.ToString();
                CustomerWebsite.Text = drow.Cells[3].Value.ToString();
                Customermobile.Text = drow.Cells[4].Value.ToString();
                Customerphone.Text = drow.Cells[5].Value.ToString();
                CustomerFax.Text = drow.Cells[6].Value.ToString();
            }
        }
        /*******************************************Events********************************************/
        /************************************* Add new Supplier **************************************/
        private void Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(CustomerName.Text) || String.IsNullOrWhiteSpace(CustomerEmail.Text) || String.IsNullOrWhiteSpace(CustomerWebsite.Text)
             || String.IsNullOrWhiteSpace(Customermobile.Text) || String.IsNullOrWhiteSpace(Customerphone.Text) || String.IsNullOrWhiteSpace(CustomerFax.Text))
            {
                MessageBox.Show("Please Enter All Data", "Error", AppManger.OKButton, AppManger.ErrorIcon);
            }
            else
            {
                Client NewCustomer = new Client();
                NewCustomer.C_Name = CustomerName.Text.Trim();
                NewCustomer.C_Email = CustomerEmail.Text.Trim();
                NewCustomer.C_Website = CustomerWebsite.Text.Trim();
                NewCustomer.C_Mobile = int.Parse(Customermobile.Text.Trim());
                NewCustomer.C_Phone = int.Parse(Customerphone.Text.Trim());
                NewCustomer.C_Fax = int.Parse(CustomerFax.Text.Trim());
                AppManger.Entities.Clients.Add(NewCustomer);
                AppManger.Entities.SaveChanges();
                FillCustomerGrid();
                MessageBox.Show("Client is added", "Done", AppManger.OKButton, AppManger.InfoIcon);
            }
        }

        /******************************************************************************************/
        /****************************** Update Supplier by Supplier ID ****************************/
        private void Edit_Click(object sender, EventArgs e)
        {
            if (SelectedCustomer_ID != 0)
            {
                Client OldClient = (from c in AppManger.Entities.Clients
                                        where c.C_ID == SelectedCustomer_ID
                                        select c).First();
                if (OldClient != null)
                {
                    if (String.IsNullOrWhiteSpace(CustomerName.Text) || String.IsNullOrWhiteSpace(CustomerEmail.Text) || String.IsNullOrWhiteSpace(CustomerWebsite.Text)
                    || String.IsNullOrWhiteSpace(Customermobile.Text) || String.IsNullOrWhiteSpace(Customerphone.Text) || String.IsNullOrWhiteSpace(CustomerFax.Text))
                    {
                        MessageBox.Show("Please Enter All Data", "Error", AppManger.OKButton, AppManger.ErrorIcon);
                    }
                    else
                    {
                        OldClient.C_Name = CustomerName.Text.Trim();
                        OldClient.C_Email = CustomerEmail.Text.Trim();
                        OldClient.C_Website = CustomerWebsite.Text.Trim();
                        OldClient.C_Mobile = int.Parse(Customermobile.Text.Trim());
                        OldClient.C_Phone = int.Parse(Customerphone.Text.Trim());
                        OldClient.C_Fax = int.Parse(CustomerFax.Text.Trim());
                        AppManger.Entities.SaveChanges();
                        FillCustomerGrid();
                        MessageBox.Show("Client is updated", "Done", AppManger.OKButton, AppManger.InfoIcon);
                    }
                }
                else
                {
                    MessageBox.Show("Client is not Found", "Error", AppManger.OKButton, AppManger.ErrorIcon);
                }
            }
            else
            {
                MessageBox.Show("Please Select the Client wanted to update", "Error", AppManger.OKButton, AppManger.ErrorIcon);
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

        private void Customer_Load(object sender, EventArgs e)
        {
            FillCustomerGrid();
        }
    }
}
