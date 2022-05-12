using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Swift_API.Controllers
{



    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly DataContext _dataContext;
        //constructor
        public CustomerController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        //Retrieve customer info
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> Get()
        {
            return Ok(await _dataContext.Customers.ToListAsync());
        }


        [HttpGet("{CustomerId}")]
        public async Task<ActionResult<List<Customer>>> Get(int CustomerId)
        {
            var customer = await _dataContext.Customers.FindAsync(CustomerId);
            if (customer == null)
                return BadRequest("Customer not found.");
            return Ok(customer);
        }

        //Add new customer
        [HttpPost]
        public async Task<ActionResult<List<Customer>>> AddCustomer(Customer customer)
        {
            _dataContext.Customers.Add(customer);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Customers.ToListAsync());
        }

        //Update customer records
        [HttpPut]
       public async Task<ActionResult<List<Customer>>> UpdateCustomer(Customer request)
       {
            var dbcustomer = await _dataContext.Customers.FindAsync(request.Id);
            if (dbcustomer == null)
                return BadRequest("Customer not found.");

            dbcustomer.Id = request.Id;
            dbcustomer.Firstname = request.Firstname;
            dbcustomer.Lastname = request.Lastname;
            dbcustomer.Username = request.Username;
            dbcustomer.Password = request.Password;

            await _dataContext.SaveChangesAsync();


            return Ok(await _dataContext.Customers.ToListAsync());
        }

        //Delete customer records
        [HttpDelete("{CustomerId}")]

        public async Task<ActionResult<List<Customer>>> Delete(int CustomerId)
        {
            var dbcustomer = await _dataContext.Customers.FindAsync(CustomerId);
            if (dbcustomer == null)
                return BadRequest("Customer not found.");

            _dataContext.Customers.Remove(dbcustomer);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Customers.ToListAsync());
        }

    }
}
