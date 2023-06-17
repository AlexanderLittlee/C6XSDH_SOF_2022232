using CNMwebapp.Models;

namespace CNMwebapp.Logic
{
    public interface IJobLogic
    {
        bool SignUpPossible(Job job, Worker worker);
        bool StornoPossible(Job job, Worker worker);
    }
}