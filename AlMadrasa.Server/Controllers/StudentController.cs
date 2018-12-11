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
            return objstudent.GetAllEmployees();
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
        [HttpGet]
        [Route("api/Student/GetqClasses")]
        public List<qClass> GetqClasses()
        {
            return objstudent.GetqClassData();
        }
    }
}
