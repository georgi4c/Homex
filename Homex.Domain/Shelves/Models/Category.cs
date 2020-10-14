using Homex.Domain.Common.Models;
using Homex.Domain.Shelves.Exceptions;
using static Homex.Domain.Common.Models.ModelConstants.Common;
using static Homex.Domain.Common.Models.ModelConstants.Category;

namespace Homex.Domain.Shelves.Models
{
    public class Category : Entity<int>
    {
        internal Category(string name, string description)
        {
            this.Validate(name, description);

            this.Name = name;
            this.Description = description;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        private void Validate(string name, string description)
        {
            Guard.ForStringLength<InvalidShelfException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));

            Guard.ForStringLength<InvalidShelfException>(
                description,
                MinDescriptionLength,
                MaxDescriptionLength,
                nameof(this.Description));
        }
    }
}
