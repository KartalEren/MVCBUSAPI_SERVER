using MVCBUSAPI.Data;
using MVCBUSAPI.Entites;
using MVCBUSAPI.Repositories.Abstract;

namespace MVCBUSAPI.Repositories.Concreate
{
    public class AppRoleRepo : BaseRepo<AppRole>, IAppRoleRepo
    {
        public AppRoleRepo(OtobüsDBContext db) : base(db)
        {
        }
    }
}
