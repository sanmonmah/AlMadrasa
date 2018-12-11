using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlMadrasa.Shared.Models
{
    public class IqraaDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;

        public IqraaDBContext()
        {
           // var client = new MongoClient("mongodb://localhost:27017");
           // _mongoDatabase = client.GetDatabase("EmployeeDB");
           // var client = new MongoClient("mongodb://moneer1:moneer1@moneercl-shard-00-00-rc39g.mongodb.net:27017,moneercl-shard-00-01-rc39g.mongodb.net:27017,moneercl-shard-00-02-rc39g.mongodb.net:27017/test?ssl=true&replicaSet=MoneerCL-shard-0&authSource=admin&retryWrites=true");
           // _mongoDatabase = client.GetDatabase("EmployeeDB");
           var client = new MongoClient("mongodb+srv://moneer1:moneer1@moneercl-rc39g.mongodb.net/test?retryWrites=true");
            _mongoDatabase = client.GetDatabase("Iqraa");
            
        }

        public IMongoCollection<Student> StudentRecord
        {
            get
            {
                //return _mongoDatabase.GetCollection<Employee>("EmployeeRecord");
                 var coll= _mongoDatabase.GetCollection<Student>("Students");
                 return coll;
            }
        }

        public IMongoCollection<arClass> arClassRecord
        {
            get
            {
                var coll=_mongoDatabase.GetCollection<arClass>("arClasses");
                return coll;
            }
        }
        public IMongoCollection<qClass> qClassRecord
        {
            get
            {
                var coll = _mongoDatabase.GetCollection<qClass>("qClasses");
                return coll;
            }
        }
    }
}
