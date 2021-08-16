using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Core.Entities.Identity
{
    public class AppUser : IdentityUser<int>
    {
        public string DisplayName { get; set; }
        public Address Address { get; set; }
        
        [StringLength(20)]
        public string Gender { get; set; }
        public DateTimeOffset DOB { get; set; }
        public string ImageUrl { get; set; }
        [StringLength(500)]
        public string Bio { get; set; }
        public bool Profilecomplete { get; set; }
        public int StateCityId { get; set; }
        [StringLength(50)]
        public string Pincode { get; set; }
       
        public int UserNo { get; set; }
        public int RestaurantId { get; set; }
        [StringLength(50)]
        public string ReferedBy { get; set; }
        [StringLength(50)]
        public string ReferralCode { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsRandomUser { get; set; } = false;
      
    }
}