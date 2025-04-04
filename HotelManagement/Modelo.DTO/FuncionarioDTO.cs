using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DTO
{
    public class FuncionarioDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string? Rg { get; set; }
        public string Sexo { get; set; }
        public string Cargo { get; set; }
        public string? Email { get; set; }
        public string Celular { get; set; }

    }
}
