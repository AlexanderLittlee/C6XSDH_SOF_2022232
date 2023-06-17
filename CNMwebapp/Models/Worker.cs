using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNMwebapp.Models
{
    public class Worker : IdentityUser
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool DriversLicence { get; set; }

        [NotMapped]
        public  virtual ICollection<Job> Schedule { get; set; }

        
    }
}
