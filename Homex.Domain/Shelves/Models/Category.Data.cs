using System;
using System.Collections.Generic;
using Homex.Domain.Common;

namespace Homex.Domain.Shelves.Models
{
    public class CategoryData : IInitialData
    {
        public Type EntityType => typeof(Category);

        public IEnumerable<object> GetData()
            => new List<Category>
            {
                new Category("Tool", "Tool category description"),
                new Category("Souvenir", "Souvenir category description"),
                new Category("Alcohol", "Alcohol category description"),
                new Category("Food", "Food category description"),
                new Category("Other", "Other category description"),
            };
    }
}
