//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;
using project1.Model;
using project1.Model.DTO;
using project1.Service.Interface;

namespace project1.Controller;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase {

        private readonly IUserService _userService;

        public UserController(IUserService userService) => _userService = userService;

        [HttpGet("user")]
        public async Task<IActionResult> GetAllUsers(){

            var users = await _userService.GetAllUsers();
            return Ok(users);

        }

       // [EnableCors(apiCorsPolicy)]
        [HttpPost("AddNewUser")]
        public async Task<IActionResult> AddNewUser([FromBody] NewUserDTO user){

            try{
                await _userService.AddUser(user);
                return Ok(user);
            }
            catch(Exception e){
                return BadRequest(e.Message);
            }

        }

        [HttpGet("GetUserByUserNameAndPassword")]
        public async Task<IActionResult> GetUserByNameAndPassword(string username, string password){
            try{
                User User = await _userService.GetUserByUserNameAndPassword(username, password);
                return Ok(User);
            }
            catch(Exception e){
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("DeleteUserByUserNameAndPassword")]
        public async Task<IActionResult> DeleteUserByNameAndPassword(string username, string password){
            try{
                User user = await _userService.DeleteUserByUserNameAndPassword(username, password);
                return Ok(user);
            }
            catch(Exception e){
                return BadRequest(e.Message); 
            }
        }

        [HttpPost("UpdateUser")]
        public async Task<IActionResult> UpdateUser(string username, string password,[FromBody] NewUserDTO user){
            try{
                User user0 = await _userService.UpdateUser(username, password, user);
                return Ok(user0);
            }
            catch(Exception e){
                return BadRequest(e.Message);
            }
        }


}