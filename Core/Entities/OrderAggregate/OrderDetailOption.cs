using System.ComponentModel.DataAnnotations;
using Core.Entities.MenuAggregate;

namespace Core.Entities.OrderAggregate
{
    public class OrderDetailOption : BaseEntity
    {
        public OrderDetail OrderDetail { get; set; }
        [Required]
        public int OrderDetailId { get; set; }
        [Required]
        public int OptRelDetlId { get; set; }
        [Required]
        public int OptionGroupId { get; set; }
        public MenuGroupOption MenuOption { get; set; }
        [Required]
        public int MenuOptionId { get; set; }
        [Required]
        public float Price { get; set; }
        public bool IsDefault { get; set; } = false;
    }
}