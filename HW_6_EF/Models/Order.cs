using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW_6_EF.Models;

public partial class Order
{
    public int Id { get; set; }

    [Required]
    public int CarId { get; set; }

    [ForeignKey("CarId")]
    public virtual Car Car { get; set; } = null!;

    public virtual ICollection<ServiceCategory> ServiceCategories { get; set; } = new List<ServiceCategory>();
}
