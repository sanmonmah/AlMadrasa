using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlMadrasa.Shared.Models
{
  
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string   Id { get; set; }
        public string   Name                { get; set; }
        public string   Surname             { get; set; }
        public string   Branch              { get; set; }
        public string Birthday            { get; set; }
        public string EntryDate           { get; set; }
        public string LeavingDate         { get; set; }
        public string   arClass             { get; set; }
        public string   qClass              { get; set; }
        public string   PhoneNr1            { get; set; }
        public string   PhoneNr2            { get; set; }
       
        public string   Gender              { get; set; }
        public string   PostalCode          { get; set; }
        public string   City                { get; set; }
        public int      MonthContribution   { get; set; }

        public Student()
        {
            Name="Name";            Surname="VorName";            Branch ="Botschaft";            Gender="Male";
            PostalCode="55656";        MonthContribution=40;       City="Rüsselsheim";
            PhoneNr1="01792331826";         PhoneNr2="01792331826"; arClass="aldoha"; qClass="alaala";
            Birthday="01.01.2003"; EntryDate="01.01.2017"; LeavingDate="01.01.2018";
            
        }
        public void copyFrom(Student from)
        {
            Name              =from.Name             ;
            Surname           =from.Surname          ;
            Branch            =from.Branch           ;
            Birthday          =from.Birthday         ;
            EntryDate         =from.EntryDate        ;
            LeavingDate       =from.LeavingDate      ;
            arClass           =from.arClass          ;
            qClass            =from.qClass           ;
            PhoneNr1          =from.PhoneNr1         ;
            PhoneNr2          =from.PhoneNr2         ;
            Gender            =from.Gender           ;
            PostalCode        =from.PostalCode       ;
            City              =from.City             ;
            MonthContribution =from.MonthContribution;
        }

    }
    public class Contribution
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string StudentId { get; set; }
        public string MonthID { get; set; }
        public int Payed { get; set; }
    }
    public class MonthCalendar
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]  
        public string   Id { get; set; }      
        public string Month { get; set; }
    }
}
