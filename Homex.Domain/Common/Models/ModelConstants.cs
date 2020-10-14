namespace Homex.Domain.Common.Models
{
    public class ModelConstants
    {
        public class Common
        {
            public const int MinNameLength = 2;
            public const int MaxNameLength = 30;
            public const int MaxUrlLength = 2048;
            public const int Zero = 0;
        }

        public class Shelf
        {
            public const int MinRowsCount = 1;
            public const int MaxRowsCount = 100;
        }

        public class Category
        {
            public const int MinDescriptionLength = 20;
            public const int MaxDescriptionLength = 1000;
        }
    }
}
