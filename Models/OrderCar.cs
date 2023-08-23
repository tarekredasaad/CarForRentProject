using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class OrderCar:Base
    {
        [ForeignKey("Orders")]

        public int OrderId { get; set; }
        public Order Orders { get; set; }
        [ForeignKey("Cars")]

        public int CarId { get; set; }
        public Car Cars { get; set; }
        public DateTime RentFrom { get; set; }
        public DateTime RentTo { get; set; }
        public int Quantity { get; set; }
    }
}
