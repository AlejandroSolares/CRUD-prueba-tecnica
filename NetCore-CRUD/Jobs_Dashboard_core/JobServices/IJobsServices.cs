using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jobs_Dashboard_core.Models;

namespace Jobs_Dashboard_core.JobServices
{
    public interface IJobsServices
    {
        
        Task<IEnumerable<Job>> GetAll();
        Task<Job> Create(Job job);
        Task<Job> GetById(int id);
        Task<Job> Update(Job job);
        Task<Job> Delete(Job job);


    }
}
