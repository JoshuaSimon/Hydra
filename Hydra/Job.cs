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

        public Job(int id, int metaId, float cost, string name, bool isLocked, int clientId)
        {
            this.id = id;
            this.metaId = metaId;
            this.cost = cost;
            this.name = name;
            this.isLocked = isLocked;
            this.clientId = clientId;
        }
    }
}

