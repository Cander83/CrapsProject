using Craps.EntityControllers.CrapsObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Craps.EntityControllers.CrapsObjects
{
    public class CrapsController
    {
        private IRollDataHandler RollDataHandler { get; set; }

        public CrapsController(IRollDataHandler rollHandler)
        {
            RollDataHandler = rollHandler;
        }
    }
}
