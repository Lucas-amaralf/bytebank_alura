using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    // Classe abstrata serve como base para que as classes que
    // herdem desta não precisem se preocupar com o comportamento padrão.
    public abstract class Funcionario 
    {

        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; } 

        // Static informa que a propriedade é da classe e não do objeto 
        public static int TotalFuncionarios { get;  private set; }
        
        public Funcionario(string Cpf, double Salario)
        {
            this.Cpf = Cpf;
            this.Salario = Salario;
            TotalFuncionarios++;
        }


        //Virtual é para poder redefinir em outras classes como a classe diretor 
        //Abstract cria um método "Generico" para usar sem um padrão nas outras classes filhas 
        public abstract double getBonificacao();


        public abstract void AumentarSalario();
    }
}
