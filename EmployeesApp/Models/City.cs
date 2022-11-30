using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Models;

public partial class City
{
    public int CityId { get; set; }

    [Display(Name = "اسم المدينة")]
    public string? CityNameArabic { get; set; }

    [Display(Name = "CityName")]
    public string CityNameEnglish { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
