using Microsoft.AspNetCore.Mvc;
using RateGun.Application.Models;
using RateGun.Application.Services;

namespace RateGun.Application.Controllers
{
    [Route("api")]
    public class RateGunController : ControllerBase
    {
        public IRateGunService _rateGunService { get; }

        public RateGunController(IRateGunService rateGunService)
        {
            _rateGunService = rateGunService;
        }

        #region HttpGet_Get
        [Route("getGun")]
        [HttpGet]
        public ActionResult<IEnumerable<GunDto>> GetAllGuns()
        {
            var rateGunsDtos = _rateGunService.GetAllGuns();

            return Ok(rateGunsDtos);
        }
        [Route("getGun")]
        [HttpGet("{id}")]
        public ActionResult<GunDto> GetGunById([FromRoute] Guid id)
        {
            var rateGun = _rateGunService.GetGunById(id);

            if (rateGun == null) return NotFound();

            return Ok(rateGun);
        }
        #endregion

        #region HttpPost_Create
        [Route("createGun")]
        [HttpPost]
        public ActionResult CreateGun([FromBody] CreateGunDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var id = _rateGunService.CreateGun(dto);

            return Created($"/api/rateGun/{id}", null);
        }
        [Route("createReview")]
        [HttpPost]
        public ActionResult CreateReview([FromBody] CreateReviewDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var id = _rateGunService.CreateReview(dto);

            return Created($"/api/createReview/{id}", null);
        }
        #endregion

        #region HttpPut_Modify
        [Route("modifyGun")]
        [HttpPut("{id}")] 
        public ActionResult ModifyGunById([FromRoute] Guid id, [FromBody] UpdateGunDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (!_rateGunService.ModifyGunById(id, dto)) return NotFound();
            var ret = _rateGunService.GetGunById(id);
            return Ok(ret);
        }
        #endregion

        #region HttpDelete_Delete
        [HttpDelete("{id}")]
        public ActionResult DeleteGun([FromRoute] Guid id)
        {
            if (!_rateGunService.DeleteGun(id)) return NotFound();

            return NoContent();
        }
        #endregion

    }
}



//GetAllGuns()
//GetGunsByCategory()
//GetGunsByBrand()
//GetAllBrands()
//GetAllCategories()
//GetReviewsForGun()

//DeleteGun()
//DeleteCategory()
//DeleteBrand()
//DeleteGunReview()

//AddGun()
//AddCategory()
//AddBrand()
//AddGunReview()

//UpdateGun()
//UpdateCategory()
//UpdateBrand()
//UpdateGunReview()