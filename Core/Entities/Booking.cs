using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities.Identity;
using Core.Entities.RestaurantAggregate;

namespace Core.Entities
{
    public class Booking : BaseEntity
    {
        public AppUser AppUser { get; set; }
        [Required]
        public int AppUserId { get; set; }
        public Restaurant Restaurant { get; set; }
        [Required]
        public int RestaurantId { get; set; }
        public Amenity Amenity { get; set; }
        [Required]
        public int AmenityId { get; set; }
        [Required]
        public int NoOfAmenities { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Total { get; set; }

        [MaxLength(100)]
        public string BookingName { get; set; }
        [MaxLength(10)]
        public string Mobile { get; set; }
        public DateTimeOffset BookingDate { get; set; }
        public DateTimeOffset TimeFrom { get; set; }
        public DateTimeOffset TimeTo { get; set; }
        [MaxLength(100)]
        public string BookingFor { get; set; }
        [MaxLength(200)]
        public string AdditionalInfo { get; set; }
        public bool Status { get; set; } = false;
        public bool Isdeleted { get; set; } = false;
        public int InsertedBy { get; set; }
        public DateTimeOffset InsertedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public int DeletedBy { get; set; }
        public DateTimeOffset DeletedDate { get; set; }
        public int CancelledBy { get; set; }
        public DateTimeOffset CancelledDate { get; set; }
        public bool Cancel { get; set; } = false;
        public string CancelReason { get; set; }
    }
}