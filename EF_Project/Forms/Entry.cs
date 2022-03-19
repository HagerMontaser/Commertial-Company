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
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
            
        }

        private void WareHouse_Click(object sender, EventArgs e)
        {
            AppManger.WareHouseForm.Show();
            AppManger.EntryForm.Hide();
        }
        private void Item_Click(object sender, EventArgs e)
        {
            AppManger.ProductForm.Show();
            AppManger.EntryForm.Hide();
        }
        private void Supplier_Click(object sender, EventArgs e)
        {
            AppManger.SupplierForm.Show();
            AppManger.EntryForm.Hide();
        }
        private void Customer_Click(object sender, EventArgs e)
        {
            AppManger.CustomerForm.Show();
            AppManger.EntryForm.Hide();
        }
        private void Realease_Click(object sender, EventArgs e)
        {
            AppManger.ReleaseForm.Show();
            AppManger.EntryForm.Hide();
        }
        private void Exchange_Click(object sender, EventArgs e)
        {
            AppManger.ExchangeForm.Show();
            AppManger.EntryForm.Hide();
        }
        private void Reports_Click(object sender, EventArgs e)
        {
            AppManger.ReportsForm.Show();
            AppManger.EntryForm.Hide();
        }

        private void Moving_Click(object sender, EventArgs e)
        {
            AppManger.MovingForm.Show();
            AppManger.EntryForm.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
