using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.MasterAggregate
{
    public class Cuisines : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string CuisineName { get; set; }
        public bool Isdeleted { get; set; } = false;
        public int InsertedBy { get; set; }
        public DateTimeOffset InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}