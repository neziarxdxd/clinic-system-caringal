﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicV2
{
    public class Services
    {
        public int quantity { get; set; }
        public string nameOfService { get; set; }
        public double price { get; set; }
        public double total { get; set; }


        public string serviceNameDoctorEden { get; set; }
        public string quantityDoctorEden { get; set; }
        public string totalDoctorEden { get; set; }

        public string serviceNameDoctorEmm { get; set; }
        public string quantityDoctorEmm { get; set; }
        public string totalDoctorEmm { get; set; }

        public string serviceNameLab { get; set; }
        public string quantityLab { get; set; }
        public string totalLab { get; set; }

        public string serviceNameService { get; set; }
        public string quantityService { get; set; }
        public string totalService { get; set; }

        public string serviceNameMedicine { get; set; }
        public string quantityMedicine { get; set; }
        public string totalMedicine { get; set; }

        public string serviceNameGrand { get; set; }
        public string quantityGrand { get; set; }
        public string totalGrand { get; set; }

    }
}
