using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW_6_EF.Models
{
    [Keyless] 
    public class OrdersView
    {
        public int OrderId { get; set; }
        public int CarId { get; set; }
        public string CarModel { get; set; } = null!;
        public string CarMake { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
    }
}
