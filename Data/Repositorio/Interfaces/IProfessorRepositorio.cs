using JovemProgramador.Models;

namespace JovemProgramador.Data.Repositorio.Interfaces
{
    public interface IProfessorRepositorio
    {

            List<Professor> BuscarProfessor();
            void InserirProfessor(Professor professor);

            Professor BuscarId(int id);

            public void EditarProfessor(Professor professor);

            void DeleteProfessor(Professor professor);


        
    }
}
