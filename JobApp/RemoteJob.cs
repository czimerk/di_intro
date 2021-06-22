using System;
using System.Collections.Generic;
using System.Text;

namespace JobApp
{
    public class RemoteJob : Job
    {
        public RemoteJob(Location loc, JobData data) : base(loc, data)
        {
        }
    }
}
