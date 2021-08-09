using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.RestaurantAggregate;

namespace Core.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public Order()
        {
        }

        public Order(int restaurantId, int orderNo, decimal totalAmount, decimal discount, decimal grandTotal,
        decimal taxAmount, decimal netAmount, int tableNo, string orderType, bool orderApproval, int waiterId, string waiterName,
        int orderPin, DeliveryMethod deliveryMethod, IReadOnlyList<OrderDetail> orderDetail,
         IReadOnlyList<OrderCustomer> orderCustomer, IReadOnlyList<TaxDetail> taxDetail, 
         PaymentStatus paymentStatus, OrderMode orderMode, Address shipToAddress, int insertedBy)
        {
            RestaurantId = restaurantId;
            OrderNo = orderNo;
            TotalAmount = totalAmount;
            Discount = discount;
            GrandTotal = grandTotal;
            TaxAmount = taxAmount;
            NetAmount = netAmount;
            TableNo = tableNo;
            OrderType = orderType;
            OrderApproval = orderApproval;
            WaiterId = waiterId;
            WaiterName = waiterName;
            OrderPin = orderPin;
            DeliveryMethod = deliveryMethod;
            OrderDetail = orderDetail;
            OrderCustomer = orderCustomer;
            TaxDetail = taxDetail;
            OrderMode = orderMode;
            ShipToAddress = shipToAddress;
            InsertedBy = insertedBy;
        }

        public Restaurant Restaurant { get; set; }
        [Required]
        public int RestaurantId { get; set; }
        [Required]
        public int OrderNo { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        [Required]
        public decimal GrandTotal { get; set; }
        [Required]
        public decimal TaxAmount { get; set; }
        [Required]
        public decimal NetAmount { get; set; }
        public int TableNo { get; set; }
        [MaxLength(50)]
        public string OrderType { get; set; }
        public bool OrderApproval { get; set; } = false;
        public int WaiterId { get; set; }
        public string WaiterName { get; set; }
        public int OrderPin { get; set; }
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;
        public DeliveryMethod DeliveryMethod { get; set; }
        public IReadOnlyList<OrderDetail> OrderDetail { get; set; }
        public IReadOnlyList<OrderCustomer> OrderCustomer { get; set; }
        public IReadOnlyList<TaxDetail> TaxDetail { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;
        public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending;
        public OrderMode OrderMode { get; set; } = OrderMode.POS;
        public Address ShipToAddress { get; set; }
        public int InsertedBy { get; set; }
        public DateTimeOffset InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public bool Isdeleted { get; set; } = false;
        public int DeletedBy { get; set; }
        public DateTimeOffset DeletedDate { get; set; }
        public bool Cancel { get; set; } = false;
        [MaxLength(500)]
        public string Reason { get; set; }
        public int CancelledBy { get; set; }
        public DateTimeOffset CancelledDate { get; set; }

        // public decimal GetTotal()
        // {
        //     return Subtotal + DeliveryMethod.Price;
        // }
    }
}