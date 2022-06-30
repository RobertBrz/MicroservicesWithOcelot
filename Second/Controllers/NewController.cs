using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Second.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewController : ControllerBase
    {

        public NewController()
        {

        }


        [HttpGet]
        public Person GetValue()
        {
            return new Person() { Age = 26, Name = "Test" };
        }

    }
}
