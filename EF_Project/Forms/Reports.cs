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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
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

    }
}
