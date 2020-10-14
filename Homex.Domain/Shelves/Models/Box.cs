using Homex.Domain.Common.Models;

namespace Homex.Domain.Shelves.Models
{
    public class Box : Entity<int>
    {
        public Box(string name, Position position)
        {
            // Validate
            Name = name;
            Position = position;
        }

        public string Name { get; set; }

        public Position Position { get; set; }
    }
}
