using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WazeCredit.Service.LifetTimeServces
{
    public class TransientService
    {
        private readonly Guid guid;

        public TransientService()
        {
            guid = Guid.NewGuid();
        }

        public string getGuid => guid.ToString();
    }
}
