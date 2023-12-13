using Microsoft.AspNetCore.Mvc;

namespace dotnetapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoboticController : ControllerBase
    {
        private readonly ILogger<RoboticController> _logger;

        public RoboticController(ILogger<RoboticController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "MoveRoboticRover")]
        public async Task<ActionResult<string>> Move()
        {
            Position firstPosition = new Position();
            firstPosition.x = 1;
            firstPosition.y = 2;
            RoboticRover firstRoboticRover = new RoboticRover(firstPosition, Directions.N);
            firstRoboticRover.Start("LMLMLMLMM");

            Position secondPosition = new Position();
            secondPosition.x = 3;
            secondPosition.y = 3;
            RoboticRover secondRoboticRover = new RoboticRover(secondPosition, Directions.E);
            secondRoboticRover.Start("MMRMMRMRRM");

            string result = "First Result : " + firstRoboticRover.GetResult() + " ///////////// " + "Second Result : " + secondRoboticRover.GetResult();

            return Ok(result);
        }
    }
}
