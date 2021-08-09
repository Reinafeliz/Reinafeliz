using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities.RestaurantAggregate;

namespace Core.Entities
{
    public class Amenity : BaseEntity
    {
        public Restaurant Restaurant { get; set; }
        [Required]
        public int RestaurantId { get; set; }

        [MaxLength(100)]
        [Required]
        public string AmenityName { get; set; }
        public bool Chargeble { get; set; }
        [MaxLength(50)]
        public string ChargeType { get; set; }
        public decimal Charge { get; set; }
        public int TimeBefore { get; set; }
        public bool Isdeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        [Required]
        public int InsertedBy { get; set; }
        public DateTimeOffset InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public int DeletedBy { get; set; }
        public DateTimeOffset DeletedDate { get; set; }
    }
}