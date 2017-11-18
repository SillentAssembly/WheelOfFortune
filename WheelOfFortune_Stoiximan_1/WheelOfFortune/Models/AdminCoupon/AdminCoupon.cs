﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WheelOfFortune.Models
{
    public class AdminCoupon
    {
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public int ID { get; set; }
        private static string Code1;
        public static string Code
        {
            get { return Code1 ?? Guid.NewGuid().ToString("N").Substring(0, 6); }

            set { Code1 = value; } } 

        public int? Value { get; set; } 

        private DateTime? creationDate;
        public DateTime CreationDate
        {
            get { return creationDate ?? DateTime.Now; }
            set {creationDate = value; }
        }
        private string status;
        public string Status {
            get { return status ?? "Active"; }
            set { status = value; }
        }  
    }
}