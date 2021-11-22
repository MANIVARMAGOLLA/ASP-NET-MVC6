using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class DepartmentModel
    {
        [Required(ErrorMessage = "Department Name shouldn't be Empty"),MaxLength(50)]
        [Display(Name ="DepartmentName")]
        [RegularExpression("^[a-zA-Z]*$",ErrorMessage = "DepartmentName can hold only Alphabets")]
        public string DeptName { get; set; }
        [Required]
        [Display(Name = "DepartmentGroupName")]
        public string DeptGroupName { get; set; }
    }
}