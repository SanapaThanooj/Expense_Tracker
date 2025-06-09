using System;
using System.ComponentModel.DataAnnotations;

namespace ET.Models
{
    public class expense
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string category { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Expense Date")]
        public DateTime ExpenseDate { get; set; }

        [Display(Name = "Notes")]
        public string? Notes { get; set; }
    }
}