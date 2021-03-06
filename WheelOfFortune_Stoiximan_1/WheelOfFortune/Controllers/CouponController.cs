﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelOfFortune.Models;

namespace WheelOfFortune.Controllers
{
    public class CouponController : Controller
    {
        private ICouponsRepository repository;

        public CouponController(ICouponsRepository repo)
        {
            repository = repo;
        }

        [Authorize(Roles = "User")]
        public ActionResult GetCoupon()
        {
            return RedirectToAction("GetCoupon", "AdminCoupons");
        }

        [Authorize]
        public ViewResult CouponList() => View(repository.Coupons);
        //public ActionResult GetCoupon()
        //{
        //    return RedirectToAction("GetCoupon", "AdminCoupons");
        //}
    }
}
