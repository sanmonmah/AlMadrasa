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
        protected string Messages="";
        protected List<Student> studList;
        protected List<Student> allStudList;
        protected List<arClass> arClassList = new List<arClass>();
        protected List<qClass> qClassList = new List<qClass>();
        protected List<Branche> branchList = new List<Branche>();
        protected List<MonthCalendar> monthCalendarList = new List<MonthCalendar>();
        protected List<Contribution> contributionList = new List<Contribution>();
        protected List<string> genderList = new List<string>(){"Male","Female"};
        protected Student stud = new Student();
        protected string modalTitle { get; set; }
        protected Boolean isDelete = false;
        protected Boolean isAdd = false;
        protected Boolean isAddMonth = false;
        protected Boolean isDeleteMonth = false;
        protected Boolean isAddarClass = false;
        protected Boolean isDeletearClass = false;
        protected Boolean isAddqClass = false;
        protected Boolean isDeleteqClass = false;
        public string searchstr { get; set; }
        protected override async Task OnInitAsync()
        {
             await GetStudent();
             await GetarClasses();
             await GetqClasses(); 
             await GetBranches();   
             await GetContributions();
             await GetMonthCalendar();    
             Messages="Data has been loaded successful";    
        }
        public string searchCriteria { get; set; }
        public string sortCriteria { get; set; }
        public void SortAscending(string criteria)
        {
            switch(criteria)
            {
                case "name":
                    studList.Sort((x, y) => x.Name.CompareTo(y.Name)); 
                break;
                case "birthdate":
                    studList.Sort((x, y) => x.Birthday.CompareTo(y.Name)); 
                break;
                case "entrydate":
                    studList.Sort((x, y) => x.EntryDate.CompareTo(y.Name)); 
                break;
            }
                    
        }
        public void SortDescending(string criteria)
        {
            switch(criteria)
            {
                case "name":
                    studList.Sort((x, y) => y.Name.CompareTo(x.Name));
                break;
                case "birthdate":
                    studList.Sort((x, y) => y.Birthday.CompareTo(x.Name)); 
                break;
                case "entrydate":
                    studList.Sort((x, y) => y.EntryDate.CompareTo(x.Name)); 
                break;
            }
                     
        }
        public void Filter()
        {
            studList.Clear();
            if(String.IsNullOrEmpty(searchstr))
            {
                foreach(Student st in allStudList)
                    studList.Add(st);

            }
               // studList = allStudList.FindAll((g) => true);
            else
            {
                foreach(Student st in allStudList)
                    if(st.Name.ToUpper().Contains(searchstr.ToUpper()))
                        studList.Add(st);
            }   
            Messages=allStudList.Count.ToString()+","+studList.Count.ToString();          
            //    studList = allStudList.FindAll( (g) => g.Name.Contains(searchstr));             
        }
        
        
        protected async Task GetStudent()
        {
            allStudList = await Http.GetJsonAsync<List<Student>>("api/Student/Index");
            studList = allStudList.FindAll((g) => true);
        }
        protected async Task GetBranches()
        {
            branchList = await Http.GetJsonAsync<List<Branche>>("api/Student/GetBranches");
        }
        protected async Task GetarClasses()
        {
            arClassList = await Http.GetJsonAsync<List<arClass>>("api/arClass/GetarClasses");
        }
        protected async Task GetqClasses()
        {
            qClassList = await Http.GetJsonAsync<List<qClass>>("api/Student/GetqClasses");
        }
        protected async Task GetMonthCalendar()
        {
            monthCalendarList = await Http.GetJsonAsync<List<MonthCalendar>>("api/Student/GetMonthCalendar");
        }
        protected async Task GetContributions()
        {
            contributionList = await Http.GetJsonAsync<List<Contribution>>("api/Student/GetContributions");
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

        //arabic Class Methode
           
            protected arClass cls = new arClass();
            protected void AddarClass()
            {
                cls = new arClass();
                this.modalTitle = "Add arabic class";
                this.isAdd = true;
            }

            protected async Task EditarClass(string ID)
            {
                cls = await Http.GetJsonAsync<arClass>("/api/arClass/Details/" + ID);
                this.modalTitle = "Edit arabic class";
                this.isAdd = true;
            }

            protected async Task SavearClass()
            {
                if (cls.Id != null)
                {
                    await Http.SendJsonAsync(HttpMethod.Put, "api/arClass/Edit", cls);
                }
                else
                {
                    await Http.SendJsonAsync(HttpMethod.Post, "/api/arClass/Create", cls);

                }
                this.isAdd = false;
                await GetarClasses();
            }

            protected async Task DeletearClassConfirm(string ID)
            {
                cls = await Http.GetJsonAsync<arClass>("/api/arClass/Details/" + ID);
                this.isDelete = true;
            }
            protected async Task DeletearClass(string ID)
            {
                await Http.DeleteAsync("api/arClass/Delete/" + ID);
                this.isDelete = false;
                await GetarClasses();
            }
            //
        //Month Calendar Methode           
            protected MonthCalendar month = new MonthCalendar();
            protected void AddMonth()
            {
                month = new MonthCalendar();
                this.modalTitle = "Add Month Calendar";
                this.isAddMonth = true;
            }

            protected async Task EditMonth(string ID)
            {
                month = await Http.GetJsonAsync<MonthCalendar>("/api/Month/Details/" + ID);
                this.modalTitle = "Edit Month";
                this.isAddMonth = true;
            }

            protected async Task SaveMonth()
            {
                if (month.Id != null)
                {
                    await Http.SendJsonAsync(HttpMethod.Put, "api/Month/Edit", month);
                }
                else
                {
                    await Http.SendJsonAsync(HttpMethod.Post, "/api/Month/Create", month);

                }
                this.isAddMonth = false;
                await GetMonthCalendar();
                await GetContributions();
            }
            protected async Task SaveContribution(Contribution con)
            {
                await Http.SendJsonAsync(HttpMethod.Put, "api/Contribution/Edit", con);
            }
               
            
            protected async Task DeleteMonthConfirm(string ID)
            {
                month = await Http.GetJsonAsync<MonthCalendar>("/api/Month/Details/" + ID);
                this.isDeleteMonth = true;
            }
            protected async Task DeleteMonth(string ID)
            {
                await Http.DeleteAsync("api/Month/Delete/" + ID);
                this.isDeleteMonth = false;
                await GetMonthCalendar();
                await GetContributions();
            }
            //    
        protected void closeModal()
        {
            this.isAdd = false;
            this.isDelete = false;
            this.isAddMonth = false;
            this.isDeleteMonth = false;
        }
    }
}