using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BabyStore.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "This field is required and cannot be blank.")]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-z''-'\s]*$", ErrorMessage = "Please enter a category name beginning with a capital letter and made up of letters and spaces only")]
        [Display(Name="Category Name")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}