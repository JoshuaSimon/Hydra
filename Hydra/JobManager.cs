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

        public void DistributeJobs()
        {
            // Sort jobList by open jobs with highest priority.
            GetOpenJobs();

            // Sort clientList by clients with lowest load.
            GetClients();

            // Match jobs to clients.
            int clientIndex = 0;
            foreach (Job job in jobList)
            {
                job.clientId = clientList[clientIndex].id;

                if (clientIndex == clientList.Count)
                {
                    clientIndex = 0;

                    // Resort clientList by new lowest load.
                }
            }
        }

        private void GetOpenJobs()
        {

        }

        private void GetClients()
        {

        }
    }
}

