using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IFuncionarioService
    {
        void GravarFuncionario(Funcionarios funcionario);

        Task<IEnumerable<Funcionarios>> ListarFuncionario();
    }
}
