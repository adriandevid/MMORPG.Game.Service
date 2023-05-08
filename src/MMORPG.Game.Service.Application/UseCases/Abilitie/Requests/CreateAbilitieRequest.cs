

using MediatR;
using MMORPG.Game.Service.Application.UseCases.Base.Responses.Base;

namespace MMORPG.Game.Service.Application.UseCases.Abilitie.Requests
{
    public class CreateAbilitieRequest : IRequest<ApiResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Command { get; set; }
    }
}
