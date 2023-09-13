using Microsoft.AspNetCore.Mvc;
using MVCBUSAPI.Entites;
using MVCBUSAPI.Repositories.Abstract;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCBUSAPISUNUCU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeferController : ControllerBase
    {
        private readonly ISeferRepo _seferRepo;

        public SeferController(ISeferRepo seferRepo)
        {
            _seferRepo = seferRepo;
        }

        // GET: api/<SeferController>
        [HttpGet]
        public async Task<IEnumerable<Sefer>> Get()//listeleme
        {
            var seferler = await _seferRepo.GetAll(x => x.Id != null);
            return seferler;
        }

        // GET api/<SeferController>/5
        [HttpGet("{id}")]
        public async Task<Sefer> Get(int id)
        {
            var sefer = await _seferRepo.FindById(id);
            return sefer;


        }

        // POST api/<SeferController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Sefer sefer) //oluşturma
        {
            var seferler=await _seferRepo.Create(sefer);
            if (sefer == null)
            {
                return BadRequest();
            }
            return Ok(seferler);
        }

        // PUT api/<SeferController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Sefer sefer) //güncelleme
        {
            var updateSefer = await _seferRepo.Update(sefer);
            if (updateSefer == null)
            {
                return BadRequest();
            }
            return Ok(updateSefer);
        }

        // DELETE api/<SeferController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedSefer = await _seferRepo.FindById(id);
            if (deletedSefer == null)
            {
                return BadRequest();
            }
            await _seferRepo.Delete(deletedSefer);
            return Ok();
        }
    }
}
