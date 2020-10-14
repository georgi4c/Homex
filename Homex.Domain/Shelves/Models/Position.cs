using Homex.Domain.Common.Models;

namespace Homex.Domain.Shelves.Models
{
    public class Position : ValueObject
    {
        internal Position(char row, int column)
        {
            Row = row;
            Column = column;
        }

        public char Row { get; set; }

        public int Column { get; set; }
    }
}
