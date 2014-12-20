using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using System.Text.RegularExpressions;
using System.Collections;

namespace cs322_projekat_pharmacy
{
    public partial class FormEmployee : Form
    {
        /* get a reference to a database object */
        private PharmacyContext ctx;

        /**
         * Constructor init
         */
        public FormEmployee()
        {
            InitializeComponent();
            ctx = new PharmacyContext();
        }

        /**
         * Load Employees collection before initializing it's form. 
         * The list is then used for removing specific Employees 
         * from database and list
         */
        private void Form2_Load(object sender, EventArgs e)
        {
            loadEmployeesList();
        }

        /**
         * Loop through Employees MongoDB collection and add/display them to CheckBoxList. 
         * The main key for this list is Employee's licenceNo - removing is done by it.
         */
        public void loadEmployeesList()
        {
            foreach (Employee employee in Employee.Instance.getEmployees())
            {   
                /* display on Employees removal form */
                cbl_employees.Items.Add(
                    employee.firstName + " " + employee.lastName + " (" + employee.licenceNo + ")"
                    );
            }

            /* display on Employees form */
            dgv_employeesList.DataSource = Employee.Instance.getEmployees();
        }

        /**
         * Method invokes the Employee's add method. This means that new Employee will be added to the pharmacy lab. 
         */
        private void employeeAdd(object sender, EventArgs e)
        {
            int n; /* check if licenceNo is a number*/
            bool isNumeric = int.TryParse(tb_licenseNu.Text, out n);

            /* check for validity */
            if (tb_name.Text != "" && tb_lastName.Text != "" && tb_userName.Text != "" && tb_licenseNu.Text != "")
            {
                if (isNumeric != false)
                {
                    Employee newEmployee = new Employee
                    {
                        firstName = tb_name.Text,
                        lastName = tb_lastName.Text,
                        userName = tb_userName.Text,
                        licenceNo = int.Parse(tb_licenseNu.Text)
                    };

                    Employee.Instance.add(newEmployee);
                    lbl_response.Text = "Novi radnik je uspešno dodat.";
                }
                else
                    lbl_response.Text = "Broj licence mora biti broj.";
               
            }
            else
                lbl_response.Text = "Došlo je do greške prilikom dodavanja radnika.";

            tb_name.Text = "";
            tb_lastName.Text = "";
            tb_userName.Text = "";
            tb_licenseNu.Text = "";
        }

        
        /**
         * This method collects Employee's licenceNo in the list afterwards sending it to the
         * Employee's remove method.
         */
        private void employeeRemove(object sender, EventArgs e)
        {
            /* list of licenceNo that needs to be removed */
            ArrayList licenceNoms = new ArrayList();

            for (int i = 0; i < cbl_employees.Items.Count; i++)
            {
                if (cbl_employees.GetItemChecked(i))
                {
                    /* Collecting the licenceNo of all checked objects */
                    string licenceNo = Regex.Match((string)cbl_employees.Items[i], @"\(([^)]*)\)").Groups[1].Value;
                    licenceNoms.Add(licenceNo);
                    lbl_response2.Text = "Uklanjanje uspešno izvršeno.";
                }
                else
                    lbl_response2.Text = "Potrebno je odabrati nekog radnika.";
            }
            
            /* remove selected Employees and refresh CheckBoxList */
            Employee.Instance.destroy(licenceNoms);
            
            for(int i = 0; i < cbl_employees.Items.Count; i++)
            {
                cbl_employees.Items.Remove(i);
            }

        }

        /**
         * This method is called by the Employee when the actions are completed. It destroys 
         * the current Employee's form and redirect Employee back to dashboard.
         */
        private void exitForm(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * This method is called by the Employee on dashboard panel. It is used to check 
         * what panel to show on Employee's form. If he clicks on 'DODAJ RADNIKA' button
         * the form employeeAdd should be displayed.
         * 
         * @param panelName
         */
        public void activatePanel(string panelName)
        {

            if (panelName.Equals("employeeAdd") == true)
            {
                pnl_userAdd.Visible = true;
                lbl_parahraph.Text = "Dodavanje radnika u sistem.";
            }
            else if (panelName.Equals("employeeRemove") == true)
            {
                pnl_userDel.Visible = true;
                lbl_parahraph.Text = "Uklanjanje radnika sa sistema.";
            }
            else if (panelName.Equals("employeeList") == true)
            {
                pnl_employeeList.Visible = true;
                lbl_parahraph.Text = "Izlistavanje svih trenutno zaposlenih radnika.";
            }
        }


    }
}
