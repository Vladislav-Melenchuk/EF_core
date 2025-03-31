using System;
using System.Collections.Generic;

namespace HW_EF_5.Models;

public partial class Car
{
    public int Id { get; set; }

    public string Model { get; set; } = null!;

    public string Make { get; set; } = null!;

    public int Year { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual User User { get; set; } = null!;
}
