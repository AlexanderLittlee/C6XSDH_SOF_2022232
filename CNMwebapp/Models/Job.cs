using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNMwebapp.Models
{
    public class Job
    {
        [Key]
        public string Uid { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Required]
        [MinimumCurrentTime]
        public DateTime Date { get; set; }

        [Required]
        [Range(0, 100)]
        public int WorkersNeeded { get; set; }

        [NotMapped]
        public virtual ICollection<Worker> Workers { get; set; }

    }
}
