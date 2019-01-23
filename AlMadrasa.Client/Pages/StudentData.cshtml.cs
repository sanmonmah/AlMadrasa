using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using AlMadrasa.Shared.Models;
using OfficeOpenXml;
using System.IO;

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
                    studList.Sort((x, y) => x.Birthday.CompareTo(y.Birthday)); 
                break;
                case "entrydate":
                    studList.Sort((x, y) => x.EntryDate.CompareTo(y.EntryDate)); 
                break;
                case "city":
                    studList.Sort((x, y) => x.City.CompareTo(y.City)); 
                break;
                case "telefon":
                    studList.Sort((x, y) => x.PhoneNr1.CompareTo(y.PhoneNr1)); 
                break;
                case "gender":
                    studList.Sort((x, y) => x.Gender.CompareTo(y.Gender)); 
                break;
                case "arclass":
                    studList.Sort((x, y) => x.arClass.CompareTo(y.arClass)); 
                break;
                case "qclass":
                    studList.Sort((x, y) => x.qClass.CompareTo(y.qClass)); 
                break;
                case "contribution":
                    studList.Sort((x, y) => x.MonthContribution.CompareTo(y.MonthContribution)); 
                break;
                case "branch":
                    studList.Sort((x, y) => x.Branch.CompareTo(y.Branch)); 
                break;
                case "postalcode":
                    studList.Sort((x, y) => x.PostalCode.CompareTo(y.PostalCode)); 
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
                    studList.Sort((x, y) => y.Birthday.CompareTo(x.Birthday)); 
                break;
                case "entrydate":
                    studList.Sort((x, y) => y.EntryDate.CompareTo(x.EntryDate)); 
                break;
                case "city":
                    studList.Sort((x, y) => y.City.CompareTo(x.City)); 
                break;
                case "telefon":
                    studList.Sort((x, y) => y.PhoneNr1.CompareTo(x.PhoneNr1)); 
                break;
                case "gender":
                    studList.Sort((x, y) => y.Gender.CompareTo(x.Gender)); 
                break;
                case "arclass":
                    studList.Sort((x, y) => y.arClass.CompareTo(x.arClass)); 
                break;
                case "qclass":
                    studList.Sort((x, y) => y.qClass.CompareTo(x.qClass)); 
                break;
                case "contribution":
                    studList.Sort((x, y) => y.MonthContribution.CompareTo(y.MonthContribution)); 
                break;
                case "branch":
                    studList.Sort((x, y) => y.Branch.CompareTo(x.Branch)); 
                break;
                case "postalcode":
                    studList.Sort((x, y) => y.PostalCode.CompareTo(x.PostalCode)); 
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
                this.isAddarClass = true;
            }

            protected async Task EditarClass(string ID)
            {
                cls = await Http.GetJsonAsync<arClass>("/api/arClass/Details/" + ID);
                this.modalTitle = "Edit arabic class";
                this.isAddarClass = true;
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
                this.isAddarClass = false;
                await GetarClasses();
            }

            protected async Task DeletearClassConfirm(string ID)
            {
                cls = await Http.GetJsonAsync<arClass>("/api/arClass/Details/" + ID);
                this.isDeletearClass = true;
            }
            protected async Task DeletearClass(string ID)
            {
                await Http.DeleteAsync("api/arClass/Delete/" + ID);
                this.isDeletearClass = false;
                await GetarClasses();
            }
        //Quran Class Methode           
            protected qClass qcls = new qClass();
            protected void AddqClass()
            {
                qcls = new qClass();
                this.modalTitle = "Add arabic class";
                this.isAddqClass = true;
            }

            protected async Task EditqClass(string ID)
            {
                qcls = await Http.GetJsonAsync<qClass>("/api/qClass/Details/" + ID);
                this.modalTitle = "Edit arabic class";
                this.isAddqClass = true;
            }

            protected async Task SaveqClass()
            {
                if (qcls.Id != null)
                {
                    await Http.SendJsonAsync(HttpMethod.Put, "api/qClass/Edit", qcls);
                }
                else
                {
                    await Http.SendJsonAsync(HttpMethod.Post, "/api/qClass/Create", qcls);

                }
                this.isAddqClass = false;
                await GetqClasses();
            }

            protected async Task DeleteqClassConfirm(string ID)
            {
                qcls = await Http.GetJsonAsync<qClass>("/api/qClass/Details/" + ID);
                this.isDeleteqClass = true;
            }
            protected async Task DeleteqClass(string ID)
            {
                await Http.DeleteAsync("api/qClass/Delete/" + ID);
                this.isDeleteqClass = false;
                await GetqClasses();
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

           protected string GetarClassfromList(string id)
            {
               arClass xx= arClassList.FirstOrDefault(x => x.Id==id);
               return (xx==null) ? "":xx.Name;
               
            }
            protected string GetqClassfromList(string id)
            {
               qClass xx= qClassList.FirstOrDefault(x => x.Id==id);
               return (xx==null) ? "":xx.Name;
               
            }
            void ExportToExcel()
            {
                using (ExcelPackage pkg = new ExcelPackage())
                {
                    
                    pkg.Workbook.Worksheets.Add("StudentList");
                    var headerRow = new List<string[]>()
                    {
                        new string[] { "Id", "FirstName", "LastName",  }
                    };
                    // Determine the header range (e.g. A1:D1)
                    string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";
                    var worksheet = pkg.Workbook.Worksheets["Worksheet1"];
                    worksheet.Cells[headerRange].LoadFromArrays(headerRow);
                    worksheet.DefaultColWidth = 20.0;
                    FileUtil.SaveAs("studentenliste.xslx", pkg.GetAsByteArray());
                }
            }
        protected void closeModal()
        {
            this.isAdd = false;
            this.isDelete = false;
             this.isAddarClass = false;
            this.isDeletearClass = false;
             this.isAddqClass = false;
            this.isDeleteqClass = false;
            this.isAddMonth = false;
            this.isDeleteMonth = false;
        }
    }
}