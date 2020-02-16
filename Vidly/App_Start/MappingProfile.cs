using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Models;
using Vidly.Dtos;


namespace Vidly.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, Customer_Dto>();
            Mapper.CreateMap<Customer_Dto, Customer>();
                                 
            Mapper.CreateMap<Movie, MoviesDto>();
            Mapper.CreateMap<MoviesDto, Movie>();
                
            Mapper.CreateMap<MembershipTypeDto, MembershipType>();           
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            Mapper.CreateMap<GenreDto, Genre>();
            Mapper.CreateMap<Genre, GenreDto>();


        }
    }
}