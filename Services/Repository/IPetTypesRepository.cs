using ApPets.Data;
using ApPets.Common;
using System;

namespace ApPets.Services
{
    public interface IPetTypeRepository : IRepository<PetType, int>
    {
    }

    public class PetTypeRepository : Repository<PetType, int>, IPetTypeRepository, IDisposable
    {

        public PetTypeRepository(ApplicationDbContext context) : base(context)
        {
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }        
    }
}
