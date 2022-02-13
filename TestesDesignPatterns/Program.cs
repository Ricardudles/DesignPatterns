﻿using TestesDesignPatterns.ChainOfResposibility;
using TestesDesignPatterns.Decorator;
using TestesDesignPatterns.State;
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

        var opcao = "";
        do
        {
            Console.Clear();
            Console.WriteLine("\n\nEscreva uma das opções:\n0- Sair\n1- Strategy\n2- Chain of Resposibility\n3- Template Method\n4- Decorator\n5- State\n");
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
                default:
                    break;
            }
            Console.ReadKey();
        } while (opcao != "0");
        

    }


}