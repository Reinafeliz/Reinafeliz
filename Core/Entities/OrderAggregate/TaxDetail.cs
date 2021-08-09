using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.OrderAggregate
{
    public class TaxDetail : BaseEntity
    {
        public TaxDetail()
        {
        }

        public TaxDetail( Order order, int orderId, int typeId, string taxName, string taxType, decimal taxValue, decimal taxAmount)
        {
            Order = order;
            OrderId = orderId;
            TypeId = typeId;
            TaxName = taxName;
            TaxType = taxType;
            TaxValue = taxValue;
        }

               public Order Order { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int TypeId { get; set; }
        [Required]
        public string TaxName { get; set; }
        [Required]
        public string TaxType { get; set; }
        [Required]
        public decimal TaxValue { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTimeOffset InsertedDate { get; set; } = DateTime.Now;
        public bool Cancel { get; set; } = false;
        public DateTimeOffset CancelDate { get; set; }
    }
}