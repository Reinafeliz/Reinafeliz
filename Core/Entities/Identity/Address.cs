using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Identity
{
    public class Address
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int StateId { get; set; }
        public string ZipCode { get; set; }
        [StringLength(500)]
        public string AlternateAddress { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}