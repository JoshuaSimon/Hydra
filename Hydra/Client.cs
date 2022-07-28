using System;
namespace Hydra
{
    public class Client
    {
        public int id;
        public float capacity;
        public float load;

        public Client(int id, float capacity, float load = 0.0f)
        {
            this.id = id;
            this.capacity = capacity;
            this.load = load;
        }
    }
}

