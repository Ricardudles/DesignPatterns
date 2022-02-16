using TestesDesignPatterns.Bridge;
using TestesDesignPatterns.ChainOfResposibility;
using TestesDesignPatterns.Command;
using TestesDesignPatterns.Decorator;
using TestesDesignPatterns.FlyWeight;
using TestesDesignPatterns.Interpreter;
using TestesDesignPatterns.Memento;
using TestesDesignPatterns.State;
using TestesDesignPatterns.Strategy;
using TestesDesignPatterns.TemplateMethod;
using TestesDesignPatterns.Visitor;

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

        void DecoratorMain() {

            var conta1 = new ContaDecorator();
            var conta2 = new ContaDecorator();
            var conta3 = new ContaDecorator();
            var conta4 = new ContaDecorator();
            var conta5 = new ContaDecorator();

            conta1.Deposita(99);
            conta2.Deposita(200);
            conta3.Deposita(1000000);
            conta4.Deposita(2);
            conta5.Deposita(4000000);

            var contas = new List<ContaDecorator>();

            contas.Add(conta1);
            contas.Add(conta2);
            contas.Add(conta3);
            contas.Add(conta4);
            contas.Add(conta5);

            var filtros = new FiltroMenorQue100Reais(new FiltroSaldoMaiorQue500Mil());

            Console.WriteLine("Contas: \n");

            foreach (var item in filtros.Filtra(contas))
            {
                Console.WriteLine("Saldos aceitos nos filtros: " + item.Valor);
            }

        }

        void StateMain(){
            //particularmente nao gosto de design pq ele fere o I do SOLID

            var conta = new ContaState();

            conta.Saca(20);

            conta.Deposita(40);

            conta.Saca(20);

            conta.Saca(20);

        }

        void LightWeight() {

            NotasMusicais notas = new NotasMusicais();

            IList<INota> doReMiFa = new List<INota>() {
            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("mi"),
            notas.Pega("fa"),
            notas.Pega("fa"),
            notas.Pega("fa"),

            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("re"),
            notas.Pega("re"),

            notas.Pega("do"),
            notas.Pega("sol"),
            notas.Pega("fa"),
            notas.Pega("mi"),
            notas.Pega("mi"),
            notas.Pega("mi"),

            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("mi"),
            notas.Pega("fa"),
            notas.Pega("fa"),
            notas.Pega("fa")
        };

            Piano piano = new Piano();
            piano.Toca(doReMiFa);

        }

        void MementoMain() {

            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "Mauricio", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            Console.WriteLine(historico.Pega(0).Contrato.Tipo);
            Console.WriteLine(historico.Pega(1).Contrato.Tipo);
            Console.WriteLine(historico.Pega(2).Contrato.Tipo);
            Console.WriteLine(historico.Pega(3).Contrato.Tipo);


        }

        void InterpreterMain() {

            // (10 - 5) + (2 + 10)

            IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            IExpressao direita = new Soma(new Numero(2), new Numero(10));
            IExpressao contaFinal = new Multiplicacao(new Soma(esquerda, direita), new Numero(10));

            int resultado = contaFinal.Avalia();
            Console.WriteLine(resultado);

            ///USA O DESIGN PATTERN VISITOR

            var impressora = new ImpressoraVisitor();

            contaFinal.Aceita(impressora);

        }

        void BridgeMain() {

            IEnviador enviador = new EnviaPorEmail();
            IMensagem mensagem = new MensagemAdmin("Ricardo");

            enviador.Envia(mensagem);
        
        }

        void CommandMain() {

            Pedido pedido1 = new Pedido("Mauricio", 150.0);
            Pedido pedido2 = new Pedido("Marcelo", 250.0);

            FilaDeTrabalho fila = new FilaDeTrabalho();

            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));
            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();
        }

        var opcao = "";
        do
        {
            Console.Clear();
            Console.WriteLine("\n\nEscreva uma das opções:\n0- Sair\n1- Strategy\n2- Chain of Resposibility\n3- Template Method\n4- Decorator\n5- State\n6- LightWeight\n7- Memento\n8- Interpreter\n9- Bridge\n10- Command");
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
                case "4":
                    DecoratorMain();
                    break;
                case "5":
                    StateMain();
                    break;
                case "6":
                    LightWeight();
                    break;
                case "7":
                    MementoMain();
                    break;
                case "8":
                    InterpreterMain();
                    break;
                case "9":
                    BridgeMain();
                    break;
                case "10":
                    CommandMain();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        } while (opcao != "0");
        

    }


}