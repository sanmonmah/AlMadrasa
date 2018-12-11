
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlMadrasa.Shared.Models;
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
                // db.EmployeeRecord.InsertOne(new Employee{Name="Mon",Gender="male",Department="Dev"});
                // db.EmployeeRecord.InsertOne(new Employee{Name="Mon2",Gender="male",Department="Dev"});
                //var empl=db.EmployeeRecord.Find(g => g.Gender=="male");
                //var empl=db.StudentRecord.Find(_ => true);
                //var Inu=empl.ToEnumerable();
                //var orde = Inu.OrderBy(x => x.Name);
                //var lis=orde.ToList();
                //var list= empl.ToList();
                //return list;

                return db.StudentRecord.Find(_ => true).ToList();
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

                    case "Name":
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

        //To Delete the record of a particular employee      
        public void DeleteStudent(string id)
        {
            try
            {
                FilterDefinition<Student> studentData = Builders<Student>.Filter.Eq("Id", id);
                db.StudentRecord.DeleteOne(studentData);
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