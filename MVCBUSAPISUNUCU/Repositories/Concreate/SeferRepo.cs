using MVCBUSAPI.Data;
using MVCBUSAPI.Entites;
using MVCBUSAPI.Repositories.Abstract;

namespace MVCBUSAPI.Repositories.Concreate
{
    public class SeferRepo : BaseRepo<Sefer>, ISeferRepo
    {
        public SeferRepo(OtobüsDBContext db) : base(db)
        {
        }
    }
}
