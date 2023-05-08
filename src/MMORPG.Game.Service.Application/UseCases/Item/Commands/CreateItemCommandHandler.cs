using AutoMapper;
using MediatR;
using MMORPG.Game.Service.Application.UseCases.Base.Commands;
using MMORPG.Game.Service.Application.UseCases.Base.Responses.Base;
using MMORPG.Game.Service.Application.UseCases.Item.Requests;
using MMORPG.Game.Service.Domain.Interfaces.Repositories;
using ItemEntity = MMORPG.Game.Service.Domain.Entities.Item.Item;

namespace MMORPG.Game.Service.Application.UseCases.Item.Commands
{
    public class CreateItemCommandHandler : CommandHandler, IRequestHandler<CreateItemRequest, ApiResponse>
    {
        private readonly IItemRepository _repository;
        private readonly IMapper _mapper;

        public CreateItemCommandHandler(IItemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ApiResponse> Handle(CreateItemRequest request, CancellationToken cancellationToken)
        {
            var item = _mapper.Map<ItemEntity>(request);
            _repository.Append(item);
            return await PersistDataAsync(_repository.UnitOfWork, () => { item.CreatedNewItemEvent();  });
        }
    }
}
