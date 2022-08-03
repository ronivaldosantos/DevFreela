using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers {

    [Route("api/users")]
    public class UsersController : ControllerBase 
    {
        //Injeção de dependência
        public UsersController(ExampleClass exampleClass)
        {

        }

        //api/users/1
        [HttpGet("{id}")] //Find users for identity
        public IActionResult GetById(int id)                           
        {
            return Ok();
        }

        //api/users
        [HttpPost] //Add UserName and Password
        public IActionResult Post([FromBody] CreateUserModel createUserModel)
        {
            return CreatedAtAction(nameof(GetById), new {id = 1}, createUserModel);
        }

        //api/users/1/login
        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginModel loginModel) 
        {
            return Ok(); 
        }

    }
}
