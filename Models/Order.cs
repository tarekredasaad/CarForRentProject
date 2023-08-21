using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace Models
{
    public class Order:Base
    {
        public string CustomerName { get; set; }
        public string CustomerNationality { get; set; }
        public string DrivingLicense { get; set; }
        public string AdvancedPayment { get; set; }
        public DateTime TransactionDate { get; set; }
        //[ForeignKey("Car")]
        public string CarID { get; set; }
        public Car Car { get; set; }
        
    }
}
