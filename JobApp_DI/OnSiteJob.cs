using JobApp_DI.Abstractions;
using JobApp_DI.Domain;

namespace JobApp_DI
{
    internal class OnSiteJob : LocationJob
    {
        public OnSiteJob(Location loc, JobData data) : base(loc, data)
        {
        }
    }
}
