using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace cs322_projekat_pharmacy
{
    class Employee
    {
        /* Employee attributes */
        public ObjectId id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public int licenceNo { get; set; }
        public string dateLoggedIn { get; set; }

        /* Unique instance of Employee */
        public static Employee current_instance = null;

        /* Pharmacy context that holds all MongoDB collections */
        public PharmacyContext ctx;

        /**
         * Constructor init, Initializing PharmacyContext class
         */
        public Employee()
        {
             ctx = new PharmacyContext();
        }

        /**
         * Returns the current active and unique instance of Employee. This
         * class represents a singleton pattern.
         */
        public static Employee Instance
        {
              get 
              {
                 if (current_instance == null)
                 {
                    current_instance = new Employee();
                 }
                 return current_instance;
              }
         }

        /**
         * This method is being invoked by user on the very first panel, login panel. The
         * method tries to find and return the user object with specific parameters. This 
         * lookup is done by MongoDB linq queries.
         * 
         * @param username
         * @param password
         * @return boolean
         */
        public bool isValid(string username, string password)
        {
            bool result = false; 
                                  
            /* try to find the user with specific attributes */
            var query = from e in ctx.Employees.AsQueryable<Employee>()
                        where (e.userName == username && e.licenceNo == int.Parse(password))
                        select e;

            // Cast linq query to Mongo query
            var mongoQuery = ((MongoQueryable<Employee>)query).GetMongoQuery();

            /* set up unique instance if the result isn't null and update the last time logged in value*/
            if (ctx.Employees.FindOne(mongoQuery) != null)
            {
                current_instance = ctx.Employees.FindOne(mongoQuery);
                updateLastTimeLogged(current_instance.id);
                result = true;
            }


            return result;
        }

        /**
         * This method is being invoked if Employee's login credentials are correct. The method updates
         * the value of last time logged in field in MongoDocument.
         * 
         * @param objectId
         */
        public void updateLastTimeLogged(ObjectId objectId)
        {
            var query =
                from e in ctx.Employees.AsQueryable<Employee>()
                where e.id == objectId
                select e;

            /* Cast linq query to Mongo query */
            var mongoQuery = ((MongoQueryable<Employee>)query).GetMongoQuery();

            var update = Update<Employee>.Set(e => e.dateLoggedIn, String.Format("{0:d/M/yyyy HH:mm:ss}", DateTime.Now));
            ctx.Employees.Update(mongoQuery, update);
        }

        /**
         * This method is being invoked by the Employee on his Employee's form. The method
         * uses forwarded object trying to save it into MongoDB Employees collection. 
         * 
         * @param obj
         */
        public void add(Employee obj)
        {
            ctx.Employees.Save(obj);
        }

        /**
         * This method is being invoked by the Employee on his Employee's form. The method uses
         * MongoDB linq queries to get specific data (all employees in this case).
         * 
         * @return employees
         */
        public List<Employee> getEmployees()
        {
            List<Employee> employees = new List<Employee>();

            var query = from e in ctx.Employees.AsQueryable<Employee>() select e;

            foreach (Employee employee in query)
                employees.Add(employee);

            return employees;
        }

        /**
         * This method is being invoked by the Employee on his Employee's form. The method loops through 
         * the list of licenceNoms and destroys each object that coresponds to the licence. It's done using
         * MongoDB linq queries.
         */
        public void destroy(ArrayList licenceNoms)
        {
            foreach (string licenceNo in licenceNoms)
            {
                var query = Query<Employee>.EQ(e => e.licenceNo, int.Parse(licenceNo));
                ctx.Employees.Remove(query);
            }

        }
    }
}
