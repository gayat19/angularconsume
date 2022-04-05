using ExampleAPI.Models;
using ExampleAPI.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAll")]
    public class CustomerController : ControllerBase
    {
        private readonly IRepo<int, Customer> _customerRepo;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(IRepo<int,Customer> customerRepo,ILogger<CustomerController> logger)
        {
            _customerRepo = customerRepo;
            _logger = logger;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<Customer>>> Get()
        {
            var result = await _customerRepo.GetAll();
            if (result == null)
                return BadRequest("No Customers present");
            return Ok(result);
        }
        [HttpGet]
        [Route("GetCustomerById/{id}")]
        public async Task<ActionResult<Customer>> Get(int id)
        {
            var result = await _customerRepo.Get(id);
            if (result == null)
                return BadRequest("No Customer with the id "+id+" present");
            return Ok(result);
        }
        [HttpPut]
        public async Task<ActionResult<Customer>> Put(int id,Customer customer)
        {
            var result = await _customerRepo.Update(customer);
            if (result == null)
                return BadRequest("No Customer with the id " + id + " present");
            return Ok(result);
        }
        [HttpDelete]
        public async Task<ActionResult<Customer>> Delete(int id)
        {
            var result = await _customerRepo.Delete(id);
            if (result == null)
                return BadRequest("No Customer with the id " + id + " present");
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<Customer>> Post(Customer customer)
        {
            var result = await _customerRepo.Add(customer);
            if (result == null)
                return BadRequest("Could not create customer");
            return Created("Customer added",result);
        }
    }
}
