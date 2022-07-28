using bytebank_ADM.ParceriaComercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar (IAutenticavel funcionario, string Senha)
        {
            bool usuarioAutenticado = funcionario.Autentificar(Senha);

            if(usuarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }


    }
}
