using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Core.Models
{
    public class BaseEntity : IBaseEntity
    {
        public ObjectId Id { get; set; }
    }
}
