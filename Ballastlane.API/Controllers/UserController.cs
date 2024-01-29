using Microsoft.AspNetCore.Mvc;
using Ballastlane.BusinessLogic;
using Ballastlane.Models; //These models are used prior to creating standardized response models.

namespace Ballastlane.API.Controllers
{
    [ApiController]
    [Route("[User]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly UserService _userService;

        public UserController(ILogger<UserController> logger, UserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        //GET /api/appdata: Retrieve all records.
        [HttpGet(Name = "GetAllUsers")]
        public IEnumerable<User> Get()
        {
            return _userService.GetAll();
        }

        /*
        GET /api/appdata/{id}: Retrieve a specific record by ID.
        POST /api/appdata: Create a new record.
        PUT /api/appdata/{id}: Update an existing record.
        DELETE /api/appdata/{id}: Delete a record by ID.
        POST /api/users: Create a new user account.
        POST /api/login: User login.  
        GET /api/appdata: Retrieve all records.
        */

    }
}
