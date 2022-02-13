//O factory é usualmente aplicado quando precisamos isolar um conjunto de instrução que sempre vai
//ser usado pelo código. 

//O melhor exemplo é a conexão do banco de dados. Sempre precisamos abrir essa conexão e usar ela,
//então o factory seria responsável por ter esse código em uma função que sempre vai ser usada.

//Temos o costume de usar o sufixo `Factory`
// nas nossas classes que são fábricas. Muitas vezes vale a pena seguir a convenção, já que,
// dessa forma, outros desenvolvedores entenderão mais facilmente o código.