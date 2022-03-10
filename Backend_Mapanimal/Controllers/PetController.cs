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
    public class PetController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Pet>> Get()// Get general
        {
            throw new NotImplementedException();
        }

        [HttpGet("{Id:int}")] // Get by Id
        public async Task<ActionResult<Pet>> Get(int Id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult<Pet>> Post([FromBody] Pet pet)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<ActionResult<Pet>> Put([FromBody] Pet pet)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<ActionResult<Pet>> Delete()
        {
            throw new NotImplementedException();
        }
    }
}
