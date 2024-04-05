using BlazorApp.Server.Data;
using BlazorApp.Server.IRepository;
using BlazorApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Customer> _customers;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Customer> Customers => _customers ??= new GenericRepository<Customer>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
