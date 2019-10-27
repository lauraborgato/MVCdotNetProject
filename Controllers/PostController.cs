using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCdotNetProject.Interfaces.Service;
using MVCdotNetProject.Models;

namespace MVCdotNetProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IPostService _postService;

        public PostController(ILogger<WeatherForecastController> logger, IPostService postService)
        {
            _logger = logger;
            _postService = postService;
        }

        [HttpGet]
        public IEnumerable<Post> Get()
        {
           return _postService.GetAllPosts().ToArray();
        }
    }
}
