using Microsoft.AspNetCore.Mvc;
using MVCBUSAPI.Entites;
using MVCBUSAPI.Repositories.Abstract;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCBUSAPISUNUCU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserRepo _appUserRepo;

        public AppUserController(IAppUserRepo appUserRepo)
        {
            _appUserRepo = appUserRepo;
        }

        // GET: api/<AppUserController>
        [HttpGet]
        public async Task<IEnumerable<AppUser>> Get()//listeleme
        {
            var kullanıcı = await _appUserRepo.GetAll();
            return kullanıcı;
        }

        // GET api/<AppUserController>/5
        [HttpGet("{id}")]
        public async Task<AppUser> Get(int id)
        {
            var kullanıcılar = await _appUserRepo.FindById(id);
            return kullanıcılar;
        }

        // POST api/<AppUserController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AppUser kullanıcı) //oluşturma
        {
            var kullanıcılar = await _appUserRepo.Create(kullanıcı);
            if (kullanıcı == null)
            {
                return BadRequest();
            }
            return Ok(kullanıcılar);
        }

        // PUT api/<AppUserController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]AppUser kullanıcı) //güncelleme
        {
            var updateKullanıcı = await _appUserRepo.Update(kullanıcı);
            if (updateKullanıcı == null)
            {
                return BadRequest();
            }
            return Ok(updateKullanıcı);
        }

        // DELETE api/<AppUserController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) //silme
        {
            var deletedCategory = await _appUserRepo.FindById(id);
            if (deletedCategory == null)
            {
                return BadRequest();
            }
            await _appUserRepo.Delete(deletedCategory);
            return Ok();
        }
    }
}
