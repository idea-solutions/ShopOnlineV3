using System;
using Domain.Models.Enum;

namespace Domain.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public double Price { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}