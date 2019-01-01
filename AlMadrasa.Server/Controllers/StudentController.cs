using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Threading.Tasks;
using AlMadrasa.Server.DataAccess;
using AlMadrasa.Shared.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlMadrasa.Server.Controllers
{
    public class StudentController : Controller
    {
        StudentDataAccessLayer objstudent = new StudentDataAccessLayer();
        
        // [HttpPost]
        // [Route("api/Student/Edit")]
        // public void Save2Json([FromBody] bool save)
        // {
        //     if(save)
        //     objstudent.Save2Json();
        //     else
        //     objstudent.Load2Json();
        // }
        [HttpGet]
        [Route("api/Student/Index")]
        public IEnumerable<Student> Index()
        {
            return objstudent.GetAllStudents();
        }

        [HttpPost]
        [Route("api/Student/Create")]
        
        public void Create([FromBody] Student stud)
        {
            objstudent.AddStudent(stud);
        }

        [HttpGet]
        [Route("api/Student/Details/{id}")]
        public Student Details(string id)
        {
            return objstudent.GetStudentData(id);
        }

        [HttpPut]
        [Route("api/Student/Edit")]
        public void Edit([FromBody]Student stud)
        {
            objstudent.UpdateStudent(stud);
        }

        [HttpDelete]
        [Route("api/Student/Delete/{id}")]
        public void Delete(string id)
        {
            objstudent.DeleteStudent(id);            
        }

        [HttpGet]
        [Route("api/arClass/GetarClasses")]
        public List<arClass> GetarClasses()
        {
            return objstudent.GetarClassData();
        }
        [HttpPost]
        [Route("api/arClass/Create")]
        public void arClassCreate([FromBody] arClass stud)
        {
            objstudent.AddarClass(stud);
        }

        [HttpGet]
        [Route("api/arClass/Details/{id}")]
        public arClass arClassDetails(string id)
        {
            return objstudent.GetarClassData(id);
        }

        [HttpPut]
        [Route("api/arClass/Edit")]
        public void arClassEdit([FromBody]arClass arcls)
        {
            objstudent.UpdatearClass(arcls);
        }

        [HttpDelete]
        [Route("api/arClass/Delete/{id}")]
        public void arClassDelete(string id)
        {
            objstudent.DeletearClass(id);
        }
        [HttpGet]
        [Route("api/Student/GetqClasses")]
        public List<qClass> GetqClasses()
        {
            return objstudent.GetqClassData();
        }
        [HttpPost]
        [Route("api/qClass/Create")]
        public void qClassCreate([FromBody] qClass stud)
        {
            objstudent.AddqClass(stud);
        }

        [HttpGet]
        [Route("api/qClass/Details/{id}")]
        public qClass qClassDetails(string id)
        {
            return objstudent.GetqClassData(id);            
        }

        [HttpPut]
        [Route("api/qClass/Edit")]
        public void qClassEdit([FromBody]qClass qcls)
        {
            objstudent.UpdateqClass(qcls);
        }

        [HttpDelete]
        [Route("api/qClass/Delete/{id}")]
        public void qClassDelete(string id)
        {
            objstudent.DeleteqClass(id);
        }

        [HttpGet]
        [Route("api/Student/GetContributions")]
        public IEnumerable<Contribution> GetContributions()
        {
            return objstudent.GetContributions();
        }
        [HttpGet]
        [Route("api/Student/GetMonthCalendar")]
        public IEnumerable<MonthCalendar> GetMonthCalendar()
        {
            return objstudent.GetMonthCalendar();
        }
        [HttpGet]
        [Route("api/Student/GetBranches")]
        public IEnumerable<Branche> GetBranches()
        {
            return objstudent.GetBranches();
        }

        /// MonthCalendar
        [HttpPost]
        [Route("api/Month/Create")]
        public void MonthCreate([FromBody] MonthCalendar mon)
        {
            objstudent.AddMonth(mon);
        }

        [HttpGet]
        [Route("api/Month/Details/{id}")]
        public MonthCalendar MonthDetails(string id)
        {
            return objstudent.GetMonthData(id);
        }

        [HttpPut]
        [Route("api/Month/Edit")]
        public void MonthEdit([FromBody]MonthCalendar mon)
        {
            objstudent.UpdateMonth(mon);
        }

        [HttpDelete]
        [Route("api/Month/Delete/{id}")]
        public void MonthDelete(string id)
        {
            objstudent.DeleteMonth(id);
        }
        
        [HttpPut]
        [Route("api/Contribution/Edit")]
        public void ContributionEdit([FromBody]Contribution con)
        {
            objstudent.UpdateContribution(con);
        }
    }
}
