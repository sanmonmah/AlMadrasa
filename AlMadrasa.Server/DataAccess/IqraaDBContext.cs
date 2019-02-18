using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AlMadrasa.Shared.Models;
using Microsoft.Extensions.Options;

namespace AlMadrasa.Server.DataAccess
{
     public class IqraaDBContext:IIqraaDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;
        
        public IqraaDBContext( IOptions<Settings> options, IMongoClient client)
        {
           // MongoClient client;  
          
            // client = new MongoClient(options.Value.ConnectionString);
            _mongoDatabase = client.GetDatabase(options.Value.Database);
            
        //    var client = new MongoClient("mongodb+srv://user:pwd@moneercl-rc39g.mongodb.net/test?retryWrites=true");
        //    _mongoDatabase = client.GetDatabase("Iqraa");           
           //var col= _mongoDatabase.ListCollectionNames().ToList();
        }

        public IMongoCollection<Student> StudentRecord
        {
            get
            {
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
        public IMongoCollection<Branche> brancheRecord
        {
            get
            {
                var coll = _mongoDatabase.GetCollection<Branche>("Branches");
                return coll;
            }
        }
        public IMongoCollection<MonthCalendar> monthCalendarRecord
        {
            get
            {
                var coll = _mongoDatabase.GetCollection<MonthCalendar>("MonthCalendar");
                return coll;
            }
        }
        public IMongoCollection<Contribution> contributionRecord
        {
            get
            {
                var coll = _mongoDatabase.GetCollection<Contribution>("Contributions");
                return coll;
            }
        }
    }
   
    
}
