using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.RestaurantAggregate
{
    public class RestaurantPics : BaseEntity
    {
        public Document Document { get; set; }
        public int DocumentId { get; set; }

        [MaxLength(50)]
        public string PicName { get; set; }
        [MaxLength(50)]
        public string PicType { get; set; }
        public string PicUrl { get; set; }
        public bool Isdeleted { get; set; } = false;
        public int InsertedBy { get; set; }
        public DateTimeOffset InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public int DeletedBy { get; set; }
        public DateTimeOffset DeletedDate { get; set; }
    }
}