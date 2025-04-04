using Conexao;
using Microsoft.EntityFrameworkCore;
using Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DAL
{
    class FuncionarioDAL
    {
        public async Task<List<FuncionarioDTO>> ObterTodos()
        {
            using (var context = new HotelContext())
            {
                return await context.funcionarioDTOs.ToListAsync();
            }
        }

        public async Task<FuncionarioDTO> ObterPorId(int id)
        {
             using (var context = new HotelContext())
            {
                return await context.funcionarioDTOs.FirstOrDefaultAsync(f => f.ID == id);
            }
        }

        public async Task Adicionar(FuncionarioDTO funcionario)
        {
            using (var context = new HotelContext())
            {
                await context.funcionarioDTOs.AddAsync(funcionario);
                await context.SaveChangesAsync();
            }

        }

        public async Task AtualizarAsync(FuncionarioDTO funcionario)
        {
            using (var context = new HotelContext())
            {
                context.funcionarioDTOs.Update(funcionario);
                await context.SaveChangesAsync();
            }
        }

        public async Task Excluir(int id)
        {
            using (var context = new HotelContext())
            {
                var funcionario = await context.funcionarioDTOs.FindAsync(id);
                if (funcionario != null)
                {
                    context.funcionarioDTOs.Remove(funcionario);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
