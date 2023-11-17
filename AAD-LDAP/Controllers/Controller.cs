﻿using Microsoft.AspNetCore.Mvc;
using AAD_LDAP.Context;
using AAD_LDAP.Interfaces;

namespace AAD_LDAP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //private AdContext _context;

        private readonly IAdContext _context;

        public UserController(IAdContext context) {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult GetUsers()
        {
            //var valami = new AdContext();

            var res = _context.GetAllUsers();

            return Ok( res );
        }
    }
    
}
    

