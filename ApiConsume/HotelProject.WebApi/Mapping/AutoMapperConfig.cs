using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile //Dto ve Entiyleri bağladığımız sınıf
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap(); //ReverseMap ile tersinde de Mapleme işlemi gerçekleşir.
            //Mapleme işlemi ile,Dto sınıfındaki propertylerle entity sınıfında ki propertyler birbirleriyle eşleşmiş olur.
        }
    }
}
