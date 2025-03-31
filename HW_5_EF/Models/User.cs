using System;
using System.Collections.Generic;

namespace HW_EF_5.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
