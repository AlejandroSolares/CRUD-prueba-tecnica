using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs_Dashboard_core.Models
{
    public class Job_Requestor : JobEntity
    {
        public string Job_RequestorNme { get; set; }
        public string job_RequestorLstNme { get; set; }

        //Request Jobs
        public List<Job> Requested_Jobs { get; set; }
    }
}
