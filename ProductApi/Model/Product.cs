using System.ComponentModel.DataAnnotations;

namespace ProductApi.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? lastName { get; set; }
    }
}
