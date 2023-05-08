using AutoMapper;
using MMORPG.Game.Service.Application.UseCases.Abilitie.Requests;
using MMORPG.Game.Service.Application.UseCases.Item.Requests;
using MMORPG.Game.Service.Application.UseCases.Person.Commands;
using MMORPG.Game.Service.Application.UseCases.Person.Requests;
using MMORPG.Game.Service.Domain.Entities.Abilitie;
using MMORPG.Game.Service.Domain.Entities.Item;
using MMORPG.Game.Service.Domain.Entities.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Application.MapperConfiguration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Person, CreatePersonRequest>().ReverseMap();
            CreateMap<Abilitie, CreateAbilitieRequest>().ReverseMap();
            CreateMap<Item, CreateItemRequest>().ReverseMap();
            CreateMap<PersonItem, AppendItemPersonRequest>().ReverseMap();
            CreateMap<AbilitiesPerson, AppendAbilitiesPersonRequest>().ReverseMap();
            CreateMap<AbilitieItem, AppendAbilitieItemRequest>().ReverseMap();

        }
    }
}
