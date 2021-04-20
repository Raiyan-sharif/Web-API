using Microsoft.AspNetCore.Mvc;
using Web_API.Models;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();
    }
}