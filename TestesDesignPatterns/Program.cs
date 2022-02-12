using TestesDesignPatterns.ChainOfResposibility;
using TestesDesignPatterns.Strategy;
using TestesDesignPatterns.TemplateMethod;

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

        void TemplateMain() {

            var conta1 = new ContaMethod("Ricardo","Numero: 123","Agencia: 2313132","R$50000,00");
            var conta2 = new ContaMethod("Bruno", "Numero: 21313", "Agencia: 234332423", "R$71190849028,00");
            var conta3 = new ContaMethod("Mayumi", "Numero: 1423442423", "Agencia: 2789782", "R$1287891298127979287190000,00");

            List<ContaMethod> contas = new List<ContaMethod>();

            contas.Add(conta1);
            contas.Add(conta2);
            contas.Add(conta3);


            var relatorio = new RelatorioSimples();

            relatorio.ImprimeRelatorio(contas);
        }

        var opcao = "";
        do
        {
            Console.Clear();
            Console.WriteLine("\n\nEscreva uma das opções:\n0- Sair\n1- Strategy\n2- Chain of Resposibility\n3- Template Method\n");
            opcao = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("\n\n");

            switch (opcao)
            {
                case "1":
                    StrategyMain();
                    break;
                case "2":
                    ChainMain();
                    break;
                case "3":
                    TemplateMain();
                    break;

                default:
                    break;
            }
            Console.ReadKey();
        } while (opcao != "0");
        

    }


}