namespace DevJobs.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/job-vacancies")]
    [ApiController]
    public class JobVacanciesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            
            return Ok();
        }
        
          [HttpGet("{id}")]
        public IActionResult GetAllById(int id)
        {
            
            return Ok();}

// 
        [HttpPost("{id}")]
        public IActionResult GetAllById()
        {
            
            return Ok();
        }


        [HttpPut]

        public IActionResult putVacancies() {

            return Ok();
        }
}
}