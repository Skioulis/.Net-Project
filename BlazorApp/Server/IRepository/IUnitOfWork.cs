using BlazorApp.Shared.Domain;

namespace BlazorApp.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save();
        IGenericRepository<Customer> Customers { get; }
    }
}
