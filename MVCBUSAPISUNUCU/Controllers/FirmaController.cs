using Microsoft.AspNetCore.Mvc;
using MVCBUSAPI.Entites;
using MVCBUSAPI.Repositories.Abstract;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCBUSAPISUNUCU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaController : ControllerBase
    {
        private readonly IFirmaRepo _firmaRepo;

        public FirmaController(IFirmaRepo firmaRepo)
        {
            _firmaRepo = firmaRepo;
        }

        // GET: api/<FirmaController>
        [HttpGet]
        public async Task<IEnumerable<Firma>>  Get()//listeleme
        {
            var firmalar=await _firmaRepo.GetAll(x=>x.Id!=null);
            return firmalar;
        }

        // GET api/<FirmaController>/5
        [HttpGet("{id}")]
        public async Task<Firma> Get(int id)
        {
            var firmalar=await _firmaRepo.FindById(id);
            return firmalar;
        }

        // POST api/<FirmaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Firma firma) //oluşturma
        {
            var firmalar = await _firmaRepo.Create(firma);
            if (firma == null)
            {
                return BadRequest();
            }
            return Ok(firmalar);
        }

        // PUT api/<FirmaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Firma firma) //güncelleme
        {
            var updateFirma = await _firmaRepo.Update(firma);
            if (firma == null)
            {
                return BadRequest();
            }
            return Ok(updateFirma);
        }

        // DELETE api/<FirmaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedFirma = await _firmaRepo.FindById(id);
            if (deletedFirma == null)
            {
                return BadRequest();
            }
            await _firmaRepo.Delete(deletedFirma);
            return Ok(deletedFirma);
        }
    }
}
