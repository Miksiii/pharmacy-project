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
    class Order
    {
        /* Order attributes */
        public ObjectId id { get; set; }
        public ObjectId EmployeeId { get; set; }
        public ObjectId ManufactuerId { get; set; }
        public ObjectId MedicineId { get; set; }
        public string date { get; set; }

        /* Pharmacy context that holds all MongoDB collections */
        public PharmacyContext ctx;

        /**
         * Constructor init, Initializing PharmacyContext class
         */
        public Order() {
            ctx = new PharmacyContext();
        }

        /**
        * This method is being invoked by the Employee on Manufactuers/Medicines form when it's required
        * to order some medicines. When button order is clicked, the method creates a new entry in the
        * collection. The method uses MongoDB linq queries to get specific data (all employees in this case).
        * 
        * @param obj
        */
        public void add(Order obj)
        {
            ctx.Orders.Save(obj);
        }

        /**
         * This method is being invoked by the Employee on the Orders form. It returns a list of all
         * relevant orders.The method uses MongoDB linq queries to get specific data (all employees in this case).
         * 
         * @return orders
         */
        public List<Order> getOrders() 
        {
            List<Order> orders = new List<Order>();

            var query = from e in ctx.Orders.AsQueryable<Order>() select e;

            foreach (Order order in query)
                orders.Add(order);

            return orders;
        }
    }
}
