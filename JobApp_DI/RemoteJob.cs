using JobApp_DI.Abstractions;
using JobApp_DI.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobApp_DI
{
    public class RemoteJob : LocationJob
    {
        public RemoteJob(Location loc, JobData data) : base(loc, data)
        {
        }
    }
}
