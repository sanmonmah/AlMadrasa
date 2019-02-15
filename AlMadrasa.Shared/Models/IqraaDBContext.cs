using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlMadrasa.Shared.Models
{
    public class IqraaJsonDB
    {
        public List<Student> students {get;set;}
        public List<arClass> arclasses {get;set;}
        public List<qClass> qclasses {get;set;}
    }
    public class IqraaDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;
        
        public IqraaDBContext( string connectstring="", string dbstr="")
        {
            MongoClient client;            
            if(connectstring=="")
                 client = new MongoClient("mongodb://localhost:27017");
            else
                 client = new MongoClient(connectstring);
                 
             _mongoDatabase = client.GetDatabase("IqraaDB");
            
        //    var client = new MongoClient("mongodb+srv://user:pwd@moneercl-rc39g.mongodb.net/test?retryWrites=true");
        //     _mongoDatabase = client.GetDatabase("Iqraa");
           
           //var col= _mongoDatabase.ListCollectionNames().ToList();
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
    public class IqraaJsonDBContext
    {
        public IqraaJsonDB _jsonDatabase{get; set;}

        public IqraaJsonDBContext()
        {
            _jsonDatabase=new IqraaJsonDB();
            _jsonDatabase.students=new List<Student>();
            _jsonDatabase.arclasses=new List<arClass>();
            _jsonDatabase.qclasses=new List<qClass>();
            int i;
            for(i=0;i<5;i++)
            {
                _jsonDatabase.students.Add(new Student(){Name="Student"+i,Id=(i+1).ToString()});
            }
            for(i=0;i<5;i++)
            {
                _jsonDatabase.arclasses.Add(new arClass(){Name="arclass"+i});
            }
            for(i=0;i<5;i++)
            {
                _jsonDatabase.qclasses.Add(new qClass(){Name="qclass"+i});
            }
           
            
        }
        public void LoadDB2Json()
        {
             using(StreamReader sr = new StreamReader("./students.json"))
            {
                 _jsonDatabase.students  = JsonConvert.DeserializeObject<List<Student>>(sr.ReadToEnd());                
            }
            using(StreamReader sr = new StreamReader("./arclasses.json"))
            {
                 _jsonDatabase.arclasses  = JsonConvert.DeserializeObject<List<arClass>>(sr.ReadToEnd());                
            }
            using(StreamReader sr = new StreamReader("./aqclasses.json"))
            {
                 _jsonDatabase.qclasses  = JsonConvert.DeserializeObject<List<qClass>>(sr.ReadToEnd());                
            }
        }
        public List<Student> StudentRecord
        {
            get
            {
                return _jsonDatabase.students;
            }
        }

        public List<arClass> arClassRecord
        {
            get
            {
                return _jsonDatabase.arclasses;
            }
        }
        public List<qClass> qClassRecord
        {
            get
            {                
                return _jsonDatabase.qclasses;
            }
        }
        public void SaveDB2Json()
        {
            using (StreamWriter file = File.CreateText(@"./students.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, _jsonDatabase.students);
            }
            using (StreamWriter file = File.CreateText(@"./arclasses.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, _jsonDatabase.arclasses);
            }
            using (StreamWriter file = File.CreateText(@"./qclasses.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, _jsonDatabase.qclasses);
            }
        }
    }
}
