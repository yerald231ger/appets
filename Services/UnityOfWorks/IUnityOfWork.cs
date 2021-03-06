﻿using ApPets.Common;
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

    public class UOWVeterinaries : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;

        public IVetServicesRepository VetServices { get; set; }
        public IPetTypeRepository PetTypes { get; set; }
        public IPetRepository Pets { get; set; }
        public IVeterinaryRepository Veterinaries { get; set; }

        public UOWVeterinaries(ApplicationDbContext context)
        {
            _context = context;
            PetTypes = new PetTypeRepository(context);
            Veterinaries = new VeterinaryRepository(context);
            Pets = new PetRepository(context);
            VetServices = new VetServicesRepository(context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
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
