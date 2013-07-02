using System;

namespace Models
{
    public class OrderDto
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public Guid CustomerNumber { get; set; }
        public int OrderDay { get; set; }
    }
}