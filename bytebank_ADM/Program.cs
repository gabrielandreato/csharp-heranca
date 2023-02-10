using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("123456789", 2000.0);
//pedro.Nome = "Pedro malazartes";


//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonficacao);
//Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);

//Console.WriteLine("Novo salário da Roberta: " + roberta.Salario);
#endregion


//CalcularBonificacao();


//void CalcularBonificacao()
//{
//    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//    Designer ulisses = new Designer("123456");
//    ulisses.Nome = "Ulisses Souza";

//    Diretor paula = new Diretor("987456");
//    paula.Nome = "Paula Souza";

//    Auxiliar igor = new Auxiliar("74581");
//    igor.Nome = "Igor Dias";

//    GerenteDeContas camila = new GerenteDeContas("852963");
//    camila.Nome = "Camila Oliveira";

//    gerenciador.Registrar(camila);
//    gerenciador.Registrar(igor);
//    gerenciador.Registrar(paula);
//    gerenciador.Registrar(ulisses);

//    Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonficacao);
//}


UsarSistema();
void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("123123");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Login = "ingrid.novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("123123");
    ursula.Nome = "Ursula Alcantara";
    ursula.Login = "ursula.alcantara";
    ursula.Senha = "321";
    
    ParceiroComercial caio = new ParceiroComercial();
    caio.Login = "caio";
    caio.Senha = "321";

    sistema.Logar(ingrid, "ingrid.novaes", "123");
    sistema.Logar(ursula, "abc", "444");
    sistema.Logar(caio, "caio", "321");





}





