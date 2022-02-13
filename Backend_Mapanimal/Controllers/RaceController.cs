using Backend_Mapanimal.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Backend_Mapanimal.Controllers
{

    [Route("api/race")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        private readonly ILogger<RaceController> logger;

        public RaceController(ILogger<RaceController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public ActionResult <List<Race>> Get()// Get general
        {
            return new List<Race>() { new Race() { Id = 1, Name = "Puqui" } };
        }

        [HttpGet("{Id:int}")] // Get by Id
        public ActionResult<Race> Get(int Id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Race race)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Race race)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public AcceptedResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
