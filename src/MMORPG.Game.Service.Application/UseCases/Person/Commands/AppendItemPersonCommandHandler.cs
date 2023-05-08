using AutoMapper;
using MediatR;
using MMORPG.Game.Service.Application.UseCases.Base.Commands;
using MMORPG.Game.Service.Application.UseCases.Base.Responses.Base;
using MMORPG.Game.Service.Application.UseCases.Person.Requests;
using MMORPG.Game.Service.Domain.Entities.Person;
using MMORPG.Game.Service.Domain.Interfaces.Repositories;

namespace MMORPG.Game.Service.Application.UseCases.Person.Commands
{
    public class AppendItemPersonCommandHandler : CommandHandler, IRequestHandler<AppendItemPersonRequest, ApiResponse>
    {
        private readonly IPersonRepository _repository;
        private readonly IMapper _mapper;

        public AppendItemPersonCommandHandler(IPersonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> Handle(AppendItemPersonRequest request, CancellationToken cancellationToken)
        {
            var person = await _repository.GetPersonByIdWithIncludes(request.PersonId);
            person.AppendIem(_mapper.Map<PersonItem>(request));

            _repository.Update(person);

            return await PersistDataAsync(_repository.UnitOfWork, () => { });
        }
    }
}
