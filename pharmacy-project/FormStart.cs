using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace cs322_projekat_pharmacy
{
    public partial class form_dashboard : Form
    {
        /* get a reference to a database object */
        private PharmacyContext ctx;

        /**
         * Constructor init
         */
        public form_dashboard()
        {
            InitializeComponent();
            ctx = new PharmacyContext();
        }
        
        /**
         * Trying to log Employee into the system. Params from login panel is being sent to 
         * Employees isValid method that queries through the collection trying to find specific 
         * one.
         * 
         */
        private void login(object sender, EventArgs e)
        {

            try
            {
                /* if the Employee with specific params is find, isValid will return true */
                /* if so, display response text and redirect Employee to another panel */
                if (Employee.Instance.isValid(tb_username.Text, tb_password.Text))
                {
                    l_response.Text = "Autentifikacija...";
                    /* show/hide panels */
                    pnl_userLogin.Visible = false;
                    pnl_userInfo.Visible = true;
                    pnl_userDashboard.Visible = true;

                    /* set up Employee-specific visual elements */
                    lbl_fullname.Text = Employee.Instance.firstName + " " + Employee.Instance.lastName;
                    lbl_loggedAs.Text += Employee.Instance.userName;
                    lbl_license.Text += Employee.Instance.licenceNo;
                    lbl_date.Text += DateTime.Now.ToString("dd/mm/yyyy h:mm tt");
                }
                else
                    l_response.Text = "Greška pri autentifikaciji.";
            }
            catch (Exception mqe)
            {
                l_response.Text = "Greška pri autentifikaciji.";
            }

            /* Clear component's values */
            tb_username.Text = "";
            tb_password.Text = "";
        }

        /**
         * This method represents a frame manager. It is being invoked by the Employee on dashboard 
         * frame anytime it's require to change the display state. Regarding to name (.Text method)
         * of actual button sender the correct state/frame will be displayed.
         * 
         * Important: This method is responsible for dashboard buttons only!
         */
        private void manageFrames(object sender, EventArgs e)
        {
            /* get button sender */
            Button btn = (Button)sender;

            /* switch the name value of button sender */
            switch (btn.Text)
            {
                case "DODAJ RADNIKA":
                    FormEmployee formEmployeeAdd = new FormEmployee();
                    formEmployeeAdd.activatePanel("employeeAdd");
                    formEmployeeAdd.Show();
                    break;
                case "UKLONI RADNIKA":
                    FormEmployee formEmployeeRemove = new FormEmployee();
                    formEmployeeRemove.activatePanel("employeeRemove");
                    formEmployeeRemove.Show();
                    break;
                case "PRIKAŽI RADNIKE":
                    FormEmployee formEmployeeList = new FormEmployee();
                    formEmployeeList.activatePanel("employeeList");
                    formEmployeeList.Show();
                    break;
                case "RAČUNI":
                    FormFiscal formFiscals = new FormFiscal();
                    formFiscals.Show();
                    break;
                case "DOBAVLJAČI":
                    FormManufactuer formManufactuer = new FormManufactuer();
                    formManufactuer.Show();
                    break;
                case "PORUDŽBINE":
                    FormOrder formOrder = new FormOrder();
                    formOrder.Show();
                    break;
                case "PRIKAŽI LEKOVE":
                    FormMedicine formMedicine = new FormMedicine();
                    formMedicine.Show();
                    break;
                case "IZLAZ >":
                    this.Close();
                    break;
                default:
                    break;
            }
        }






    }
}
