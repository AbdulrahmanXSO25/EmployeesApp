using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    [Display(Name = "الاسـم بالعربيـة")]
    public string EmployeeNameArabic { get; set; } = null!;

    [Display(Name = "English Name")]
    public string EmployeeNameEnglish { get; set; } = null!;

    [Display(Name = "Birth Date")]
    [DisplayFormat(DataFormatString = "{0:dd-MMMM-yyyy}")]
    public DateTime Dob { get; set; }

    [Display(Name = "Hiring Date")]
    [DisplayFormat(DataFormatString = "{0:dd-MMMM-yyyy}")]
    public DateTime HiringDate { get; set; }

    public decimal Salary { get; set; }

    public int? CityId { get; set; }

    public int? DepartmentId { get; set; }

    public virtual City? City { get; set; }

    public virtual Department? Department { get; set; }
}
