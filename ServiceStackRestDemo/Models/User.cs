using System.ComponentModel.DataAnnotations;

namespace ServiceStackRestDemo.Models
{
    public class User : IEntity<int>
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        public string UserName { get; set; }
    }
}