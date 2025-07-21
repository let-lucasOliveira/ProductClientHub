using Microsoft.AspNetCore.Mvc;

namespace ProductClienteHub.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")] // Fazendo desta forma impedimos o recebimento de ID nulo.
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
