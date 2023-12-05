using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Exercise_7c.Models.DataLayer;

public partial class Student
{
    [Key]
    public int StudentId { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DoB { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Major { get; set; }
}
