using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BCWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        // GET: api/Music
        [HttpGet]
        public IEnumerable<MusicModel> Get()    
        {
            return new MusicModel[]
            {
                new MusicModel()
                {
                    Id = 1,Usernumber = "bc01",Name ="新造的人" ,},
            };
        }

        // GET: api/Music/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Music
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Music/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Music/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
