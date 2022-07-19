using Api_projeto_Zenvia.Models.Customer;
using Api_projeto_Zenvia.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_projeto_Zenvia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> Post(
            [Required][FromBody] Customer customer
            )
        {
            try
            {
                var result = await _customerService.Create(customer);

                return Ok(result);
            } catch (Exception e)
            {
                throw new(e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<CustomerSearch>> GetAll(
            [Required][FromQuery] int page,
            [Required][FromQuery] int size,
            [FromQuery] string customerName)
        {
            try
            {
                var customers = await _customerService.GetAll(page, size, customerName);

                return Ok(customers);
            } catch (Exception e)
            {
                throw new(e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetById(
            [Required][FromRoute] int id
        )
        {
            try
            {
                var customer = await _customerService.GetById(id);

                if(customer != null)
                {
                    return Ok(customer);
                }

                return NotFound();
            } catch (Exception e)
            {
                throw new(e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Customer>> Update(
            [Required][FromRoute] int id,
            [Required][FromBody] Customer customer
        )
        {
            try
            {
                var current = await _customerService.GetById(id);

                if (current != null)
                {
                    return Ok(await _customerService.Update(customer));
                }

                return NotFound();
            } catch (Exception e)
            {
                throw new(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> Delete(
            [Required][FromRoute] int id
        )
        {
            try
            {
                var current = await _customerService.GetById(id);

                if (current != null)
                {
                    _customerService.Remove(current);

                    return Ok();
                }

                return NotFound();
            } catch (Exception e)
            {
                throw new(e.Message);
            }
        }
    }
}
