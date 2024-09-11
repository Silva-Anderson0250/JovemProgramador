using JovemProgramador.Models;

namespace JovemProgramador.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {

        List<Aluno> BuscarAlunos();
        void InserirAluno(Aluno aluno);

        Aluno BuscarId(int id);

        public void EditarAluno(Aluno aluno);

        void DeleteAluno(Aluno aluno);


    }
}