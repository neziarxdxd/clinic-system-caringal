using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicV2
{
    class DoctorEden
    {
       
        public string serviceNameDoctorEden { get; set; }
        public string quantityDoctorEden { get; set; }
        public string totalDoctorEden { get; set; }
                
    }

    class DoctorEmm {
        public string serviceNameDoctorEmm { get; set; }
        public string quantityDoctorEmm { get; set; }
        public string totalDoctorEmm { get; set; }

        

       
    }

    class Lab {
        public string serviceNameLab { get; set; }
        public string quantityLab { get; set; }
        public string totalLab { get; set; }
    
    }

    class ServiceName {
        public string serviceNameService { get; set; }
        public string quantityService { get; set; }
        public string totalService { get; set; }
    }



    class Medicine {
        public string serviceNameMedicine { get; set; }
        public string quantityMedicine { get; set; }
        public string totalMedicine { get; set; }   
    }

    class GrandTotal {
        public string serviceNameGrand { get; set; }
        public string quantityGrand { get; set; }
        public string totalGrand { get; set; }
    }
}
