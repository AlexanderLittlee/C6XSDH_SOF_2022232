namespace CNMwebapp.Models
{
    public class Worker
    {
        public string Uid { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool DriversLicence { get; set; }

        public List<DateTime> Schedule { get; set; }

        public Worker()
        {
            Uid = Guid.NewGuid().ToString();
            Schedule = new List<DateTime>();
        }
    }
}
