﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialView.Models
{
    public enum CountryType
    {
        Coast,
        Wallonia
    }
    public class Hotel
    {
            public int Id { get; set; }
            public string NameHotel { get; set; }
            public string City { get; set; }
            public int Stars { get; set; }
            public double Score { get; set; }
            public string Benefit { get; set; }
            public string Photo { get; set; }
            public CountryType Country { get; set; }
        
    }
}
