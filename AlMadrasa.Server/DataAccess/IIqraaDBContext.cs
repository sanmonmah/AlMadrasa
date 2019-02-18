using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AlMadrasa.Shared.Models;

namespace AlMadrasa.Server.DataAccess
{
   
    public interface IIqraaDBContext
    {
                
        IMongoCollection<Student> StudentRecord{get;}       
        IMongoCollection<arClass> arClassRecord{get;}       
        IMongoCollection<qClass> qClassRecord{get;}        
        IMongoCollection<Branche> brancheRecord{get;}        
        IMongoCollection<MonthCalendar> monthCalendarRecord{get;}        
         IMongoCollection<Contribution> contributionRecord{get;}
       
    }
   
    
}
