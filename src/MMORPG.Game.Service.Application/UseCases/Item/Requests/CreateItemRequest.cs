using MediatR;
using MMORPG.Game.Service.Application.UseCases.Base.Responses.Base;

namespace MMORPG.Game.Service.Application.UseCases.Item.Requests
{
    public class CreateItemRequest : IRequest<ApiResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Damage { get; set; }
    }
}
