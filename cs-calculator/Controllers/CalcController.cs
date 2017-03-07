using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace cs_calculator.Controllers
{
    public class CalcController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return "value1";
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

    }
}
