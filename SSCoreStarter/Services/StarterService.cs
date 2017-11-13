using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ServiceStack;

using SSCoreStarter.Types;

namespace SSCoreStarter.Services
{
    [Route("/api/starter", "GET")]
    public class GetStarterReq { }

    public class StarterService : Service
    {
        public Starter Get(GetStarterReq req)
        {
            return new Starter { Hello = "World" };
        }
    }
}
