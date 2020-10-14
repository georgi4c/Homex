using System.Threading;
using System.Threading.Tasks;
using Homex.Application.Shelves.Commands.Common;
using Homex.Domain.Shelves.Factories;
using Homex.Domain.Shelves.Repositories;
using MediatR;

namespace Homex.Application.Shelves.Commands.Create
{
    public class CreateShelfCommand : ShelfCommand<CreateShelfCommand>, IRequest<CreateShelfOutputModel>
    {
        public class CreateShelfCommandHandler : IRequestHandler<CreateShelfCommand, CreateShelfOutputModel>
        {
            private readonly IShelfFactory _shelfFactory;
            private readonly IShelfRepository _shelfRepository;

            public CreateShelfCommandHandler(IShelfFactory shelfFactory, IShelfRepository shelfRepository)
            {
                _shelfFactory = shelfFactory;
                _shelfRepository = shelfRepository;
            }

            public async Task<CreateShelfOutputModel> Handle(CreateShelfCommand request, CancellationToken cancellationToken)
            {
                var shelf = _shelfFactory
                    .WithName(request.Name)
                    .WithRowsCount(request.RowsCount)
                    .Build();

                await _shelfRepository.Save(shelf, cancellationToken);

                return new CreateShelfOutputModel(shelf.Id);
            }
        }
    }
}
