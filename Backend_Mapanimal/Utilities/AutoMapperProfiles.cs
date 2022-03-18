using AutoMapper;
using Backend_Mapanimal.Dtos;
using Backend_Mapanimal.Entities;

namespace Backend_Mapanimal.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Pet, PetDTO>().ReverseMap();

            CreateMap<CreatePetDTO, Pet>();
        }
    }
}

