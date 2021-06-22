using JobApp_DI.Abstractions;
using JobApp_DI.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobApp_DI
{ 
    public class AutomaticSystemJob : Job
    {
        public AutomaticSystemJob(JobData data) : base(data)
        {
        }
    }
}
