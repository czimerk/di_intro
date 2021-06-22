using JobApp_DI.Domain;

namespace JobApp_DI.Abstractions
{
    public interface IWorker
    {
        void DoJob(JobData jobData);
        string GetAccountNumber();
        void GoToLocation(Location location);
    }
}