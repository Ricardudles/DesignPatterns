using System;

public class MyClass
{
    private static MyClass instance;

    private MyClass() { }

    public static MyClass Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new MyClass();
            }
            return instance;
        }
    }
}

//Quando você necessita de somente uma instância da classe,
//por exemplo, a conexão com banco de dados, vamos supor que você terá que 
//chamar diversas vezes a conexão com o banco de dados em um código na 
//mesma execução, se você instanciar toda vez a classe de banco, haverá 
//grande perda de desempenho, assim usando o padrão singleton, é garantida 
//que nesta execução será instânciada a classe somente uma vez. Lembrando 
//que este pattern é considerado por muitos desenvolvedores um antipattern,
//então, cuidado onde for utilizá-lo.