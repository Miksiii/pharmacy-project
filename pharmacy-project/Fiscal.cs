using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace cs322_projekat_pharmacy
{
    class Fiscal
    {
        /* Fiscal attributes */
        public ObjectId id { get; set; }
        public ObjectId EmployeeId { get; set; }
        public ObjectId MedicineId { get; set; }
        public string date { get; set; }
        public int fiscalNo { get; set; }
        public string medicineName { get; set; }
        public int medicinePrice { get; set; }

        /* Pharmacy context that holds all MongoDB collections */
        public PharmacyContext ctx;

        /**
         * Constructor init, Initializing PharmacyContext class
         */
        public Fiscal()
        {
            ctx = new PharmacyContext();
        }

        /**
         * This method is being invoked by the Employee on Purchase/Medicine's form. The method
         * uses forwarded object trying to save it into MongoDB Employees collection. 
         * 
         * @param obj
         */
        public void add(Fiscal obj)
        {
            ctx.Fiscals.Save(obj);
        }

        /**
         * This method is being invoked by the Employee on Fiscal's form. The method uses
         * MongoDB linq queries to get specific data (all employees in this case).
         * 
         * @return fiscals
         */
        public List<Fiscal> getFiscalsByFiscalNo()
        {
            List<Fiscal> fiscals = new List<Fiscal>();

            var query = from e in ctx.Fiscals.AsQueryable<Fiscal>() select e;

            foreach (Fiscal fiscal in query)
                fiscals.Add(fiscal);

            return fiscals;
        }

    }
}
