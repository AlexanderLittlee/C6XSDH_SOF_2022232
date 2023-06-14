using System.ComponentModel.DataAnnotations;

namespace CNMwebapp.Models
{
    public class Worker
    {
        [Key]
        public string Uid { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool DriversLicence { get; set; }

        
        public List<Job> Schedule { get; set; }

        public Worker()
        {
            Uid = Guid.NewGuid().ToString();
            Schedule = new List<Job>();
        }
    }
}
