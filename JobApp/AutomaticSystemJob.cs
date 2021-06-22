using System;
using System.Collections.Generic;
using System.Text;

namespace JobApp
{ 
    public class AutomaticSystemJob : Job
    {
        public AutomaticSystemJob(Location loc, JobData data) : base(loc, data)
        {
        }

        /*
        public override void Execute(Worker w)
        {
            //Megoldás 3.
            // nem használjuk az ősosztály implementációt base.Execute(w); 
            w.DoJob(this._jobData);//-> ezeket protecteddé kéne tenni
            PayWorker(w.Account.Number);
        }
        */
    }
}
