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
    }
}
