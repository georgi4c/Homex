﻿using System.Threading;
using System.Threading.Tasks;

namespace Homex.Domain.Common
{
    public interface IDomainRepository<in TEntity>
        where TEntity : IAggregateRoot
    {
        Task Save(TEntity entity, CancellationToken cancellationToken = default);
    }
}
