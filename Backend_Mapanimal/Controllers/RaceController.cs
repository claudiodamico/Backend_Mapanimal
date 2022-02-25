using Backend_Mapanimal.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend_Mapanimal.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Race>> Get()// Get general
        {
            throw new NotImplementedException();
        }

        [HttpGet("{Id:int}")] // Get by Id
        public async Task<ActionResult<Race>> Get(int Id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult<Race>> Post([FromBody] Race race)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<ActionResult<Race>> Put([FromBody] Race race)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<ActionResult<Race>> Delete()
        {
            throw new NotImplementedException();
        }
    }
}
