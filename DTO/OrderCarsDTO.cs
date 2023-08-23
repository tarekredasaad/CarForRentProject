using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderCarsDTO
    {
        public int orderId { get; set; }
        public int Id { get; set; }
        public int quantity { get; set; }
        public DateTime rentFrom { get; set; }
        public DateTime rentTo { get; set; }
    }
}
