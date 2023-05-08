using AutoMapper;
using MediatR;
using MMORPG.Game.Service.Application.UseCases.Abilitie.Requests;
using MMORPG.Game.Service.Application.UseCases.Base.Commands;
using MMORPG.Game.Service.Application.UseCases.Base.Responses.Base;
using AbilitieEntity = MMORPG.Game.Service.Domain.Entities.Abilitie.Abilitie;
using MMORPG.Game.Service.Domain.Interfaces.Repositories;

namespace MMORPG.Game.Service.Application.UseCases.Abilitie.Commands
{
    public class CreateAbilitieCommandHandler : CommandHandler, IRequestHandler<CreateAbilitieRequest, ApiResponse>
    {
        private readonly IAbiliteRepository _repository;
        private readonly IMapper _mapper;

        public CreateAbilitieCommandHandler(IAbiliteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> Handle(CreateAbilitieRequest request, CancellationToken cancellationToken)
        {
            var requestFormated = _mapper.Map<AbilitieEntity>(request);
            _repository.Append(requestFormated);

            return await PersistDataAsync(_repository.UnitOfWork, () => { requestFormated.CreateEventNewAbilite(); });
        }
    }
}
