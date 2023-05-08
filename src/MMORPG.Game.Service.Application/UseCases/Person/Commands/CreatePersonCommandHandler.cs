using AutoMapper;
using MediatR;
using MMORPG.Game.Service.Application.UseCases.Base.Commands;
using MMORPG.Game.Service.Application.UseCases.Base.Responses.Base;
using MMORPG.Game.Service.Application.UseCases.Person.Requests;
using EntityPerson = MMORPG.Game.Service.Domain.Entities.Person.Person;
using MMORPG.Game.Service.Domain.Interfaces.Repositories;

namespace MMORPG.Game.Service.Application.UseCases.Person.Commands
{
    public class CreatePersonCommandHandler : CommandHandler, IRequestHandler<CreatePersonRequest, ApiResponse>
    {
        private readonly IPersonRepository _repository;
        private readonly IMapper _mapper;

        public CreatePersonCommandHandler(IPersonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> Handle(CreatePersonRequest request, CancellationToken cancellationToken)
        {
            var requestFormated = _mapper.Map<EntityPerson>(request);
            _repository.Append(requestFormated);

            return await PersistDataAsync(_repository.UnitOfWork, () => { requestFormated.CreatePersonEvent(); });
        }
    }
}
