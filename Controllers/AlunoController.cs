﻿using JovemProgramador.Data.Repositorio.Interfaces;
using JovemProgramador.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramador.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }


        public IActionResult Index()
        {
            var aluno = _alunoRepositorio.BuscarAlunos();
            return View(aluno);
        }
        public IActionResult AdicionarAluno()
        {
            return View();       
        }
        
        public IActionResult InserirAluno(Aluno aluno)
        {
            try
            {
                _alunoRepositorio.InserirAluno(aluno);
            }
            catch (Exception)
            {
                throw;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var aluno = _alunoRepositorio.BuscarId(id);
            return View(aluno);
        }
        public IActionResult EditarAluno(Aluno aluno)
        {
            _alunoRepositorio.EditarAluno(aluno);
            return RedirectToAction("Index");

        }
       
        public IActionResult DeleteAluno(Aluno aluno)
        {
            _alunoRepositorio.DeleteAluno(aluno);
            return RedirectToAction("Index");
        }
    }

}
