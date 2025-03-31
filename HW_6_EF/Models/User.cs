using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HW_6_EF.Models;

public partial class User
{
    public int Id { get; set; }

    [Required]  
    [StringLength(100)]
    public string Name { get; set; } = null!;

    [Required]
    [EmailAddress]  
    [StringLength(150)]
    public string Email { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
