using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Model : Base
    {
        public string Name { get; set; }
        public string Type { get; set; }
        [ForeignKey("Brand")]
        public int BrandID { get; set; }
        public Brand Brand { get; set; }
    }
}
