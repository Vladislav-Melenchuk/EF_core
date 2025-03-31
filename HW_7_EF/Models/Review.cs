using System;
using System.Collections.Generic;

namespace HW_6_EF.Models;

public partial class Review
{
    public int Id { get; set; }

    public string Comment { get; set; } = null!;

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
