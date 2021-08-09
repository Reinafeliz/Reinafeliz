using System.ComponentModel.DataAnnotations;

namespace Core.Entities.MasterAggregate
{
    public class Countries : BaseEntity
    {
        [Required]
        [MaxLength(2)]
        public string ISO { get; set; }
        [Required]
        [MaxLength(100)] 
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string NiceName { get; set; }
        [Required]
        [MaxLength(3)]
        public string ISO3 { get; set; }
        public int NumCode { get; set; }
        [Required]
        public int PhoneCode { get; set; }
        public bool IsActive { get; set; } = true;
    }
}