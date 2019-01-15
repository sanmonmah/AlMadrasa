
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlMadrasa.Shared.Models;
using System.IO;
using Newtonsoft.Json;

namespace AlMadrasa.Server.DataAccess
{
    
    public class StudentDataAccessLayer
    {
        IqraaDBContext db = new IqraaDBContext();
       
        //To Get all employees details       
        public List<Student> GetAllStudents()
        {
            try
            {
               return db.StudentRecord.Find(_ => true).ToList(); 
            }
            catch
            {
                throw;
            }
        }
        public List<Branche> GetBranches()
        {
            try
            {
               return db.brancheRecord.Find(_ => true).ToList(); 
            }
            catch
            {
                throw;
            }
        }
        public List<Contribution> GetContributions()
        {
            try
            {
               return db.contributionRecord.Find(_ => true).ToList(); 
            }
            catch
            {
                throw;
            }
        }
        public List<MonthCalendar> GetMonthCalendar()
        {
            try
            {
               return db.monthCalendarRecord.Find(_ => true).ToList(); 
            }
            catch
            {
                throw;
            }
        }
        //To Add new employee record       
        public void AddStudent(Student stud)
        {
            try
            {
                db.StudentRecord.InsertOne(stud);
                List<MonthCalendar> list=db.monthCalendarRecord.Find(_ => true).ToList();
                foreach(MonthCalendar mon in list)
                    db.contributionRecord.InsertOne(new Contribution{StudentId=stud.Id, MonthID=mon.Id});
            }
            catch
            {
                throw;
            }
        }
        public void AddarClass(arClass cls)
        {
            try
            {
               db.arClassRecord.InsertOne(cls);
            }
            catch
            {
                throw;
            }
        }
        public void AddqClass(qClass cls)
        {
            try
            {
                db.qClassRecord.InsertOne(cls);
            }
            catch
            {
                throw;
            }
        }
        public void AddMonth(MonthCalendar mon)
        {
            try
            {
                List<MonthCalendar> mlist=db.monthCalendarRecord.Find(_ => true).ToList();
                    if(mlist.Find((g) => g.Month==mon.Month)!=null) return;
                db.monthCalendarRecord.InsertOne(mon);
                List<Student> list=db.StudentRecord.Find(_ => true).ToList();
                foreach(Student st in list)
                    db.contributionRecord.InsertOne(new Contribution{StudentId=st.Id, MonthID=mon.Id});
            }
            catch
            {
                throw;
            }
        }
        
        //Get the details of a particular employee      
        public Student GetStudentData(string id, string Criteria="")
        {
            try
            {
                FilterDefinition<Student> filterStudentData;
                switch(Criteria)
                {
                    case "Gender":
                    filterStudentData = Builders<Student>.Filter.Eq("Gender", id);
                    break;
                    case "Name":
                     filterStudentData = Builders<Student>.Filter.Eq("Name", id);
                    break;
                    case "Surname":
                        filterStudentData = Builders<Student>.Filter.Eq("Surname", id);
                    break;
                    case "arClass":
                     filterStudentData = Builders<Student>.Filter.Eq("arClass", id);
                    break;
                    case "qClass":
                        filterStudentData = Builders<Student>.Filter.Eq("qClass", id);
                        break;
                    default:
                     filterStudentData = Builders<Student>.Filter.Eq("Id", id);
                    break;
                }

                return db.StudentRecord.Find(filterStudentData).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }
        public arClass GetarClassData(string id, string Criteria = "")
        {
            try
            {
                FilterDefinition<arClass> filterStudentData;
                switch (Criteria)
                {
                    
                    case "Name":
                        filterStudentData = Builders<arClass>.Filter.Eq("Name", id);
                        break;
                    default:
                        filterStudentData = Builders<arClass>.Filter.Eq("Id", id);
                        break;
                }

                return db.arClassRecord.Find(filterStudentData).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }
        public qClass GetqClassData(string id, string Criteria = "")
        {
            try
            {
                FilterDefinition<qClass> filterStudentData;
                switch (Criteria)
                {

                    case "name":
                        filterStudentData = Builders<qClass>.Filter.Eq("Name", id);
                        break;
                    default:
                        filterStudentData = Builders<qClass>.Filter.Eq("Id", id);
                        break;
                }

                return db.qClassRecord.Find(filterStudentData).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }
        public MonthCalendar GetMonthData(string id, string Criteria = "")
        {
            try
            {
                FilterDefinition<MonthCalendar> filterStudentData;
                switch (Criteria)
                {

                    case "month":
                        filterStudentData = Builders<MonthCalendar>.Filter.Eq("Month", id);
                        break;
                    default:
                        filterStudentData = Builders<MonthCalendar>.Filter.Eq("Id", id);
                        break;
                }
                return db.monthCalendarRecord.Find(filterStudentData).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar employee      
        public void UpdateStudent(Student stud)
        {
            try
            {
                db.StudentRecord.ReplaceOne(filter: g => g.Id == stud.Id, replacement: stud);
            }
            catch
            {
                throw;
            }
        }
        public void UpdatearClass(arClass cls)
        {
            try
            {
                db.arClassRecord.ReplaceOne(filter: g => g.Id == cls.Id, replacement: cls);
            }
            catch
            {
                throw;
            }
        }
        public void UpdateqClass(qClass cls)
        {
            try
            {
                db.qClassRecord.ReplaceOne(filter: g => g.Id == cls.Id, replacement: cls);
            }
            catch
            {
                throw;
            }
        }
        public void UpdateMonth(MonthCalendar mon)
        {
            try
            {
                db.monthCalendarRecord.ReplaceOne(filter: g => g.Id == mon.Id, replacement: mon);
            }
            catch
            {
                throw;
            }
        }
        public void UpdateContribution(Contribution con)
        {
            try
            {
                db.contributionRecord.ReplaceOne(filter: g => g.Id == con.Id, replacement: con);
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular employee      
        public void DeleteStudent(string id)
        {
            try
            {
                FilterDefinition<Student> studentData = Builders<Student>.Filter.Eq("Id", id);
                db.StudentRecord.DeleteOne(studentData);
                FilterDefinition<Contribution> monfiltdef = Builders<Contribution>.Filter.Eq("StudentId", id);
                db.contributionRecord.DeleteMany(monfiltdef);
            }
            catch
            {
                throw;
            }
        }
        public void DeletearClass(string id)
        {
            try
            {
                FilterDefinition<arClass> arClassData = Builders<arClass>.Filter.Eq("Id", id);
                db.arClassRecord.DeleteOne(arClassData);
            }
            catch
            {
                throw;
            }
        }
        public void DeleteqClass(string id)
        {
            try
            {
                FilterDefinition<qClass> qClassData = Builders<qClass>.Filter.Eq("Id", id);
                db.qClassRecord.DeleteOne(qClassData);
            }
            catch
            {
                throw;
            }
        }
        public void DeleteMonth(string id)
        {
            try
            {
                FilterDefinition<MonthCalendar> filtdef = Builders<MonthCalendar>.Filter.Eq("Id", id);
                db.monthCalendarRecord.DeleteOne(filtdef);
                FilterDefinition<Contribution> monfiltdef = Builders<Contribution>.Filter.Eq("MonthId", id);
                db.contributionRecord.DeleteOne(monfiltdef);
            }
            catch
            {
                throw;
            }
        }
        // To get the list of Cities  
        public List<arClass> GetarClassData()
        {
            try
            {
                return db.arClassRecord.Find(_ => true).ToList();
            }
            catch
            {
                throw;
            }
        }
        public List<qClass> GetqClassData()
        {
            try
            {
                return db.qClassRecord.Find(_ => true).ToList();
            }
            catch
            {
                throw;
            }
        }
       
    }
}