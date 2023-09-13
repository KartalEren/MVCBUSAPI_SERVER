using MVCBUSAPI.Data;
using MVCBUSAPI.Entites;
using MVCBUSAPI.Repositories.Abstract;

namespace MVCBUSAPI.Repositories.Concreate
{
    public class OtobüsRepo : BaseRepo<Otobüs>, IOtobüsRepo
    {
        public OtobüsRepo(OtobüsDBContext db) : base(db)
        {
        }
    }
}
