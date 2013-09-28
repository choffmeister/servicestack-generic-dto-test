using System;
using System.ComponentModel.DataAnnotations;

namespace ServiceStackRestDemo.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(32)]
        public string UserName { get; set; }
    }
}