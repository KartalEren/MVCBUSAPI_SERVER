using Microsoft.AspNetCore.Mvc;
using MVCBUSAPI.Entites;
using MVCBUSAPI.Repositories.Abstract;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCBUSAPISUNUCU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtobüsController : ControllerBase
    {
        private readonly IOtobüsRepo _otobüsRepo;

        public OtobüsController(IOtobüsRepo otobüsRepo)
        {
            _otobüsRepo = otobüsRepo;
        }


        // GET: api/<OtobüsController>
        [HttpGet]
        public async Task<IEnumerable<Otobüs>>  Get() //listeleme
        {
            var otobüs=await _otobüsRepo.GetAll(x=>x.Id!=null);
            return otobüs;
        }

        // GET api/<OtobüsController>/5
        [HttpGet("{id}")]
        public async Task<Otobüs> Get(int id)
        {
            var otobüsler=await _otobüsRepo.FindById(id);
            return otobüsler;
        }

        // POST api/<OtobüsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Otobüs otobüs) //oluşturma
        {
            var otobüsler = await _otobüsRepo.Create(otobüs);
            if (otobüs == null)
            {
                return BadRequest();
            }
            return Ok(otobüsler);
        }

        // PUT api/<OtobüsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Otobüs otobüs) //güncelleme
        {
            var updateOtobüs = await _otobüsRepo.Update(otobüs);
            if (updateOtobüs == null)
            {
                return BadRequest();
            }
            return Ok(updateOtobüs);
        }

        // DELETE api/<OtobüsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) //silme
        {
            var deletedOtobüs = await _otobüsRepo.FindById(id);
            if (deletedOtobüs == null)
            {
                return BadRequest();
            }
            await _otobüsRepo.Delete(deletedOtobüs);
            return Ok();
        }
    }
}
