using MediatR;
using MMORPG.Game.Service.Application.UseCases.Base.Responses.Base;

namespace MMORPG.Game.Service.Application.UseCases.Person.Requests
{
    public class AppendAbilitiesPersonRequest : IRequest<ApiResponse>
    {
        public int PersonId { get; set; }
        public int AbilitieId { get; set; }
    }
}
