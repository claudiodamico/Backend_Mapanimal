using Microsoft.AspNetCore.Mvc;

namespace Backend_Mapanimal.Controllers
{

    [Route("api/race")]
    public class RaceController
    {
        [HttpGet]
        public void Get() // Get general
        {
            //return GetAllRaces();
        }

        [HttpGet("{Id}")] // Get by Id
        public void Get(int Id)
        {
            //return Get();
        }

        [HttpPost]
        public void Post()
        {
            //return Post();
        }

        [HttpPut]
        public void Put()
        {
            //return Put();
        }

        [HttpDelete]
        public void Delete()
        {
            //return Delete();
        }
    }
}
