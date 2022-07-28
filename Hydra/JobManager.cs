using System;
namespace Hydra
{
    public class JobManager
    {
        public List<Job> jobList;
        public List<Client> clientList;

        public JobManager()
        {
            this.jobList = new List<Job>();
            this.clientList = new List<Client>();
        }
    }
}

