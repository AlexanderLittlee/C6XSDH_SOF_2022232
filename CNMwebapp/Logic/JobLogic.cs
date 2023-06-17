using CNMwebapp.Models;
using Microsoft.CodeAnalysis;

namespace CNMwebapp.Logic
{
    public class JobLogic : IJobLogic
    {
        public bool SignUpPossible(Job job, Worker worker)
        {
            if (worker != null &&
               job != null &&
               job.Workers.Count() < job.WorkersNeeded &&
               !job.Workers.Contains(worker))
                return true;
            else
                return false;
        }

        public bool StornoPossible(Job job, Worker worker)
        {
            if (worker != null &&
                job != null &&
                worker.Schedule.Contains(job) &&
                job.Workers.Contains(worker))
                return true;
            else
                return false;
        }
    }
}
