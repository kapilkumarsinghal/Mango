using Mango.web.Models;
using Mango.web.Service.IService;
using Mango.web.Utility;
using Mango.Web.Models;
using static Mango.web.Utility.StaticDetails;

namespace Mango.web.Service
{
    public class CouponService: ICouponService
    {
        private readonly IBaseService _baseService;
        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.POST,
                Data = couponDto,
                Url = StaticDetails.CouponApIBase + "api/CouponAPI/AddCoupon"
            });
        }

        public async Task<ResponseDto?> DeleteCouponsAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.DELETE,
                Url = StaticDetails.CouponApIBase + "api/CouponAPI/Remove/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCouponsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.GET,
                Url = StaticDetails.CouponApIBase + "api/CouponAPI"
            });

        }

        public async Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.GET,
                Url = StaticDetails.CouponApIBase + "api/CouponAPI/GetByCode" + couponCode
            });
        }

        public async Task<ResponseDto?> GetCouponsByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.GET,
                Url = StaticDetails.CouponApIBase + "api/CouponAPI/" + id
            });
        }

        public async Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.PUT,
                Data = couponDto,
                Url = StaticDetails.CouponApIBase + "api/CouponAPI/UpdateCoupon"
            });
        }
    }
}
