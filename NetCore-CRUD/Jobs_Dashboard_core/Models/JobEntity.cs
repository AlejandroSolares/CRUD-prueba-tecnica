using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs_Dashboard_core.Models
{
    public class JobEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime CreatDate { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime UpdateDate { get; set; }
    }
}
