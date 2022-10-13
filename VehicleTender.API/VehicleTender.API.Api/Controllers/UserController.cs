﻿using Microsoft.AspNetCore.Mvc;
using VehicleTender.API.Api.ViewModel;
using VehicleTender.API.Entity.Context;
using VehicleTender.API.Entity.Entities;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly VehicleTenderContext _context;
        readonly IConfiguration _configuration;
       


        public UserController(VehicleTenderContext content, IConfiguration configuration)
        {
            _context = content;
            _configuration = configuration;
           
        }


        [HttpPost]
        [Route("SignIn")]
        public async Task<bool> SignIn([FromBody] UserSignInViewModel Singuser)
        {
            VehicleTender.API.Entity.Entities.User user = new User();
            user.Name = Singuser.Name;
            user.UserName = Singuser.UserName;
            user.Mail = Singuser.Mail;
            user.Password = Singuser.Password;
            await _context.User.AddAsync(user);
            if (_context.SaveChanges() > 0)
            {
                return true;
            }
            else return false;

        }
        public async Task<IActionResult> SignOut()
        {
            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> Count()
        {

            return Ok();

        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {


            return NoContent();
        }


    }
}
