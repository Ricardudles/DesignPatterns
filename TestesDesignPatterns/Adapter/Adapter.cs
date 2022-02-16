//Basicamente você usará o adapter para criar uma forma de um sistema legado ou funções que não podem ser mudadas, para que eles possam ser usados na orientação à objeto
// Parecido com Strategy e Command, a diferença é as finalidades de cada um
//no strategy nós criamos um sistema de classe e interface para que possamos ter uma estratégia em comum. Por exemplo criar um interface BancoDeDados a estratégia é que todas as classes que herdarem
//essa interface terá que usar a função conectaBanco, ou seja, uma estratégia em comum
//Já o command a gente cria uma forma de armazenar certos comandos para que possam ser usados posteriormente, ideal para filas de trabalho