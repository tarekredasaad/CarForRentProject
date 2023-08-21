using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models;

namespace Models
{
    public class OrderCar
    {
        [ForeignKey("Order")]

        public int OrderId { get; set; }
        public Order Order { get; set; }
        [ForeignKey("Car")]

        public int CarId { get; set; }
        public Car Car { get; set; }
        public DateTime RentFrom { get; set; }
        public DateTime RentTo { get; set; }
        public int Quantity { get; set; }
    }
}
