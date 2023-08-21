using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Car:Base
    {
        [ForeignKey("Model")]
        public int ModelID { get; set; }
        public Model Model { get; set; }
        public decimal Power { get; set; }
        public int Year { get; set; }
    }
}

