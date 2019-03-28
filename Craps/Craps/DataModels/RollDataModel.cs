using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.HPack;

namespace Craps.DataModels
{
    public class RollDataModel
    {
        public string Input { get; set; }

        public int Result { get; set; }

        public string ResultDetails { get; set; }

        public string TimeStamp { get; set; }   
    }
}
