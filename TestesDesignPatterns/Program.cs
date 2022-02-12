using TestesDesignPatterns.ChainOfResposibility;
using TestesDesignPatterns.Strategy;

public class MainAplication{


    static void Main() {

        void StrategyMain()
        {

            var conta = new Conta();

            conta.Deposita(100);

            Console.WriteLine("Saldo: " + conta.Saldo);

            var conservador = new Conservador();
            var arrojado = new Arrojado();
            var moderado = new Moderado();

            var realizadorInvestimento = new RealizadorDeInvestimentos();

            realizadorInvestimento.Realiza(conta, conservador);
            realizadorInvestimento.Realiza(conta, moderado);
            realizadorInvestimento.Realiza(conta, arrojado);

        }

        void ChainMain() {

            var conta = new ContaChain("Ricardo",20);

            var repostaCSV = new RespostaEmCSV();
            var respostaXML = new RespostaEmXML();
            var respostaPorcento = new RespostaEmPorcento();
            
            repostaCSV.ProximaResposta = respostaXML;
            respostaXML.ProximaResposta = respostaPorcento;

            var requisicao = new Requisicao(Formato.PORCENTO);

            repostaCSV.Responde(requisicao,conta);

        }

        var opcao = "";
        do
        {
            Console.WriteLine("\n\nEscreva uma das opções:\n0- Sair\n1- Strategy\n2- Chain of Resposibility\n3- Template Method");
            opcao = Console.ReadLine();
            Console.WriteLine("\n\n\n\n\n");

            switch (opcao)
            {
                case "1":
                    StrategyMain();
                    break;
                case "2":
                    ChainMain();
                    break;
                case "3":
                    break;

                default:
                    break;
            }
        } while (String.IsNullOrEmpty(opcao));
        

    }


}