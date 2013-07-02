using AutoMapper;
using Models;

namespace AutoMapperSpike
{
    public static class MapperBootStrap
    {
         public static void Initialize()
         {
             Mapper.CreateMap<Order, OrderDto>();
             
             
             Mapper.AssertConfigurationIsValid();
         }

        public static void InitilaizeIgnore()
        {
            Mapper.CreateMap<Order, OrderDto>()
  	        .ForMember(dest => dest.Total, opt => opt.Ignore());
        }

        public static void InitializeWithOptions()
        {
            Mapper.CreateMap<Order, OrderDto>()
                  .ForMember(dest => dest.CustomerNumber, opt => opt.MapFrom(src => src.CustomerId))
                  .ForMember(dest => dest.OrderDay, opt => opt.MapFrom(src => src.OrderDate.Day))
                  ;
        }
    }
}