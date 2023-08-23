using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Order:Base
    {
        public string CustomerName { get; set; }
        public string CustomerNationality { get; set; }
        public string DrivingLicense { get; set; }
        public string AdvancedPayment { get; set; }
        public DateTime TransactionDate { get; set; }
        public List<OrderCar> orderCars { get; set; }
       
        
    }
}
