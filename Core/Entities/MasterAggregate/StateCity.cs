using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.MasterAggregate
{
    public class StateCity : BaseEntity
    {
        public int ParentId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string Abbreviation { get; set; }
        [Required]
        [MaxLength(20)]
        public string AlternateAbbreviation { get; set; }
        [Required]
        [MaxLength(20)]
        public string Code { get; set; }
        public Countries Country { get; set; }
        public int CountryId { get; set; }
        public bool Isdeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
    }
}