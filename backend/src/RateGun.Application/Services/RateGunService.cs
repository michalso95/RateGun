using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RateGun.Infrastructure;
using RateGun.Application.Models;

namespace RateGun.Application.Services
{
    public interface IRateGunService
    {
        GunDto GetGunById(Guid id);
        IEnumerable<GunDto> GetAllGuns();

        Guid CreateGun(CreateGunDto dto);
        Guid CreateReview(CreateReviewDto dto);

        bool ModifyGunById(Guid id, UpdateGunDto dto);

        bool DeleteGun(Guid id);

        //GetAllGuns()              ok
        //GetGunsByCategory()
        //GetGunsByBrand()
        //GetAllBrands()
        //GetAllCategories()
        //GetReviewsForGun()

        //AddGun()                  ok
        //AddCategory()
        //AddBrand()
        //AddGunReview()            ok

        //UpdateGun()               ok
        //UpdateCategory()
        //UpdateBrand()
        //UpdateGunReview()

        //DeleteGun()               ok
        //DeleteCategory()
        //DeleteBrand()
        //DeleteGunReview()
    }

    public class RateGunService : IRateGunService
    {
        private readonly RateGunDBContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<RateGunService> _logger;

        public RateGunService(RateGunDBContext dbContext, IMapper mapper, ILogger<RateGunService> logger)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _logger = logger;
        }

        #region Get
        public GunDto GetGunById(Guid id)
        {
            _logger.LogTrace($"GetById() : Client asked about RateGun with id {id}.");

            var gun = _dbContext
                .Guns
                .Include(r => r.GunPlant)
                .Include(r => r.Manufacturer)
                .FirstOrDefault(r => r.Id == id);

            if (gun is null) return null;

            var result = _mapper.Map<GunDto>(gun);
            return result;
        }
        public IEnumerable<GunDto> GetAllGuns()
        {
            var gun = _dbContext
                .Guns
                .Include(r => r.GunPlant)
                .Include(r => r.Manufacturer)
                .ToList();

            var gunsDtos = _mapper.Map<List<GunDto>>(gun);

            _logger.LogTrace($"GetAll() : All {gunsDtos.Count} Guns listed.");

            return gunsDtos;
        }
        #endregion

        #region Create
        public Guid CreateGun(CreateGunDto dto)
        {
            var gun = _mapper.Map<Gun>(dto);
            _dbContext.Guns.Add(gun);
            _dbContext.SaveChanges();
            _logger.LogInformation($"Create() : New Gun with id {gun.Id} created in database.");
            return gun.Id;
        }
        public Guid CreateReview(CreateReviewDto dto)
        {
            var review = _mapper.Map<Review>(dto);
            _dbContext.Reviews.Add(review);
            _dbContext.SaveChanges();
            _logger.LogInformation($"Create() : New Review with id {review.Id} created in database.");
            return review.Id;
        }
        #endregion

        #region Modify
        public bool ModifyGunById(Guid id, UpdateGunDto dto)
        {
            _logger.LogInformation($"ModifyById() : Gun with id {id} modified.");
            var gun = _dbContext.Guns
                .FirstOrDefault(r => r.Id == id);

            if (gun is null) return false;

            gun.Model = String.IsNullOrEmpty(dto.Model) ? gun.Model : dto.Model;
            gun.Version = String.IsNullOrEmpty(dto.Version) ? gun.Version : dto.Version;
            gun.Type = String.IsNullOrEmpty(dto.Type) ? gun.Type : dto.Type;
            gun.Manufacturer.Name = String.IsNullOrEmpty(dto.ManufacturerName) ? gun.Manufacturer.Name : dto.ManufacturerName;
            gun.GunPlant.Name = String.IsNullOrEmpty(dto.GunPlantName) ? gun.GunPlant.Name : dto.GunPlantName;
            gun.ProductionBegin = dto.ProductionBegin==0 ? gun.ProductionBegin : dto.ProductionBegin;
            gun.ProductionFinish = dto.ProductionFinish==0 ? gun.ProductionFinish : dto.ProductionFinish;
            //gun.Version = String.IsNullOrEmpty(dto.Version) ? gun.Version : dto.Version;
            //gun.Version = String.IsNullOrEmpty(dto.Version) ? gun.Version : dto.Version;
            gun.DescrGeneral = String.IsNullOrEmpty(dto.DescrGeneral) ? gun.DescrGeneral : dto.DescrGeneral;
            gun.DescrTech = String.IsNullOrEmpty(dto.DescrTech) ? gun.DescrTech : dto.DescrTech;
            gun.DescrCuriosities = String.IsNullOrEmpty(dto.DescrCuriosities) ? gun.DescrCuriosities : dto.DescrCuriosities;
            gun.DescrHistory = String.IsNullOrEmpty(dto.DescrHistory) ? gun.DescrHistory : dto.DescrHistory;
            gun.Bibliography = String.IsNullOrEmpty(dto.Bibliography) ? gun.Bibliography : dto.Bibliography;
            
            _dbContext.SaveChanges();

            return true;
        }
        #endregion

        #region Delete
        public bool DeleteGun(Guid id)
        {
            _logger.LogWarning($"Delete() : Gun with id: {id} DELETE action invoked");
            var gun = _dbContext
                .Guns
                .FirstOrDefault(r => r.Id == id);
            if (gun is null) return false;

            _dbContext.Remove(gun);
            _dbContext.SaveChanges();

            return true;
        }
        #endregion

    }
}
