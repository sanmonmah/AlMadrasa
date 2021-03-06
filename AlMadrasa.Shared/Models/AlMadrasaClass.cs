﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlMadrasa.Shared.Models
{
    public class arClass
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public void copyFrom(arClass from)
        {
            Name=from.Name;
        }
    }
    public class qClass
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
       public void copyFrom(qClass from)
        {
            Name=from.Name;
        }
    }
    public class Branche
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public void copyFrom(qClass from)
        {
            Name=from.Name;
        }
    }

}
