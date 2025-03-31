using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW_6_EF.Models;

public partial class Car
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Model { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string Make { get; set; } = null!;

    [Required]
    [Range (1886, 2100)]
    public int Year { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [ForeignKey("UserId")]
    public virtual User User { get; set; } = null!;
}
