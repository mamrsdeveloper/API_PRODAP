using Business.Interfaces;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Service
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly Context _context;
        public FuncionarioService(Context context)
        {
            _context = context;
        }

        public void GravarFuncionario(Funcionarios funcionario)
        {
            if (funcionario.IdFuncionario > 0)
            {
                _context.Funcionarios.Update(funcionario);
            }
            else
            {
                _context.Funcionarios.Add(funcionario);
            }
            _context.SaveChanges();

        }

        public async Task<IEnumerable<Funcionarios>> ListarFuncionario()
        {
            var Funcionarios =  await _context.Funcionarios.ToArrayAsync();

            return Funcionarios;
        }
    }
}
