using Homex.Domain.Shelves.Models;

namespace Homex.Domain.Shelves.Factories
{
    public class ShelfFactory : IShelfFactory
    {
        private string _shelfName = default!;
        private int _shelfRowsCount = default!;

        public IShelfFactory WithName(string name)
        {
            _shelfName = name;
            return this;
        }

        public IShelfFactory WithRowsCount(int rowsCount)
        {
            _shelfRowsCount = rowsCount;
            return this;
        }

        public Shelf Build()
            => new Shelf(_shelfName, _shelfRowsCount);
    }
}
