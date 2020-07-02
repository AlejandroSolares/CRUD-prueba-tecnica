using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs_Dashboard_core.Models
{
    public class Jobs : JobEntity
    {
        [Required]
        public String JobTitl { get; set; }
        public String JobDesc { get; set; }
        [DataType(DataType.Date)]
        public DateTime JobCreat { get; set; }
        [DataType(DataType.Date)]
        public DateTime JobExpi { get; set; }

        //Job types
        public List<Job_Type> Job_Types { get; set; }

        //Job Requestor
        public int Job_RequestorID { get; set; }
        public Job_Requestor Requestor { get; set; }
    }
}
