using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ASP_React.Models
{
    public class Task
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Category { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        public string Content { get; set; }
    }
}