using bytebank_ADM.Funcionarios.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.ParceriaComercial
{
    public class ParceiroComercial: IAutenticavel
    {

        public string Senha { get; set; }


        public bool Autentificar(string senha)
        {
            return this.Senha == senha;
        }

    }
}
