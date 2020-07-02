using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jobs_Dashboard_core.Models;
using Jobs_Dashboard_core.JobServices;
using Jobs_Dashboard_core.MiddleData;

namespace Jobs_Dashboard_core.JobServices
{
    public class JobServices : IJobsServices
    {
        private readonly Jobs_Context _context;
        //dep injection
        public JobServices(Jobs_Context ctx) {
            _context = ctx;

        }

        public Task<Job> Create(Job job)
        {
            return Task.Run(() =>
            {
                try
                {
                    _context.Jobs.Add(job);
                    _context.SaveChanges();

                    return job;
                }
                catch (Exception exp)
                {
                    Console.WriteLine($"Error: {exp}");
                }

                return null;
            });
        }

        public Task<Job> Delete(Job job)
        {
            //throw new NotImplementedException();
            return Task.Run(() =>
            {
                try
                {
                    _context.Jobs.Remove(job);
                    _context.SaveChanges();

                    return job;
                }
                catch (Exception exp)
                {
                    Console.WriteLine($"Error: {exp}");
                }

                return null;
            });
        }

        public Task<IEnumerable<Job>> GetAll()
        {
            return Task.Run(() =>
            {
                try
                {
                    

                    return _context.Jobs.OrderBy(v => v.CreateDate).AsEnumerable();
                }
                catch (Exception exp)
                {
                    Console.WriteLine($"Error: {exp}");
                }

                return null;
            });
        }

        public Task<Job> GetById(int id)
        {
            return Task.Run(() =>
            {
                try
                {


                    var video = _context.Jobs.Where(v => v.Id == id).First();
                    if(video != null)
                    {
                        return video;

                    }

                }
                catch (Exception exp)
                {
                    Console.WriteLine($"Error: {exp}");
                }

                return null;
            });
        }

        public Task<Job> Update(Job job)
        {
            //throw new NotImplementedException();
            return Task.Run(() =>
            {
                try
                {
                    _context.Jobs.Update(job);
                    _context.SaveChanges();

                    return job;
                }
                catch (Exception exp)
                {
                    Console.WriteLine($"Error: {exp}");
                }

                return null;
            });
        }
    }
}
