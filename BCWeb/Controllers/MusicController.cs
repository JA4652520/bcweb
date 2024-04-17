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
                    {Id = 1,Usernumber = "bc01",Name ="新造的人" ,},
                new MusicModel() 
                    {Id = 2,Usernumber = "bc02",Name ="My City" ,},
                new MusicModel()
                    {Id = 3,Usernumber = "bc03",Name ="Sunflower" ,},
                new MusicModel()
                    {Id = 4,Usernumber = "bc04",Name ="Push" ,},
                new MusicModel()
                    {Id = 5,Usernumber = "bc05",Name ="Someone You Loved" ,},
            };
        }

        // GET: api/Music/5
        [HttpGet("{usernumber}")]
        public MusicModel Get(string usernumber)
        {
            if (MusicModelFakeDB._dictionary.ContainsKey(usernumber))
            {
                return MusicModelFakeDB._dictionary[usernumber];
            }
            else
            {
                return null;
            }
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
