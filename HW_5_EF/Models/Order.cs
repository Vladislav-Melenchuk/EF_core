using System;
using System.Collections.Generic;

namespace HW_EF_5.Models;

public partial class Order
{
    public int Id { get; set; }

    public int CarId { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual ICollection<ServiceCategory> ServiceCategories { get; set; } = new List<ServiceCategory>();
}
