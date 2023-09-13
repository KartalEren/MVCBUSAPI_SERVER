using MVCBUSAPI.Data;
using MVCBUSAPI.Entites;
using MVCBUSAPI.Repositories.Abstract;

namespace MVCBUSAPI.Repositories.Concreate
{
    public class AppUserRepo : BaseRepo<AppUser>, IAppUserRepo
    {
        public AppUserRepo(OtobüsDBContext db) : base(db)
        {
        }
    }
}
