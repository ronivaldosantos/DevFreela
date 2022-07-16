using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController :ControllerBase
    {
        //Exemplos: ?query=net core (passa uma query que deseja pesquisar) SELECT
        //api/projects
        [HttpGet]
        public IActionResult Get(string query) 
        { 
            return Ok();
        }

        //Passa um id específico de um projeto a ser localizado SELECT
        //api/projects/599 
        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            //possíveis retornos
            //return NotFound();
            return Ok();        
        }

        //CREATE
        //api/projects 
        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject) 
        {
            //Possíveis retornos: BadRequest
            if (createProject.Title.Length > 50)
            {
                return BadRequest(); 
            }

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        //UPDATE
        //api/projects/2 
        [HttpPut("id")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 200)
            {
                return BadRequest();
            }
            return NoContent();
        }

        //DELETE
        //api/projects/3 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            return NoContent();
        }

        //Grava comentário no projeto
        //api/projects/1/comments
        [HttpPost("{id}/comments")]
        public IActionResult PostComments(int id, [FromBody] CreateCommentModel createCommentModel ) 
        {
            return NoContent(); 
        }

        //Atualizar o projeto para o status iniciado - Start
        //api/projects/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        //Atualizar o projeto para o status iniciado - Finish
        //api/project/1/finish
        [HttpPut("{id}/finish")]
        public  IActionResult Finish(int id) 
        {
            return NoContent();
        }

    }
}
