using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Services;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCors")]
    public class TestController : ControllerBase
    {
        private readonly ITest _testService;

        public TestController(ITest _testService)
        {
            this._testService = _testService;
        }

        // EndPoint : api/Test/GetTest
        [HttpGet("GetTest")]
        public ActionResult<Model.ViewModel.TestViewModel> Get()
        {
            return Ok(_testService.ObtenerTests());
        }
    }
}
