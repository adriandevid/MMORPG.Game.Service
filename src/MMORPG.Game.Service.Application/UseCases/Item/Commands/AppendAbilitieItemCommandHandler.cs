using AutoMapper;
using MediatR;
using MMORPG.Game.Service.Application.UseCases.Base.Commands;
using MMORPG.Game.Service.Application.UseCases.Base.Responses.Base;
using MMORPG.Game.Service.Application.UseCases.Item.Requests;
using MMORPG.Game.Service.Domain.Entities.Item;
using MMORPG.Game.Service.Domain.Interfaces.Repositories;

namespace MMORPG.Game.Service.Application.UseCases.Item.Commands
{
    public class AppendAbilitieItemCommandHandler : CommandHandler, IRequestHandler<AppendAbilitieItemRequest, ApiResponse>
    {
        private readonly IItemRepository _repository;
        private readonly IMapper _mapper;

        public AppendAbilitieItemCommandHandler(IItemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> Handle(AppendAbilitieItemRequest request, CancellationToken cancellationToken)
        {
            var item = await _repository.GetItemByIdWithIncludes(request.ItemId);
            var abilitie = _mapper.Map<AbilitieItem>(request);

            item.AppendAbilitie(abilitie);

            _repository.Update(item);

            return await PersistDataAsync(_repository.UnitOfWork, () => { item.CreateEventAppendNewAbilitie(abilitie); });
        }
    }
}
