using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BabyStore.Models
{
    public class ProductImage
    {
        public int ID { get; set; }
        [Display(Name = "File")]
        [Index(IsUnique = true)]
        [StringLength(100)]
        public string FileName { get; set; }

        public virtual ICollection<ProductImageMapping> ProductImageMappings { get; set; }
    }
}