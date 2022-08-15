using Core.Persistence.Repositories;
using Domain.Entities;
using Persistance.Context;

namespace Persistance.Repositories;

public class BrandRepository : EfRepositoryBase<Brand, BaseDbContext>, IBrandRepository
{
    public BrandRepository(BaseDbContext context) : base(context)
    {
    }
}
