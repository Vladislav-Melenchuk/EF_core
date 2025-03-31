using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW_6_EF.Models;

public partial class Order
{
    public int Id { get; set; }

    public int CarId { get; set; }

    public int UserId { get; set; }

    [ForeignKey("CarId")]
    public virtual Car Car { get; set; }  

    public virtual User User { get; set; } = null!;

    public virtual ICollection<ServiceCategory> ServiceCategories { get; set; } = new List<ServiceCategory>();
}
