using System;
using System.Collections.Generic;
using System.Linq;
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
        public void Edit([FromBody]Student employee)
        {
            objstudent.UpdateStudent(employee);
        }

        [HttpDelete]
        [Route("api/Student/Delete/{id}")]
        public void Delete(string id)
        {
            objstudent.DeleteStudent(id);
        }

        [HttpGet]
        [Route("api/Student/GetarClasses")]
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
        public Student arClassDetails(string id)
        {
            return objstudent.GetarClassData(id);
        }

        [HttpPut]
        [Route("api/arClass/Edit")]
        public void arClassEdit([FromBody]arClass employee)
        {
            objstudent.UpdatearClass(employee);
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
        public Student qClassDetails(string id)
        {
            return objstudent.GetqClassData(id);
        }

        [HttpPut]
        [Route("api/qClass/Edit")]
        public void qClassEdit([FromBody]qClass employee)
        {
            objstudent.UpdateqClass(employee);
        }

        [HttpDelete]
        [Route("api/qClass/Delete/{id}")]
        public void qClassDelete(string id)
        {
            objstudent.DeleteqClass(id);
        }
    }
}
