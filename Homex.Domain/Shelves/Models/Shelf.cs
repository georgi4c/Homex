using System;
using System.Collections.Generic;
using Homex.Domain.Common;
using Homex.Domain.Common.Models;
using Homex.Domain.Shelves.Exceptions;

namespace Homex.Domain.Shelves.Models
{
    public class Shelf : Entity<int>, IAggregateRoot
    {
        public Shelf(string name, int rowsCount)
        {
            Validate(name, rowsCount);

            Name = name;
            RowsCount = rowsCount;
            Boxes = new HashSet<Box>();
        }

        public string Name { get; set; }

        public int RowsCount { get; set; }

        public HashSet<Box> Boxes { get; set; }
        
        private void Validate(string name, int rowsCount)
        {
            ValidateName(name);
            ValidateRowsCount(rowsCount);
        }

        private void ValidateName(string name)
            => Guard.ForStringLength<InvalidShelfException>(
                name,
                ModelConstants.Common.MinNameLength,
                ModelConstants.Common.MaxNameLength,
                nameof(Name));

        private void ValidateRowsCount(int rowsCount)
            => Guard.AgainstOutOfRange<InvalidShelfException>(
                rowsCount,
                ModelConstants.Shelf.MinRowsCount,
                ModelConstants.Shelf.MaxRowsCount,
                nameof(RowsCount));

    }
}
