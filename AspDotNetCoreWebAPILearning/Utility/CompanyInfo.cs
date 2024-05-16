using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCoreWebAPILearning.Utility
{
    public class CompanyInfo
    {
        public string? CompanyName { get; set; }
        public AddressDetails? AddressDetails { get; set; }
    }
   

    public class AddressDetails
    {
        public string? City { get; set; }
        public string? State { get; set; }
        public int PinCode { get; set; }
    }
}
