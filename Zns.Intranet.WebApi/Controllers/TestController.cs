using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zns.Intranet.WebApi.Models;

namespace Zns.Intranet.WebApi.Controllers
{
    public class TestController : ApiController
    {
        // GET: api/Test
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET: api/Test/5
        public string Get(int id)
        {
            return "value";
            //return Request.CreateResponse(HttpStatusCode.Accepted, "Returning response with response code.");
        }

        // GET: api/Test/5
        public string Get(int id,string name,bool isActive, Guid serialNumber)
        {
            return $"Test for primitive parameters: {id} - {name} - {isActive} -{serialNumber}";
        }


        //POST: api/Test
        //public void Post([FromBody]string value)
        //{
        //}
        public void Post(int id, TestData testRecord)
        {
        }
        //PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
    public class TestData
    {
        public int ID { get; set; }
        public string Data { get; set; }
    }
}
