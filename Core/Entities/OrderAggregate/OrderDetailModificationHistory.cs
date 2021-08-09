using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities.MenuAggregate;

namespace Core.Entities.OrderAggregate
{
    public class OrderDetailModificationHistory : BaseEntity
    {
        public OrderDetail OrderDetail { get; set; }
        [Required]
        public int OrderDetailId { get; set; }
        public Menu Menu { get; set; }
        [Required]
        public int MenuId { get; set; }
        [Required]
        public int PreviousQty { get; set; }
        [Required]
        public int CurrentQty { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Total { get; set; }
        public bool Custmizable { get; set; }
        [Required]
        public int InsertedBy { get; set; }
        public DateTimeOffset InsertedDate { get; set; } = DateTime.Now;
    }
}