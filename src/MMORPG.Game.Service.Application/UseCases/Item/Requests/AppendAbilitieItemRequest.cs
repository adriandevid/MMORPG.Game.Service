using MediatR;
using MMORPG.Game.Service.Application.UseCases.Base.Responses.Base;

namespace MMORPG.Game.Service.Application.UseCases.Item.Requests
{
    public class AppendAbilitieItemRequest : IRequest<ApiResponse>
    {
        public int ItemId { get; set; }
        public int AbilitieId { get; set; }
    }
}
