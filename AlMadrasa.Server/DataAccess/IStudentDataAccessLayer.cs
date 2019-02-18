using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlMadrasa.Shared.Models;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;


namespace AlMadrasa.Server.DataAccess
{
    
    public interface IStudentDataAccessLayer
    {
        //To Get all employees details       
        List<Student> GetAllStudents();        
         List<Branche> GetBranches();
        List<Contribution> GetContributions();
        List<MonthCalendar> GetMonthCalendar();
        //To Add new employee record       
         void AddStudent(Student stud);
         void AddarClass(arClass cls);
         void AddqClass(qClass cls);
         void AddBranch(Branche cls);
         void AddMonth(MonthCalendar mon);
         Student GetStudentData(string id, string Criteria="");
         arClass GetarClassData(string id, string Criteria = "");
         qClass GetqClassData(string id, string Criteria = "");
         Branche GetBranchData(string id, string Criteria = "");
         MonthCalendar GetMonthData(string id, string Criteria = "");
         void UpdateStudent(Student stud);
         void UpdatearClass(arClass cls);
         void UpdateqClass(qClass cls);
         void UpdateBranch(Branche cls);
         void UpdateMonth(MonthCalendar mon);
         void UpdateContribution(Contribution con);
         void DeleteStudent(string id);
         void DeletearClass(string id);
         void DeleteqClass(string id);
         void DeleteBranch(string id);
         void DeleteMonth(string id);
        List<arClass> GetarClassData();
         List<qClass> GetqClassData();
       
    }
}