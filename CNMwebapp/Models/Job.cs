using System.ComponentModel.DataAnnotations;

namespace CNMwebapp.Models
{
    public class Job
    {
        [Key]
        public string Uid { get; set; }

        public string Name { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public int WorkersNeeded { get; set; }

        public Worker[] Workers { get; set; }

        public string OwnerId { get; set; }

        public Job()
        {
            Uid = Guid.NewGuid().ToString();
            Workers = new Worker[WorkersNeeded];
        }
    }
}
