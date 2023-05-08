using MediatR;
using MMORPG.Game.Service.Application.UseCases.Base.Responses.Base;

namespace MMORPG.Game.Service.Application.UseCases.Person.Requests
{
    public class CreatePersonRequest : IRequest<ApiResponse>
    {
        public string Name { get; set; }
        public int Years { get; set; }
        public int Kills { get; set; }
        //public List<AbilitiesPerson> AbilitiesPerson { get; set; }
        //public List<PersonItem> PersonItems { get; set; }
    }
}
