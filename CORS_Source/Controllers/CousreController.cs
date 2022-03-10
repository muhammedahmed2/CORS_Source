using CORS_Source.Services;
using Microsoft.AspNetCore.Mvc;

namespace CORS_Source.Controllers
{
    [ApiController]
    [Route("/api/Course")]
    public class CousreController : ControllerBase
    {
      
        private CourseService _course_service;

        public CousreController(CourseService _svc)
        {
            _course_service = _svc;

        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok(_course_service.GetCourses());
        }
      
    }
}

