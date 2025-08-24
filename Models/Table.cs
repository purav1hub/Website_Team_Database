using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GECPATAN_FACULTY_PORTAL.Models;

[Table("Table")]
public partial class Table
{
    [Key]
    public int Id { get; set; }

    [StringLength(10)]
    public string? Name { get; set; }

    public int? Marks { get; set; }
}
