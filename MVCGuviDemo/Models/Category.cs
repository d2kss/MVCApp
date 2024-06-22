using System.ComponentModel.DataAnnotations;

namespace MVCGuviDemo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0, int.MaxValue)]    
        public int DisplayOrder { get; set; }   
    }
    public class Prdouct
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
    }
}
