using System.ComponentModel.DataAnnotations;
using AutoMapper;
using MovieRental.Models;

namespace MovieRental.Dtos
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerDto, Customer>();
            CreateMap<CustomerDto,Customer>();
        }

    }
}