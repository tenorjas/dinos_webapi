using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinos_webapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace dinos_webapi.Controllers
{
    //
    [Route("api/Dinosaurs")]
    public class DinosaursController : Controller
    {
        // GET api/dinosaurs
        [HttpGet]
        public IEnumerable<DinosModel> Get()
        {
            var dino = new DinosModel();
            IEnumerable<DinosModel> dinos = dino.DinoListGetter();
            return dinos;
        }

        // GET api/dinos/5
        [HttpGet("{id}")]
        public DinosModel Get(int id)
        {
            var dino = new DinosModel();
            List<DinosModel> dinos = dino.DinoListGetter();
            return dinos[id-1];
        }

        // POST api/dinos
        [HttpPost]
        public void Post([FromBody]int id, string name, string size, string habitats)
        {
            var dino = new DinosModel();
            List<DinosModel> dinos = dino.DinoListGetter();
            var newDino = new DinosModel{
                DinoId = id,
                DinoName = name,
                DinoSize = size,
                DinoHabitats = habitats
            };
        }

        // PUT api/dinos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string name, string size, string habitats)
        {
            var dino = new DinosModel();
            List<DinosModel> dinos = dino.DinoListGetter();
            
        }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
