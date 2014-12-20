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
    class Medicine
    {
        /* Medicine attributes */
        public ObjectId id { get; set; }
        public string name { get; set; }
        public string dosage { get; set; }
        public string leafleat { get; set; }
        public string form { get; set; }
        public string expiary_date {get; set;}
        public ObjectId ManufactuerId { get; set; }
        public bool is_available { get; set; }
        public int price { get; set; }

        /* Pharmacy context that holds all MongoDB collections */
        public PharmacyContext ctx;

        /**
         * Constructor init, Initializing PharmacyContext class
         */
        public Medicine()
        {
            ctx = new PharmacyContext();
        }

        /**
         * This method is being invoked by the Employee on his Employee's form. The method uses
         * MongoDB linq queries to get specific data (all employees in this case).
         * 
         * @return employees
         */
        public List<Medicine> getMedicines()
        {
            List<Medicine> medicines = new List<Medicine>();

            var query = from e in ctx.Medicines.AsQueryable<Medicine>() select e;

            foreach (Medicine medicine in query)
                medicines.Add(medicine);

            return medicines;
        }

        /**
         * This method is being invoked by the Employee on Manufactuer's form. The method loops through 
         * the list of all medicines that has ObjectId as actual Manufactuer. It's done using MongoDB linq 
         * queries.
         * 
         * @param Manufactuer
         * @return medicines
         */
        public List<Medicine> getMedicinesBy(ObjectId objectId){

            List<Medicine> medicines = new List<Medicine>();

            var query =
                from e in ctx.Medicines.AsQueryable<Medicine>()
                where e.ManufactuerId == objectId
                select e;

            foreach (Medicine medicine in query)
            {
                medicines.Add(medicine);
            }

            return medicines;
        }

        /**
         * This method is being invoked by the Employee on Medicine's form. The method loops through 
         * the list of all available medicines. It's done using MongoDB linq queries.
         * 
         * @return medicines
         */
        public List<Medicine> getAvailableMedicines()
        {
            List<Medicine> medicines = new List<Medicine>();

            var query =
                from e in ctx.Medicines.AsQueryable<Medicine>()
                where e.is_available == true
                select e;

            foreach (Medicine medicine in query)
            {
                medicines.Add(medicine);
            }

            return medicines;
        }

        /**
         * This method is being invoked by the Employee on Manufactuer's list of medicines when new 
         * order is required. Method updates the value of is_available attribute. It's done using 
         * MongoDB linq queries.
         * 
         * @param objectId
         * @param state - if it's true than update attr's value to true, if not than to false
         */
        public void updateMedicines(ObjectId objectId, bool state)
        {
            var query =
                from e in ctx.Medicines.AsQueryable<Medicine>()
                where e.id == objectId
                select e;

            // Cast linq query to Mongo query
            var mongoQuery = ((MongoQueryable<Medicine>)query).GetMongoQuery();

            var update = Update<Medicine>.Set(e => e.is_available, state);
            ctx.Medicines.Update(mongoQuery, update);
        }
    }
}
