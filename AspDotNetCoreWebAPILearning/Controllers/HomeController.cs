using AspDotNetCoreWebAPILearning.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCoreWebAPILearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SchoolInfo _schoolInfo;

        public HomeController(IConfiguration configuration, SchoolInfo schoolInfo)
        {
            _configuration = configuration;
            _schoolInfo = schoolInfo;
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
    }
}
