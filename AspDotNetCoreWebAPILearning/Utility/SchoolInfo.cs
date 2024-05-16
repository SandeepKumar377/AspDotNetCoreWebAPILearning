using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCoreWebAPILearning.Utility
{
    public class SchoolInfo
    {
        public string? SchoolName { get; set; }
        public Address? Address { get; set; }
    }

    public class Address
    {
        public string? City { get; set; }
        public string? State { get; set; }
        public int PinCode { get; set; }
    }
}
