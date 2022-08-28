using DevTrackr.API.Entities;
using DevTrackr.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevTrackr.API.Controllers
{
    [ApiController]
    [Route("api/packages")]
    public class PackagesController : ControllerBase
    {
        // GET api/packages
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        // GET api/packages/1234-1235
        [HttpGet("{code}")]
        public IActionResult GetByCode(string code)
        {
            return Ok();
        }

        // POST api/packages
        [HttpPost]
        public IActionResult Post(AddPackageInputModel model)
        {
            var package = new Package(model.Title, model.Weight);

            return Ok(package);
        }

        // POST api/packages/1235-1235/updates
        [HttpPost("{code}/updates")]
        public IActionResult PostUpdate(string code, AddPackageUpdateInputModel model)
        {

            return Ok();
        }
    }
}
