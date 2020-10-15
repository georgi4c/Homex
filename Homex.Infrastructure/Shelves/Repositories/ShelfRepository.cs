using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Homex.Domain.Shelves.Models;
using Homex.Domain.Shelves.Repositories;
using Homex.Infrastructure.Common.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Homex.Infrastructure.Shelves.Repositories
{
    internal class ShelfRepository : DataRepository<HomexDbContext, Shelf>, IShelfRepository
    {
        private readonly IMapper _mapper;

        public ShelfRepository(HomexDbContext db, IMapper mapper) 
            : base(db)
        {
            _mapper = mapper;
        }

        public async Task<Shelf> Find(int id, CancellationToken cancellationToken = default)
            => await this
                .All()
                .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
            

    }
}
