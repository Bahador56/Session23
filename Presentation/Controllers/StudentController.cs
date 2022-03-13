using DataAccess.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
           
        }
        public IActionResult Index()
        {
            var data = _studentRepository.Get();
            return View(data);
        }
    }
}
