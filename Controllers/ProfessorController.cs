using JovemProgramador.Data.Repositorio.Interfaces;
using JovemProgramador.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramador.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorRepositorio _profressorRepositorio;
        public ProfessorController(IProfessorRepositorio professorRepositorio)
        {
            _professorRepositorio = professorRepositorio;
        }


        public IActionResult Index()
        {
            var professor = _professorRepositorio.BuscarProfessor();
            return View(professor);
        }
        public IActionResult AdicionarProfessor()
        {
            return View();
        }

        public IActionResult InserirProfessor(Professor professor)
        {
            try
            {
                _professorRepositorio.InserirProfessor(professor);
            }
            catch (Exception)
            {
                throw;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var professor = _professorRepositorio.BuscarId(id);
            return View(professor);
        }
        public IActionResult EditarProfessor(Professor professor)
        {
            _professorRepositorio.EditarProfessor(professor);
            return RedirectToAction("Index");

        }

        public IActionResult DeleteProfessor(Professor professor)
        {
            _professorRepositorio.DeleteProfessor(professor);
            return RedirectToAction("Index");
        }
    }

}
