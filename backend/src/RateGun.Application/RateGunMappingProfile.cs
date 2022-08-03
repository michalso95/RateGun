using AutoMapper;
using RateGun.Infrastructure;
using RateGun.Application.Models;

namespace RateGun.Application
{
    public class RateGunMappingProfile : Profile
    {
        public RateGunMappingProfile()
        {
            CreateMap<Gun, GunDto>()
                .ForMember(m => m.ManufacturerName, c => c.MapFrom(s => s.Manufacturer.Name))
                .ForMember(m => m.GunPlantsNames, c => c.MapFrom(s => s.GunPlant.Name))
                .ForMember(m => m.MagazineCapacities, c => c.MapFrom(s => s.MagazineCapacity.Capacity))
                .ForMember(m => m.BulletCals, c => c.MapFrom(s => s.BulletCal.Name));

            CreateMap<UpdateGunDto, Gun>()
                .ForMember(r => r.Manufacturer.Name, c => c.MapFrom(p => p.ManufacturerName))
                .ForMember(r => r.GunPlant.Name, c => c.MapFrom(p => p.GunPlantName))
                .ForMember(r => r.MagazineCapacity.Capacity, c => c.MapFrom(p => p.MagazineCapacities))
                .ForMember(r => r.BulletCal.Name, c => c.MapFrom(p => p.BulletCals));

            CreateMap<CreateGunDto, Gun>()
                .ForMember(r => r.Manufacturer.Name, c => c.MapFrom(p => p.ManufacturerName))
                .ForMember(r => r.GunPlant.Name, c => c.MapFrom(p => p.GunPlantName))
                .ForMember(r => r.MagazineCapacity.Capacity, c => c.MapFrom(p => p.MagazineCapacities))
                .ForMember(r => r.BulletCal.Name, c => c.MapFrom(p => p.BulletCals));

            CreateMap<CreateReviewDto, Review>()
                .ForMember(r => r.User.Id, c => c.MapFrom(p => p.UserId))
                .ForMember(r => r.Gun.Id, c => c.MapFrom(p => p.GunId));

            CreateMap<Review, ReviewDto>()
                .ForMember(m => m.UserName, c => c.MapFrom(s => s.User.Name))
                .ForMember(m => m.GunName, c => c.MapFrom(s => s.Gun.Model));
        }
    }
}
