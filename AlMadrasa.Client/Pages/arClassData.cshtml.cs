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
    
        public class arClassDataModel : BlazorComponent
        {
            [Inject]
            protected HttpClient Http { get; set; }

           
            protected List<arClass> arClassList = new List<arClass>();
            
            protected arClass cls = new arClass();
            protected string modalTitle { get; set; }
            protected Boolean isDelete = false;
            protected Boolean isAdd = false;

            protected string SearchString { get; set; }

            protected override async Task OnInitAsync()
            {
                await GetarClasses();
            }

            protected async Task GetarClasses()
            {
                arClassList = await Http.GetJsonAsync<List<arClass>>("api/arClass/GetarClasses");
            }

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
            protected void closeModal()
            {
                this.isAdd = false;
                this.isDelete = false;
            }
        }
    
}