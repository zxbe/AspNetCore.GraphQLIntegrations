﻿using System;

namespace AspNetCore.WebApi
{
    public class Customer
    {
        public long id { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public decimal Balance { get; set; }
        public DateTime createTime { get; set; }
        public string IsDel { get; set; }
    }
}
