using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities.RestaurantAggregate;

namespace Core.Entities.MasterAggregate
{
    public class Category : BaseEntity
    {
        public int ParentCategory { get; set; }
        [Required]
        [MaxLength(50)]
        public string CategoryName { get; set; }
        [Required]
        public Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }
        public string ImageUrl { get; set; }
        public bool Isdeleted { get; set; } = false;
        public int InsertedBy { get; set; }
        public DateTimeOffset InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public int DeletedBy { get; set; }
        public DateTimeOffset DeletedDate { get; set; }
    }
}