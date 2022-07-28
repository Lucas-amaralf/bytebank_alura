using bytebank_ADM.Funcionarios.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor: FuncionarioAutenticavel
    {

        //Vai preencher o cpf do classe funcionario 
        public Diretor(string Cpf): base(Cpf, 5000)
        {
            Console.WriteLine("Criando um Diretor ");
        }


        public override void AumentarSalario()
        {
            this.Salario *= 1.15;

        }

        //overrrider é para sobrescrever o método da classe pai, no caso Funcionario 
        public override double getBonificacao()
        {
            // Está invocando o método da classe base. 
            return Salario * 0.5;
        }


    }
}
