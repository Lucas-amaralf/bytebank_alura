using bytebank_ADM.Funcionarios;
using bytebank_ADM.Funcionarios.SistemaInterno;
using bytebank_ADM.NovaPasta1;
using bytebank_ADM.ParceriaComercial;

void CalcularBonificacao()
{
    GerenciadorDeBonificacoes gerenciador = new();



    Designer pedro = new Designer("833.222.046-39");
    pedro.Nome = "Pedro";

    Desenvolvedor Apolo = new Desenvolvedor("345.534.534-54");
    Apolo.Nome = "Apolo";

    Diretor Lucas = new Diretor("456.687.268-86");
    Lucas.Nome = "Lucas";

    Auxiliar Perseu = new Auxiliar("555.234.534-89");
    Perseu.Nome = "Perseu";

    GerenteDeContas Pandora = new GerenteDeContas("453.634.552-89");
    Pandora.Nome = "Pandora";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(Lucas);
    gerenciador.Registrar(Perseu);
    gerenciador.Registrar(Pandora);
    gerenciador.Registrar(Apolo);

    Console.WriteLine($"Total de bonificações: {gerenciador.getBonificacao()}");
}

//CalcularBonificacao();

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();
   

    Diretor Lucas = new("456.687.268-86");
    Lucas.Nome = "Lucas";
    Lucas.Senha = "130621";


    GerenteDeContas Talyta = new GerenteDeContas("491.233.536-96");
    Talyta.Nome = "Talyta";
    Talyta.Senha = "100421";

    ParceiroComercial Perseu = new ParceiroComercial();
    Perseu.Senha = "1234";
        

    sistemaInterno.Logar(Lucas, "130621");
    sistemaInterno.Logar(Talyta, "100521");
    sistemaInterno.Logar(Perseu, "1234");

}

UsarSistema();

Console.ReadKey();

