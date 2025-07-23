﻿using System.ComponentModel.DataAnnotations;

namespace Mango.Services.CouponAPI.Model
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        [Required]
        public string CouponCode { get; set; }
        [Required]
        public double DiscountAmout { get; set; }
        public int MinAmount { get; set; }
    }
}
