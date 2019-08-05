using CheckIn2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CheckIn2019.Controllers.APIs
{
    [RoutePrefix("api/usercheckin")]
    public class UserCheckInController : ApiController
    {
        [HttpPost]
        [Route("insert")]
        public IHttpActionResult Save(UserCheckInModel model)
        {
            //if (!ModelState.IsValid)
            //    return BadRequest();
            //var customer = Mapper.Map<CustomerDTO, Customer>(customerDto);
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
            //customerDto.Id = customer.Id;
            return Created("dddddd", new
            {
            });
        }
    }
}
