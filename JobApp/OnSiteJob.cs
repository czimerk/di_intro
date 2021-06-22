using System;
using System.Collections.Generic;
using System.Text;

namespace JobApp
{
    internal class OnSiteJob : Job
    {
        public OnSiteJob(Location loc, JobData data) : base(loc, data)
        {
        }
    }
}
