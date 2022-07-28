using bytebank_ADM.Funcionarios.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string Cpf, double Salario) : base(Cpf, Salario)
        {
        }
        public string Senha { get; set; }

        public bool Autentificar(string senha)
        {
            return Senha == senha;
        }
    }
}
