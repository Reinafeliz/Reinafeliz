using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.Identity;
using Core.Entities.MenuAggregate;

namespace Core.Entities.OrderAggregate
{
    public class OrderDetail : BaseEntity
    {
        public OrderDetail()
        {
        }

        public OrderDetail(IReadOnlyList<OrderDetailOption> orderDetailOption, 
          int orderId, int menuId, int qty, decimal price,
         decimal itemDiscount, decimal total, bool custmizable, 
          OrderMode orderMode, int appUserId, AppUser appUser, int insertedBy)
        {
            OrderId = orderId;
            MenuId = menuId;
            Qty = qty;
            Price = price;
            ItemDiscount = itemDiscount;
            Total = total;
            Custmizable = custmizable;
            OrderMode = orderMode;
            AppUserId = appUserId;
            AppUser = appUser;
            OrderDetailOption = orderDetailOption;
            InsertedBy = insertedBy;

        }

        public Order Order { get; set; }
        [Required]
        public int OrderId { get; set; }
        public Menu Menu { get; set; }
        [Required]
        public int MenuId { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal ItemDiscount { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        public bool Custmizable { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;
        public OrderMode OrderMode { get; set; } = OrderMode.POS;
        [Required]
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public IReadOnlyList<OrderDetailOption> OrderDetailOption { get; set; }
        public IReadOnlyList<OrderDetailModificationHistory> OrderDetailModificationHistory { get; set; }
        public int InsertedBy { get; set; }
        public DateTimeOffset InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Cancel { get; set; } = false;
        public int CancelledBy { get; set; }
        public DateTime CancelledDate { get; set; }

    }
}