using System;

namespace Domain.Models.Entities
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid TypeId { get; set; }
        public Guid OrderId { get; set; }
        public int Quality { get; set; }
        public Order Order { get; set; }
    }
}