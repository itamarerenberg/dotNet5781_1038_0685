﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class bus
    {
        public string LicenseNum { get; set; }
        public DateTime LicenesDate { get; set; }
        public float Kilometraz { get; set; }
        public float Fule { get; set; }
        public BusStatusEnum Stat { get; set; }
    }
}