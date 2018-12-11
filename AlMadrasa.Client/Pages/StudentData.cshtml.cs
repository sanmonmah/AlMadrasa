using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using AlMadrasa.Shared.Models;

namespace AlMadrasa.Client.Pages
{
    public class StudentDataModel : BlazorComponent
    {
        [Inject]
        protected HttpClient Http { get; set; }

        protected List<Student> studList;
        protected List<arClass> arClassList = new List<arClass>();
        protected List<qClass> qClassList = new List<qClass>();

        protected Student stud = new Student();
        protected string modalTitle { get; set; }
        protected Boolean isDelete = false;
        protected Boolean isAdd = false;

        protected string SearchString { get; set; }

        protected override async Task OnInitAsync()
        {
            await GetStudent();
            await GetarClasses();
        }

        protected async Task GetStudent()
        {
            studList = await Http.GetJsonAsync<List<Student>>("api/Student/Index");
        }

        protected async Task GetarClasses()
        {
            arClassList = await Http.GetJsonAsync<List<arClass>>("api/Student/GetarClasses");
        }

        protected void AddStudent()
        {
            stud = new Student();
            this.modalTitle = "Add Student";
            this.isAdd = true;
        }

        protected async Task EditStudent(string ID)
        {
            stud = await Http.GetJsonAsync<Student>("/api/Student/Details/" + ID);
            this.modalTitle = "Edit Student";
            this.isAdd = true;
        }

        protected async Task SaveStudent()
        {
            if (stud.Id != null)
            {
                await Http.SendJsonAsync(HttpMethod.Put, "api/Student/Edit", stud);
            }
            else
            {
                await Http.SendJsonAsync(HttpMethod.Post, "/api/Student/Create", stud);

            }
            this.isAdd = false;
            await GetStudent();
        }

        protected async Task DeleteConfirm(string ID)
        {
            stud = await Http.GetJsonAsync<Student>("/api/Student/Details/" + ID);
            this.isDelete = true;
        }

        protected async Task DeleteStudent(string ID)
        {
            await Http.DeleteAsync("api/Student/Delete/" + ID);

            this.isDelete = false;
            await GetStudent();
        }
        protected void closeModal()
        {
            this.isAdd = false;
            this.isDelete = false;
        }
    }
}