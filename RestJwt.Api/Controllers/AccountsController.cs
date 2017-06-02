using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RestJwt.Api.Controllers
{
    [Route("api/[controller]")]
    public class AccountsController: Controller
    {
        [HttpGet]
        public IEnumerable<string> Login() 
        {
            return new string[] {"test1", "test2"};
        }
    }
}