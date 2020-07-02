using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jobs_Dashboard_core.Models;

namespace Jobs_Dashboard_core.MiddleData
{
    public class Jobs_Context : DbContext
    {
        public Jobs_Context(DbContextOptions<Jobs_Context> options) : base(options)
        { }

        //Tables
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Job_Requestor> Job_Requestors { get; set; }
        public DbSet<Job_Type> Job_Types { get; set; }


    }
}
