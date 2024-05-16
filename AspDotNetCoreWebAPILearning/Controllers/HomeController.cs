using AspDotNetCoreWebAPILearning.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AspDotNetCoreWebAPILearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SchoolInfo _schoolInfo;
        private readonly CompanyInfo _companyInfo;

        public HomeController(
            IConfiguration configuration, 
            SchoolInfo schoolInfo,
            IOptions<CompanyInfo> companyInfo
            )
        {
            _configuration = configuration;
            _schoolInfo = schoolInfo;
            _companyInfo = companyInfo.Value;
        }

        [HttpGet]
        [Route("GetAppSettingKeyValue")]
        public IActionResult GetAppSettingKeyValue()
        {
            return Ok(_configuration["AppAuthorName"]);
        }
        
        [HttpGet]
        [Route("GetAppSettingObjectValues")]
        public IActionResult GetAppSettingObjectValues()
        {
            return Ok(_configuration["UserData:FullName"]);
        }
        
        [HttpGet]
        [Route("GetAppSettingValuesUsingModelBinding")]
        public IActionResult GetAppSettingValuesUsingModelBinding()
        {
            return Ok(_schoolInfo.Address!.State);
        }
        
        [HttpGet]
        [Route("GetAppSettingValuesUsingClassConfigure")]
        public IActionResult GetAppSettingValuesUsingClassConfigure()
        {
            return Ok(_companyInfo.AddressDetails!.State);
        }
    }
}
