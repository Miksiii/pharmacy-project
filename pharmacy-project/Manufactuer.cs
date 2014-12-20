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
    class Manufactuer
    {
        /* Manufactuer attributes */
        public ObjectId id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string contact { get; set; }

        /* Pharmacy context that holds all MongoDB collections */
        public PharmacyContext ctx;

        /**
         * Constructor init, Initializing PharmacyContext class
         */
        public Manufactuer()
        {
            ctx = new PharmacyContext();
        }

        /**
         * This method is being invoked by the Employee on manufactuers form visit. 
         * The method uses MongoDB linq queries to get specific data (all manufactuers
         * in this case).
         * 
         * @return manufactuers
         */
        public List<Manufactuer> getManufactuers()
        {
            List<Manufactuer> employees = new List<Manufactuer>();

            var query = from e in ctx.Manufactuers.AsQueryable<Manufactuer>() select e;

            foreach (Manufactuer manufactuer in query)
                employees.Add(manufactuer);

            return employees;
        }

    }
}
