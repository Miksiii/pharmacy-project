using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs322_projekat_pharmacy
{
    public partial class FormFiscal : Form
    {
        /* get a reference of Fiscal class */
        private Fiscal fiscalHelper;

        public FormFiscal()
        {
            InitializeComponent();
            fiscalHelper = new Fiscal();
        }

        /**
         * When form loads fetch the list of fiscal transactions 
         */
        private void FormFiscal_Load(object sender, EventArgs e)
        {
            loadFiscalsList();
        }

        /**
         * Loop through Fiscals MongoDB collection and add/display them to ListBox. 
         * From this point, Employee will be able to select transaction and check 
         * the details of fiscal account. 
         */
        public void loadFiscalsList()
        {
            dgv_fiscals.DataSource = fiscalHelper.getFiscalsByFiscalNo();
        }

        /**
         * Close the current form 
         */
        private void exitForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadConcreteFiscal(object sender, EventArgs e)
        {
            if (dgv_fiscals.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow item in this.dgv_fiscals.SelectedRows)
                {
                    var MedicineId = item.Cells[4].Value;     // get fiscalNo
                    MessageBox.Show("" + MedicineId);
                }

                /* refreshing datagridview */
                lbl_response.Text = "Transakcija je uspešno završena.";
            }
            else
                lbl_response.Text = "Nijedan fiskalni račun nije odabran.";
        }
    }
}
