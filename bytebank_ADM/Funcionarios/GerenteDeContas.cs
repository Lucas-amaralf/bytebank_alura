using bytebank_ADM.Funcionarios.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {

        public GerenteDeContas(string cpf): base(cpf, 4000)
        {
            Console.WriteLine("Criando um gerente de contas");
        }

        public override void AumentarSalario()
        {
            Salario *= 0.5;
        }

        public override double getBonificacao()
        {
            return Salario * 0.25 ;
        }

    }
}
