using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmployeesApp.Models;

public partial class EmployeesDbContext : DbContext
{
    public EmployeesDbContext(DbContextOptions<EmployeesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

}
