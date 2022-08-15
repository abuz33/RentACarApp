using Core.Persistence.Repositories;
using Domain.Entities;

namespace Persistance.Repositories;

public interface IBrandRepository : IAsyncRepository<Brand>, IRepository<Brand>
{
}
