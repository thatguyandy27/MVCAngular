using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCApp.Services
{
    public class DynamicController : ApiController
    {
        private Dictionary<string, string[]> Data;

        public DynamicController()
        {
            Data = new Dictionary<string, string[]>();
            Data.Add("1", new string[] { "Mercury", "Venus", "Earth" });
            Data.Add("2", new string[] { "Mars", "Jupiter", "Saturn" });
            Data.Add("3", new string[] { "Uranus", "Neptune", "Pluto" });
        }

        [AcceptVerbs("GET")]
        public string[] Index(string id)
        {
            return Data[id];
        }
    }
}
