using MyFirstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstWebAPI.Controllers
{
    public class ValuesNotRestController : ApiController
    {
        [HttpPost]
        [Route("valuesnotrest/save")]
        public IHttpActionResult Save(TestingWebApi model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Something went wrong");
            }

            return Ok("created succesfully");
        }

        [HttpPost]
        public IHttpActionResult DeleteMyEntity()
        {
            return Ok();
        }

    }
}
