using Wappirest.Data.Models;

namespace Wappirepasoparcial.Data.Repositories
{
    public interface IFacuraRepository
    {
        void Create(TPresupuesto presupuesto );

        void Update(TPresupuesto presupuesto);
        void Delete(int id);
        TPresupuesto GetById(int id);
        List<TPresupuesto> GetAll();

    }
}
