using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.RestaurantAggregate
{
    public class Document : BaseEntity
    {
        public Document()
        {
        }

        public Document(string name, string documentType, IReadOnlyList<RestaurantPics> restaurantPics)
        {
            Name = name;
            DocumentType = documentType;
            RestaurantPics = restaurantPics;
        }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string DocumentType { get; set; }
        public IReadOnlyList<RestaurantPics> RestaurantPics { get; set; }
        public bool Isdeleted { get; set; } = false;
        public int InsertedBy { get; set; }
        public DateTimeOffset InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }

    }
}