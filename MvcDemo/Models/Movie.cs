using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDemo.Models
{
    public class Movie
    {
        [Key] // Primary key;
        public int Id { get; set; }

        [Required(ErrorMessage = "The Title field is required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "The Title must be between 3 and 60 characters")]
        public string Title { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Release date is in incorrect format")]
        [Required(ErrorMessage = "The Release Date field is required")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Category in invalid format")]
        [StringLength(30, ErrorMessage = "Maximum 30 characters"), Required(ErrorMessage = "The Category field is required")]
        public string Category { get; set; }

        [Range(1, 1000, ErrorMessage = "Value between 1 and 1000")]
        [Required(ErrorMessage = "Inform the Price field")]
        [Column(TypeName = "decimal(18,2)")] // this specify in the database;
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Inform the Evaluation field")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Just numbers is allowed")]
        public int Evaluation { get; set; }
    }
}
