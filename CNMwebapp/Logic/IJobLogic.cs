using CNMwebapp.Models;

namespace CNMwebapp.Logic
{
    public interface IJobLogic
    {
        bool SignUpPossible(Job job, Worker worker);
        bool StornoPossible(Job job, Worker worker);
        public void CheckExpiredJobs(ICollection<Job> jobs, Worker worker);
        public bool CheckExpiredJobs(Job job);
        public bool CheckValidDate(DateTime date);
    }
}