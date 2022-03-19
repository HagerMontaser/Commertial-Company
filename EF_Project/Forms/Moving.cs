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
    public partial class Moving : Form
    {
        KeyValuePair<int, string> SelectedWareHouse;
        public Moving()
        {
            InitializeComponent();
        }
        public void FillFromWareHouses()
        {
            foreach(var w  in AppManger.Entities.ReleaseWareHouses())
            {
                FromcomboBox.Items.Add(new KeyValuePair<int, string>(w.W_ID,w.W_Name));
            }

            FromcomboBox.ValueMember = "Key";
            FromcomboBox.DisplayMember = "Value";
            FromcomboBox.Text = string.Empty;
        }
        private void FromcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TocomboBox1.Items.Clear();
            ItemcomboBox3.Items.Clear();
            TocomboBox1.Text = string.Empty;

            SelectedWareHouse =  (KeyValuePair<int, string>) FromcomboBox.SelectedItem;

            foreach (var w in AppManger.Entities.ReleaseWareHouses())
            {
                if(w.W_ID != SelectedWareHouse.Key)
                TocomboBox1.Items.Add(new KeyValuePair<int, string>(w.W_ID, w.W_Name));
            }

            TocomboBox1.ValueMember = "Key";
            TocomboBox1.DisplayMember = "Value";
            
            foreach (var w in AppManger.Entities.Release_Select())
            {
                if(w.W_Name == FromcomboBox.Text && !ItemcomboBox3.Items.Contains(w.I_Name) )
                {
                    ItemcomboBox3.Items.Add(w.I_Name);
                }
            }
        }
        private void ItemcomboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SuppliercomboBox4.Items.Clear();
            foreach (var s in AppManger.Entities.Release_Select())
            {
                if (s.I_Name == ItemcomboBox3.Text && !SuppliercomboBox4.Items.Contains(s.S_Name) && !ProdDatecomboBox2.Items.Contains(s.I_ProdDate) && !ExpireDurcomboBox1.Items.Contains(s.I_Expire))
                {
                    SuppliercomboBox4.Items.Add(s.S_Name);
                    ProdDatecomboBox2.Items.Add(s.I_ProdDate);
                    ExpireDurcomboBox1.Items.Add(s.I_Expire);
                }
            }
        }
        private void TransactionButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(FromcomboBox.Text) || String.IsNullOrWhiteSpace(TocomboBox1.Text) || String.IsNullOrWhiteSpace(ItemcomboBox3.Text)
                || String.IsNullOrWhiteSpace(SuppliercomboBox4.Text) || String.IsNullOrWhiteSpace(ProdDatecomboBox2.Text) || String.IsNullOrWhiteSpace(ExpireDurcomboBox1.Text) || String.IsNullOrWhiteSpace(QuantitytextBox.Text))
            {
                MessageBox.Show("Please Enter All Data", "Error", AppManger.OKButton, AppManger.ErrorIcon);
            }
            else
            {
                MessageBox.Show("Transacition is successed", "Done", AppManger.OKButton, AppManger.InfoIcon);
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

        private void Moving_Load(object sender, EventArgs e)
        {
            FillFromWareHouses();
        }
    }
}
