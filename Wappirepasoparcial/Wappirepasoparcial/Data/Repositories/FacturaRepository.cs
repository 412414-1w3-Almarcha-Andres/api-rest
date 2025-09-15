using Wappirest.Data.Models;

namespace Wappirepasoparcial.Data.Repositories
{
    public class FacturaRepository : IFacuraRepository
    {
        private FacturaDbContext _dbContext;  //1º crear la variable de tipo contexto
        //ctor TAB TAB
        public FacturaRepository(FacturaDbContext dbContext)  //2º crear  
            {
            _dbContext = dbContext;  //3º asignar
        }

        public void Create(TPresupuesto presupuesto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TPresupuesto> GetAll()
        {
           return _dbContext.TPresupuestos.ToList();
        }

        public TPresupuesto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TPresupuesto presupuesto)
        {
            throw new NotImplementedException();
        }
    }
}
