using System.Threading;
using System.Threading.Tasks;
using Homex.Domain.Common;
using Homex.Domain.Shelves.Models;

namespace Homex.Domain.Shelves.Repositories
{
    public interface IShelfRepository : IDomainRepository<Shelf>
    {
        Task<Shelf> Find(int id, CancellationToken cancellationToken = default);
    }
}
