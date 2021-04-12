using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WazeCredit.Service.LifetTimeServces
{
    public class SingletonService
    {
        private readonly Guid guid;

        public SingletonService()
        {
            guid = Guid.NewGuid();
        }

        public string getGuid => guid.ToString();
    }
}
