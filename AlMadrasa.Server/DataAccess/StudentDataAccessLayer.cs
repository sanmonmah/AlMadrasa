
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
        public List<Student> GetAllEmployees()
        {
            try
            {
                // db.EmployeeRecord.InsertOne(new Employee{Name="Mon",Gender="male",Department="Dev"});
                // db.EmployeeRecord.InsertOne(new Employee{Name="Mon2",Gender="male",Department="Dev"});
                var empl=db.StudentRecord.Find(_ => true);
                //var empl=db.EmployeeRecord.Find(g => g.Gender=="male");
                var Inu=empl.ToEnumerable();
                var orde = Inu.OrderBy(x => x.Name);
                var lis=orde.ToList();
                var list= empl.ToList();
                return list;
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
                    case "arClass":
                     filterStudentData = Builders<Student>.Filter.Eq("arClass", id);
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