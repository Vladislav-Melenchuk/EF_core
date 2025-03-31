using System;
using System.Collections.Generic;

namespace HW_6_EF.Models;

public partial class OrdersView
{
    public int OrderId { get; set; }

    public int CarId { get; set; }

    public string CarModel { get; set; } = null!;

    public string CarMake { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string UserEmail { get; set; } = null!;
}
