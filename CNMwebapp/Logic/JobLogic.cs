using CNMwebapp.Models;
using Microsoft.CodeAnalysis;

namespace CNMwebapp.Logic
{
    public class JobLogic : IJobLogic
    {
        public bool SignUpPossible(Job job, Worker worker)
        {
            return worker != null
                   && job != null
                   && job.Workers.Count() < job.WorkersNeeded
                   && !job.Workers.Contains(worker);
        }

        public bool StornoPossible(Job job, Worker worker)
        {
            return worker != null
                   && job != null
                   && worker.Schedule.Contains(job)
                   && job.Workers.Contains(worker)
                   && CheckThreeDayDifference(job.Date);
        }


        public bool CheckThreeDayDifference(DateTime date)
        {
            DateTime currendDate = DateTime.Now;
            TimeSpan difference = date - currendDate;
            return difference.TotalDays >= 3;
        }


        public void CheckExpiredJobs(ICollection<Job> jobs, Worker worker)
        {
            DateTime currendDate = DateTime.Now;
            TimeSpan diffence;
            foreach (var job in jobs)
            {
                diffence=job.Date - currendDate;
                if(diffence.TotalDays < 0)
                {
                    worker.Schedule.Remove(job);
                    job.Workers.Remove(worker);
                    jobs.Remove(job);
                }
            }
        }

        public bool CheckExpiredJobs(Job job)
        {
            DateTime currendDate = DateTime.Now;
            TimeSpan diffence;
            diffence = job.Date - currendDate;
            if (diffence.TotalMinutes < 0)
            {  
                foreach(var worker in job.Workers)
                {
                    worker.Schedule.Remove(job);
                    job.Workers.Remove(worker);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckValidDate(DateTime date)
        {
            DateTime currendDate = DateTime.Now;
            TimeSpan difference = date - currendDate;
            return difference.TotalDays > 0;
        }
    }
}
