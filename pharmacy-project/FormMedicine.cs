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
using MongoDB.Driver.Linq;

namespace cs322_projekat_pharmacy
{
    public partial class FormMedicine : Form
    {
        /* get a reference of Medicine class */
        Medicine medicineHelper;
        Fiscal fiscalHelper;
        Random rand = new Random();

        public FormMedicine()
        {
            InitializeComponent();
            medicineHelper = new Medicine();
            fiscalHelper = new Fiscal();
        }

        /**
         * When form loads fill in DataGridView with content of all available medicines
         */
        private void FormMedicine_Load(object sender, EventArgs e)
        {
            dgv_AvaialbleMedicines.DataSource = medicineHelper.getAvailableMedicines();
        }

        /**
         * The method closes the current active form
         */
        private void exitForm(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * This method is being invoked by Employee on the Medicine/Purchase Form. The Employee
         * has to select the required medicines and click to purchase button. The method loops
         * through the list of medicines and create a new fiscal account.
         */
        private void purchase(object sender, EventArgs e)
        {
            /* rand unique fiscal no */
            int randFiscalNo = rand.Next(1, 999999);

            if (dgv_AvaialbleMedicines.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow item in this.dgv_AvaialbleMedicines.SelectedRows)
                {
                    var MedicineId = (ObjectId)item.Cells[0].Value;     // get medicine id from selected item
                    medicineHelper.updateMedicines(MedicineId, false);  // update the value of selected medicines

                    /* create new fiscal account for purchase */
                    Fiscal newFiscal = new Fiscal
                    {
                        EmployeeId = Employee.Instance.id,
                        MedicineId = MedicineId,
                        fiscalNo = randFiscalNo,
                        date = String.Format("{0:d/M/yyyy HH:mm:ss}", DateTime.Now),
                        medicineName = item.Cells[1].Value.ToString(),
                        medicinePrice = Convert.ToInt32(item.Cells[8].Value)
                    };

                    fiscalHelper.add(newFiscal);
                }

                
                /* refreshing datagridview */
                dgv_AvaialbleMedicines.DataSource = medicineHelper.getAvailableMedicines();
                lbl_response.Text = "Transakcija je uspešno završena. Račun je izdat.";
            }
            else
                lbl_response.Text = "Nijedan od lekova nije odabran.";
        }
    }
}
