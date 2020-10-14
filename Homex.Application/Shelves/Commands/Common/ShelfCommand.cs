using Homex.Application.Common;

namespace Homex.Application.Shelves.Commands.Common
{
    public class ShelfCommand<TCommand> : EntityCommand<int>
        where TCommand : EntityCommand<int>
    {
        public string Name { get; set; } = default!;

        public int RowsCount { get; set; }
    }
}
