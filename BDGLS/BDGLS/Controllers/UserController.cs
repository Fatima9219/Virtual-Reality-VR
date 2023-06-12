using Microsoft.AspNetCore.Mvc;
using BDGLS.DataAccess;
using BDGLS.Models;
using System;

namespace BDGLS.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public UserController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        /// <summary>
        /// Register new User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("Create")]
        public IActionResult Register([FromBody] UserModel user)
        {
            // Have to be encoded on the client side
            //user.Username = Utils.Decode(user.Username);
            //user.Password = Utils.Decode(user.Password);

            // Debug
            user.Username = user.Username;
            user.Password = user.Password;

            if (_dataAccessProvider.CheckDataAvailability(user))
                return Ok(new Response { Status = "Error", Message = "already registered" });

            var result = _dataAccessProvider.CheckPasswordPolicy(user);

            if (!result.Equals("OK"))
                return Ok(new Response { Status = "Error", Message = result });

            if (ModelState.IsValid)
            {
                user.UUID = Guid.NewGuid();
                _dataAccessProvider.CreateUserRecord(user);

                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserModel user)
        {
            string account = _dataAccessProvider.LoginVerification(user);

            if (account.Equals("OK"))
            {
                UserModel profile = _dataAccessProvider.ReadUserRecord(user);
                return Ok(new Profile
                {
                    Username = profile.Username,
                    Firstname = profile.Firstname,
                    Lastname = profile.Lastname,
                    Image = profile.Image
                });
            }
            return Ok(new Response { Status = "error", Message = account });
        }

        [HttpPost("ReadGameData")]
        public IActionResult ReadData([FromBody] SaveGameRequest readGameRequest)
        {
            byte[] request = _dataAccessProvider.ReadUserGameData(readGameRequest);
            return Ok(request);
        }

        [HttpPost("SaveGameData")]
        public IActionResult StoreData([FromBody] SaveGameRequest saveGameRequest)
        {
            _ = _dataAccessProvider.StoreUserGameData(saveGameRequest);
            return Ok();
        }
    }
}