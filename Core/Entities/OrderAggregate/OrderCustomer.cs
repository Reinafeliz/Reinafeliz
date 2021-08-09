using System.ComponentModel.DataAnnotations;
using Core.Entities.Identity;

namespace Core.Entities.OrderAggregate
{
    public class OrderCustomer : BaseEntity
    {
        public OrderCustomer()
        {
        }

        public OrderCustomer(int orderId, int userId)
        {
            OrderId = orderId;
            UserId = userId;
        }

        public Order Order { get; set; }
        [Required]
        public int OrderId { get; set; }
        public AppUser User { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}