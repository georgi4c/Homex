using Homex.Domain.Common;
using Homex.Domain.Shelves.Models;

namespace Homex.Domain.Shelves.Factories
{
    public interface IShelfFactory : IFactory<Shelf>
    {
        IShelfFactory WithName(string name);

        IShelfFactory WithRowsCount(int rowsCount);
    }
}
