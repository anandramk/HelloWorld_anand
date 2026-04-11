using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Models;
using MyFirstProject.Business;

namespace MyFirstProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpPost("get")]
        [ProducesResponseType(typeof(CustomerResponse), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<CustomerResponse> GetCustomer([FromBody] CustomerRequest request)
        {
            if (request.CustomerId <= 0)
                return BadRequest("Invalid CustomerId");

            if (request.CustomerId != 101)
                return NotFound();

            var response = new CustomerResponse
            {
                CustomerId = 101,
                Name = "Anand",
                Status = "Active"
            };

            return Ok(response);
        }
    }
}