using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Builders;


/**
 * Class definition:
 * 
 * PharmacyContext represents database context providing a references
 * to it such as MongoDatabase, MongoClient and MongoServer. This class
 * also provides a MongoDB collections that can be accessed by outside of
 * this class.
 * 
 * Database client: MongoDB
 * Database name: PharmacyDB
 * Collections: Radnik, ...
 * 
 */
namespace cs322_projekat_pharmacy
{
    class PharmacyContext
    {
        /* get a reference to a database object */
        private MongoDatabase db;

        /**
         * Initializing both MongoDB client and the server referencees so we can fetch 
         * and get access to the database.
         */
        public PharmacyContext()
        {
            try
            {
                MongoClient client = new MongoClient();     // get a reference to client object 
                var server = client.GetServer();            // get a reference to server object
                this.db = server.GetDatabase("pharmacyDB"); // accessing and fetching the database 
            }
            catch (MongoConnectionException mongoEx)
            {
                System.Console.WriteLine("MongoDB failed to init! " + mongoEx.ToString());
            }
        }


        /**
         * Initializing both MongoDB client and the server referencees so we can fetch 
         * and get access to the database. This operation is set up with addition/extra
         * settings.
         * 
         * @param host
         * @param port
         */
        public PharmacyContext(String host, int port)
        {
            try
            {
                MongoClientSettings settings = new MongoClientSettings(); // get a reference to settings object
                settings.Server = new MongoServerAddress(host, port);     // setting up server settings
                MongoClient client = new MongoClient();                   // get a reference to client object
                var server = client.GetServer();                          // get a reference to server object
                this.db = server.GetDatabase("pharmacyDB");               // accessing and fetching the database
            }
            catch (MongoConnectionException mongoEx)
            {
                System.Console.WriteLine("MongoDB failed to init with extra settings! " + mongoEx.ToString());
            }
        }

        /**
         * This method represents MongoDB collection for Employee collection
         */
        public MongoCollection<Employee> Employees
        {
            get
            {
                return db.GetCollection<Employee>("Employees");
            }
        }

        /**
         * This method represents MongoDB collection for Medicine collection
         */
        public MongoCollection<Medicine> Medicines
        {
            get
            {
                return db.GetCollection<Medicine>("Medicines");
            }
        }

        /**
         * This method represents MongoDB collection for Manufactuer collection
         */
        public MongoCollection<Manufactuer> Manufactuers
        {
            get
            {
                return db.GetCollection<Manufactuer>("Manufactuers");
            }
        }

        /**
         * This method represents MongoDB collection for Order collection
         */
        public MongoCollection<Order> Orders
        {
            get
            {
                return db.GetCollection<Order>("Orders");
            }
        }

        /**
        * This method represents MongoDB collection for Fiscal collection
        */
        public MongoCollection<Fiscal> Fiscals
        {
            get
            {
                return db.GetCollection<Fiscal>("Fiscals");
            }
        }


    }
}
