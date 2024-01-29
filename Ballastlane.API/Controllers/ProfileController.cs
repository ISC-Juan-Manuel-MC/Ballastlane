using Microsoft.AspNetCore.Mvc;
using Ballastlane.BusinessLogic;

namespace Ballastlane.API.Controllers
{
    [ApiController]
    [Route("[Profile]")]
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly ProfileService _profileService;

        public ProfileController(ILogger<ProfileController> logger, ProfileService profileService)
        {
            _logger = logger;
            _profileService = profileService;
        }

    }
}
