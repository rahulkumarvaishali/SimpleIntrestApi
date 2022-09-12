using SimpleIntrestApi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleIntrestApi.Controllers
{
    public class InterestController : ApiController
    {
        [Route("Interest/GetList")]
        public List<string> GetList()
        {
            List<string> Namelist = new List<string>()
            {
                "rahul","kumar","yadav","Shivam"
            };
            return Namelist;
        }
        [Route("Interest/GetList1")]

        public List<string> GetList1()
        {
            List<string> Namelist = new List<string>()
            {
                "rahul1","kumar1","yadav1","Shivam1"
            };
            return Namelist;
        }


        [Route("Interest/GetList2")]
/*        [HttpGet]
*/        public List<Intrest> GetList2()
        {
            harshEntities1 entobj = new harshEntities1();
            var res = entobj.Intrests.ToList();
            return res;
        }
    }
}