using System;
namespace Hydra
{
    public class Job
    {
        public int id;
        public int metaId;
        public float cost;
        public string name;
        public bool isLocked;
        public int clientId;
        public List<object> parameters;

        public JobStatus Status { get; set; }

        public Job(
            int id, int metaId, float cost, string name,
            bool isLocked, int clientId, List<object> parameters)
        {
            this.id = id;
            this.metaId = metaId;
            this.cost = cost;
            this.name = name;
            this.isLocked = isLocked;
            this.clientId = clientId;
            this.parameters = parameters;
        }

        public enum JobStatus
        {
            Open,
            Waiting,
            InProgress,
            Sucsess,
            Failed,
            Canceled
        }
    }
}

