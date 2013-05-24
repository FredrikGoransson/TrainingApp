using System.Web.Mvc;
using TrainingApp.Data;

namespace TrainingApp.Controllers
{
    public class ProgramController : Controller
    {
        private readonly ProgramRepository _programRepository;

        public ProgramController(ProgramRepository programRepository)
        {
            _programRepository = programRepository;
        }

        //
        // GET: /Program/

        public ActionResult Index()
        {
            // List all programs
            var allPrograms = _programRepository.GetAllProgramOverviews();

            // build viewmodel

            return View();
        }

        //
        // GET: /Program/Details/3

        public ActionResult Details(int id)
        {
            // Show the program

            return View();
        }

    }
}
