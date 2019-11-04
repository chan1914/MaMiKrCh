using MaMiKrCh.Entities;
using AutoMapper;
using MaMiKrCh.Dtos;

namespace MaMiKrCh.Helpers
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<User, UserDto>();
			CreateMap<UserDto, User>();
		}
	}
}
