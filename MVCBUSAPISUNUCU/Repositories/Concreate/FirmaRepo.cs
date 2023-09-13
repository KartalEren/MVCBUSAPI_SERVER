using MVCBUSAPI.Data;
using MVCBUSAPI.Entites;
using MVCBUSAPI.Repositories.Abstract;

namespace MVCBUSAPI.Repositories.Concreate
{
    public class FirmaRepo : BaseRepo<Firma>, IFirmaRepo
    {
        public FirmaRepo(OtobüsDBContext db) : base(db)
        {
        }
    }
}
