using EF_Project.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project
{

    public static class AppManger
    {
        /************************** Forms Decleration ****************************/
        public static Entry EntryForm;
        public static WareHouse WareHouseForm;
        public static Product ProductForm;
        public static supplier SupplierForm;
        public static Customer CustomerForm;
        public static ReleaseInvoice ReleaseForm;
        public static ExchangeInvoice ExchangeForm;
        public static Reports ReportsForm;
        public static Moving MovingForm;

        /***************************** DB Entities *******************************/
        public static EFProjectEntities Entities;

        /************************** MessageBox Options ***************************/
        public static MessageBoxButtons OKButton;
        public static MessageBoxIcon ErrorIcon;
        public static MessageBoxIcon InfoIcon;
        public static MessageBoxIcon WarningIcon;

        static AppManger()
        {
            
            //DB Entities
            Entities = new EFProjectEntities();

            //MessageBox Options
            OKButton = new MessageBoxButtons();
            OKButton = MessageBoxButtons.OK;
            ErrorIcon = new MessageBoxIcon();
            ErrorIcon = MessageBoxIcon.Error;
            InfoIcon = new MessageBoxIcon();
            InfoIcon = MessageBoxIcon.Information;
            WarningIcon = new MessageBoxIcon();
            WarningIcon = MessageBoxIcon.Warning;

            //Forms
            WareHouseForm = new WareHouse();
            ProductForm = new Product();
            SupplierForm = new supplier();
            CustomerForm = new Customer();
            ReleaseForm = new ReleaseInvoice();
            ExchangeForm = new ExchangeInvoice();
            ReportsForm = new Reports();
            MovingForm = new Moving();
            EntryForm = new Entry();

        }
    }
}
