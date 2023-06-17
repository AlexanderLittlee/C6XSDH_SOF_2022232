using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNMwebapp.Models
{
    public class Worker : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(18, 100)]
        public int Age { get; set; }

        public bool DriversLicence { get; set; }

        [NotMapped]
        public  virtual ICollection<Job> Schedule { get; set; }

        
    }
}
