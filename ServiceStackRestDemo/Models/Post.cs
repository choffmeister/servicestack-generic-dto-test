using System;
using System.ComponentModel.DataAnnotations;

namespace ServiceStackRestDemo.Models
{
    public class Post : IEntity<Guid>
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Subject { get; set; }

        public string Content { get; set; }
    }
}