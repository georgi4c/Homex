using Homex.Domain.Common;

namespace Homex.Domain.Shelves.Exceptions
{
    public class InvalidShelfException : BaseDomainException
    {
        public InvalidShelfException()
        {
            
        }

        public InvalidShelfException(string error) => this.Error = error;
    }
}
