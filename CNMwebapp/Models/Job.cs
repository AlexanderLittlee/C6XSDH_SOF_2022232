using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNMwebapp.Models
{
    public class Job
    {
        [Key]
        public string Uid { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }
        
        public int WorkersNeeded { get; set; }

        [NotMapped]
        public  ICollection<Worker> Workers { get; set; }

    }
}
