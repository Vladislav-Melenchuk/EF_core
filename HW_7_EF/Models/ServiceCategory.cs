using System;
using System.Collections.Generic;

namespace HW_6_EF.Models;

public partial class ServiceCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
