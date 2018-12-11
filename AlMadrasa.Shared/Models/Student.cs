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
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime LeavingDate { get; set; }
        public string arClass { get; set; }
        public string qClass { get; set; }
        public string PhoneNr1 { get; set; }
        public string PhoneNr2 { get; set; }
        public string PhoneNr3 { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }


    }
}
