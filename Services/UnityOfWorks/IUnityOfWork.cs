using ApPets.Common;
using System;
using System.Threading.Tasks;
using ApPets.Data;

namespace ApPets.Services
{
    public interface IUnitOfWork
    {
        int Complete();
        Task<int> CompleteAsync();
    }

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        protected ApplicationDbContext DbContext { get; }

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public int Complete()
        {
            return DbContext.SaveChanges();
        }

        public Task<int> CompleteAsync()
        {
            return Task.Factory.StartNew(Complete);
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    DbContext.Dispose();
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

    public interface IUOWVeterinaries : IUnitOfWork
    {
        IVetServicesRepository VetServices { get; set; }
        IPetTypeRepository PetTypes { get; set; }
        IPetRepository Pets { get; set; }
        IVeterinaryRepository Veterinaries { get; set; }
        IPaisRepository Pais { get; set; }
    }

    public class UOWVeterinaries : UnitOfWork, IUOWVeterinaries
    {
        public IVetServicesRepository VetServices { get; set; }
        public IPetTypeRepository PetTypes { get; set; }
        public IPetRepository Pets { get; set; }
        public IVeterinaryRepository Veterinaries { get; set; }
        public IPaisRepository Pais { get; set; }

        public UOWVeterinaries(ApplicationDbContext context) : base(context)
        {
            PetTypes = new PetTypeRepository(DbContext);
            Veterinaries = new VeterinaryRepository(DbContext);
            Pets = new PetRepository(DbContext);
            VetServices = new VetServicesRepository(DbContext);
            Pais = new PaisRepository(DbContext);
        }
    }
}
