# C# Curso Completo: Do Básico ao Avançado!
**Udemy** - Leonardo Moura Leitão - Cod3r Cursos

## Conteúdo do curso

### 1. Introdução

  Visão panorâmica do C#, apresentação do conteúdo.

### 2. Repositório do Curso (Github)

  Repositório para baixar os fontes do curso. Orientações e opções para baixar e utilizar exercírcios e códigos fontes do curso.

### 3. Repositório do Curso

  https://github.com/cod3rcursos/curso-c-sharp

### 4. Linguagem Natural vs Artificial

  A linguagem natural pode ser muito subjetiva de forma para a linguagem artificial isso não pode ocorrer assim como ambiguidades. A comunicação com a máquina tem que ser direta, clara e específica.

### 5. Introdução a Algoritmos

  É uma sequência de passos, seja da vida real ou um programa de computador na execução de uma comandos.

  Esses passos podem ser selecionados de maneira condicional, seja para executar ou não ou mesmo para repetir.

  A ordem é importante na sequencia do algoritimo pois incluencia no resultado, podendo gerar um bug ou mesmo uma queda de desempenho (mesmo não estando errado).

### 6. Introdução à Estrutura de Dados

  Estrutura de dados é diferente dos dados.

  A estrutura de dados traz organização define um conjunto regras em que os dados podem se organizar.

  Tipos de estrutura: **Lista, Pilhas, Fila**

### 7. O que é .NET?

  .Net é um framework. Que possibilita desenvolver em diversas linguagens C#, F#...

  O .NET é separado em duas partes o CLR e as LIBs.

### 8. Common Language Runtime (CLR)

  CLR é um interpretador que transforma o ILCode para um código de máquina Windows, Linux ou MAC. Pelo JIT(Just in Time)

### 9. Usando o terminal  

### 10. Terminais


## Seção 2: Configuração do Ambiente 

### 11. Aviso importante aos usuários de Windows

### 12. Configuração do Ambiente

### 13. Ambiente para Linux

## Seção 3: Fundamentos

### 14. Arquitetura de uma Solução C#

  Estrutura de soluções com vários projetos sejam eles um exe ou uma dll.
  
  Dentro dos projetos encontramos os namespaces e classes.

### 15. Criando um Projeto C#

  Configurações de ajuste de formatação(indentação) do código.

  ```
  namespace CursoCShparp
  {
      class Program
      {
          static void Main(string[] args)
          {
              Console.WriteLine("Hello World!");
          }
      }
  }
  ```
  
  Para:

  ```
  namespace CursoCShparp {
    class Program {
      static void Main(string[] args) {
          Console.WriteLine("Hello World!");
      }
    }
  }
  ```
  
### 16. Organização Básica do Código


### 17. Primeiro Programa

  A função Main é a porta de entrada para o programa C#

  E este mesmo método Main só é aceito um no C#. Desta forma quando se criam dois projetos e ambos possuem um método Main, há duas alternativas que podem ser todamas:

  Primeira: Renomear um dos métodos Main() a partir dai, o compilador irá considerar o que ficar como Main() sendo o programa principal do C#.

  Segunda: A outra auternativa é ir em: Clica em cima do projeto o botão direito, vai em **Propriedade** Aplicativo|Geral|No combo de objeto de inicialização, seleciona em qual dos dois projetos, qual Main() deseja que seja executado.

  Mas ainda há uma outra forma na qual será vista a seguir.

### 18. Link para material

  Link com arquivo para gerenciamento dos exercícios:

  http://files.cod3r.com.br/curso-c-sharp/central.zip
  
### 19. Problema: Múltiplos Main

  Nesta aula iremos descompactar o arquivo baixado na aula anterior e devemos seguir alguns passos. Esse arquivo baixado irá conter um programa no qual poderemos gerenciar a compilação do exercício desejado, de forma que caso não seja informado o exercício, o programa irá executar por padrão o último que muito provavelmente será o que está sendo desenvolvido.

  Passo que devemos seguir:

  1º Descompacte o arquivo .zip que terá dois arquivo que devem ser copiados para pasta do projeto. Sobreponha o Program.cs.

  2º No PrimeiroPrograma.cs o método main será renomeado para Executar. Isso permitirá ser chamado através do Program.cs. E com todos os demais serão feitos dessa forma, criando uma classe e declarando a sua chamada no Program.cs, tornando proximo do funcionamento de uma aplicação.

### 20. Comentários de Código

  Três barras /// invoca o XML Comments

  Comentário em bloco /* */

  Comentário em linha //

  Selecionando o texto ainda há os atalhos:
    
  CTRL + K + C: Comenta código selecionado com duas barras //.

  CTRL + K + U: Descomenta código selecionado.

  
### 21. Variáveis e Constantes

### 22. Inferência de Tipos

  Declaração por inferência é necessário atribuir o valor para o C# fazer a inferência e tipar a variável, conforme o valor atribuido.

### 23. Interpolação de Strings

  Pode se feito utilizando indices dentro das chaves para as varíáveis. Ou então iniciando a string com um $ e dentro das chaves colocando o nome das variáveis.

### 24. Notação Ponto  

  Permite o endadeamento de funções e propriedades de um atributo, classe e etc...

  Atribuindo-se uma ? em uma variável que esteja nula o método ou função ignora e não executar a leitura deste atributo.

### 25. Lendo Dados do Console

### 26. Formatando Números

### 27. Conversões

  Implicita

  Explicita

### 28. Operadores Aritméticos

  Somar + , Subtrair - , Multiplicar * , Dividir / , Módulo %.

### 29. Operadores Relacionais

  Tabela verdade:
  
  **E**
  - V && V = V
  - V && F = F
  - F && V = F
  - F && F = F

  **OU**
  - V || V = V
  - V || F = V
  - F || V = V
  - F || F = F

  **OU EXCLUSIVO**
  - V ^ V = F
  - V ^ F = V
  - F ^ V = V
  - F ^ F = F

### 30. Operadores Lógicos #01

  Operadores binários.

  Operadores unários.

### 31. Operadores Lógicos #02


### 32. Operadores de Atribuição

### 33. Operadores Unários

  Operadores tem haver com a quantidade de operandos.

  No unário temremos um operando.

  Operador de incremento ou decremento em que o sinal antecede a variável, e feito primeiro a operação de incremento ou decremento e depois é feito a comparação.

  ```
  public static void Executar() {
    var valorNegativo = -5;
    var numero1 = 2;
    var numero2 = 3;
    var booleano = true;

    Console.WriteLine(-valorNegativo);
    Console.WriteLine(!booleano);

    numero1++;

    --numero1;
    Console.WriteLine(numero1);

    //Neste caso temo o primeiro console dando true
    Console.WriteLine(numero1++ == --numero2);
    //Mas o segundo console mostrando numeros diferentes.
    Console.WriteLine($"{numero1} {numero2}");
    //E o que ocorreu é que para este caso presenciamos o exemplo em que o operador unário compara numero1 antes de incrementar com o valor de numero2 primeiramente decrementado, então temos 2 == 2, true;
  }
  ```

### 34. Operador Ternário

  Operador composto por três operando, a primeira parte é a expressão de validação, a segunda é o retorno para verdadeiro e a terceira é o retorno sendo falsa.

## Seção 4: Estruturas de Controle

### 35. Estrutura IF

### 36. Estrutura IF/ELSE

### 38. Estrutura SWITCH

### 39. Estrutura WHILE

### 40. Estrutura DO WHILE

### 41. Estrutura FOR

### 42. Estrutura FOREACH

  O laço foreach é utilizaod para a leitura direta de uma estrutura do inicio ao fim. A diferença bácisa com relação laço For é a flexibilidade as possibilidades que o For permite de variar.

### 43. Usando BREAK

  O break faz com que saia da estrutura de controle. O break não é uma estrutura de controle mas é normalmente utilizada dentro das estuturas de controle.

  O break normalmente está associado a um Switch ou então a um laço de repetição, portanto não se aplica no if.

### 44. Usando CONTINUE

  Ao contrário do break que interrompe a retição e sai fora do laço for ou de repetição. O continue ele interrompe aquela repetição e vai para próxima repetição.


## Seção 5: Classes & Métodos

### 45. Classes vs Objeto

### 46. Métodos

  Métodos com retorno e parâmetros.

  Métodos com retorno e sem parâmetros.

  Para ambos os casos devem se definir o tipo de retorno e o tipo dos parâmetros para execução das sentenças dentro do método.

  Métodos que não tem retono devem ter na sua declaração o tipo **void** que significa vazio.

### 47. Membros: Atributos e Métodos

  Criando classe Pessoa e trabalhando com a criação de atributos e classes.

### 48. Construtores

### 49. Métodos Com Retorno #01

  Assinatura do método é composta pelo seu nome e os tipos dos parâmetros, portanto isso não pode ser igual, que o C# não permite.

### 50. Métodos Com Retorno #02

  Construtor por padrão recebe o mesmo nome da classe.

  Ao criar uma classe e não é definido nenhum construtor padrão é feito um construtor padrão. E um construtor padrão não recebe nenhum parâmetro, entretanto é possível fazer passagem de parâmetros.

  Em caso de um parâmetro com o mesmo nome de um atributo da classe, pode ser feita a diferenciação com o this antes do atributo, portanto estou definindo que o nome que está com o **this" antes é referente ao objeto da classe.

### 51. Métodos Estáticos

  Método estático é definido seu tipo na declaração **static**.

  Usualmente para utilizar uma classe necessita que a mesma seja instanciada para que a os seus atributos e métodos possam ser acessado. Entretanto com o termo **static** essa declaração passa a não ser mais necessária pois a partir do momento em que uma classe é definida como estática o programa considera como-se este método pertença a toda classe podendo desta forma acessar seus métodos e atributos sem uma prévia instanciação.

  Desta maneira o membro **static** ao se instanciar e passando a pertencer a **classe** ele só poderá ser acessado pela classe, sendo assim fazendo o inverso tentando acessar um método que seja **static** a partir de uma nova instância, o programa também acusará erro pois ele informará que o membro só poderá ser acessaro diretamente pela classe.

### 51. Atributos Estáticos    

  Os atributos se comportam semelhantemente aos métodos, respeitando a mesma regra, de forma que um atributo quando definido como **static** o mesmo deverá ser acessado a partir da Classe, e quando ocorrer da classe ser instanciada o mesmo não poderá ser acessado pois ocorrerá erro.

### 53. Desafio Acessar Atributo

### 54. Desafio Acessar Atributo (Resposta)

  Instanciar a classe na qual o atributo pertence e fazer a chamada a partir da instância do atributo. Pois se trata de uma classe que não é static, desta maneira para poder acessar, deve-se instanciar.

### 55. Parâmetros Variáveis

  Através da palavras reservada **params** na declaração do método temos a possibilidade de receber vários valores dentro de uma varíavel.
   
### 56. Parâmetros Nomeados

  Parâmetros normalmente a serem passados para uma função ou método devem ser informados conforme a sequência em que foi declarado. Entretanto, os parâmetros nomeados é possível fazer a passagem dos parâmetros fora da ordem em que foi declarado, quando passado com a nomeação do parâmetro.

### 57. Getters & Setters

  O atributo dentro de uma classe por padrão ele é atribuido como private, mesmo que não seja declarado.

### 58. Propriedades

### 59. Atributos Readonly  

  É um atributo imutável em tempo de execução. Diferente do comportamento de uma **const** pois já faz a verificação em tempo de compilação.

  Entretanto para que possa ser inicializado um valor imutável dentro do construtor, necessita que seja declarado como **readonly**

### 60. Enumerações (Enum)

### 61. Struct

### 62. Class vs Struct

  São muito parecidos em suas sintaxes entretanto há algumas diferencas que podemos notar. Uma delas é que uma **Struct** ela faz a atribuiçao de seu atributo por **VALOR** e uma **Class** atribui por **REFERÊNCIA**.

### 63. Atribuição por Valor vs Referência

  Mais conceitos e explicações nas declarações por valor(**struct**) e por referência(**class**).

### 64. Parâmetros por Referência (Ref/Out)  

### 65. Exemplos sobre out

### 66. Parâmetro com Valor Padrão

## Seção 6: Coleções

### 67. Array

  Estutura homogênia, não permite tipos diferentes dentro do mesmo array. 

  Estrutura estática não permite alterar o seu tamanho.

  Estrutura indexada. São acessados através de um indice.

### 68. List

  Permite o uso de Generics.

### 69. ArrayList  

  Não permite o uso de Generics.

  Exemplificando com valores heterogêneos.

### 70. Set

  A estrutura **Set** não é indexada.

  O **Set** também é uma estrutura que não aceita repetição.
  
  A estrutura **Set** trata-se de um conjunto.

### 71. Queue

  Observar os devidos import pois há um específico para o que utiliza Generic e outro para a fila simples veja a seguir:

  ```
    //Fila convencional
    using System.Collections;
    //Queue() 

    //Fila com generics
    using System.Collections.Generic;
    //Queue<T>()
  ```

### 72. Igualdade (Equals e GetHashCode)

### 73. Stack

  Para gerar um stack heterogênea, aceitando N valores. Modificar a declaração do using:

  ```
  //De:
  using System.Collections.Generic;

  //Para:
  using System.Collections;
  ```

### 74. Dictionary

  É uma estrutura chave valor, na chave não permite repetição. No valor é permitido repetir.

## Seção 7: Orientação a Objetos

### 75. Os Pilares da OO: Abstração

  Pilares da OO

  **Abstração** é abstrair do mundo real para dentro do sistema.

  Definir algo único.

  Definir os atributos

  Definir os comportamentos

  **Herança**

  **Encapsulamento**

  **Polimorfismo**
  
### 76. Os Pilares da OO: Herança

  Tem por finalizade o reuso de código. E para reuso de código existem alguma forma, o **Ctrl+C e Ctrl+V** é uma das forma mais comuns e uma das práticas mentos indicadas para se utilizar, pois quebra o principio do **DRY** (Dont Repeat Yourself). Além dessa forma temos duas maneiras clássicas que são a **Herança** e a **Composição**.

  **Herança** é um(a)

  **Composição** tem um(a)


### 77. Os Pilares da OO: Encapsulamento

  Tem por finalidade esconder parte do código. Tornando privado aquilo que não é necessário ser exibido para uma outra classe, não fique exposto. Possibilitando uma menor dependência entre classes. Tornando mais restrito.

  Palavras reservadas do C#

  **Public** está acessível a todos. Com o maior nível de visibilidade.

  **Internal** é acessível dentro do projeto.

  **Protect** é transmitido por herança.

  **Private** é o mais restrito acessível/visível somente dentro da classe.

  Dica para definir qual nível de acessibilidade do método/atributo, é coloca-lo do mais restrito, e na medida das necessidades, vai disponibilizando acessos.
  
### 78. Os Pilares da OO: Polimorfismo

  O polimorfismo pode ser dividido em duas forma:

  **Versão estática** seria uma sobrecarga de método.

  **Vesão dinâmica**

### 79. Herança #01

### 80. Herança #02

  Modificação do método Acelerar da Ferrai utilizando o **override** na declaração do método dentro de Ferrari(), lembrando que na classe Carro o método acelerar dever ser inseido na sua assinatura a declaração como **virtual** para permitir a sobrescrita.

  Exemplos de **polimorfismo**

### 81. Construtor: Usando o this

  Na construção do fluxo de um objeto, sempre será necessário haver um construtor, seja feito na propria classe, ou então da classe pai(herdada).

  De forma implicita sempre será chamado um construtor padrão da classe pai, o construtor base que não recebe nenhum parametro. Mas caso não exista este construtor base na classe pai deverá ser necessário informar **: base()**. Mas de forma explicita pode ser chamado o contrutor seja da classe pai ou da própria classe.

  O construtor da propria classe é chamado a partir do **base()** **this()**


### 82. Encapsulamento

  Criação de diversos níveis de acesso entre classes a atributos.

  Criação do projeto Encapsulamento, e inserindo dependência deste ao projeto principal.

  Ao conflitar com a classe Encapsulamento do projeto principal, ajustar o namespace da classe Encapsulamento com o OO.Encapsulamento.

  Sugestão de segurança para uso no dia a dia, inserir os níveis mais restritos de acesso a classes  e atributos, e na medida que surjam as necessidades de acessos de outras classes, analise e faça a liberação de permissão gradativamente.


### 83. Polimorfismo

  Possibilita alterar o comportamento de uma classe a partir de uma outra. 


### 84. Abstract

  Conceitualmente a  classe abstrata, trata-se de um classe inacabada. Que não pode ser instanciada, portanto em caso da necessidade de não permitir que uma classe não seja instanciada aplica-se a classe abstrata para tal caso.

  Caso de uso para a classe abstrata, trata-se de uma classe que normalmente você deseja criar para que seja herdada por outras classes.

  Uma classe abstrata pode ou não ter métodos abstratos.

### Interface

  A interface seria semelhante a uma classe abstrata na qual todos os métodos são abstratos, ou seja, todos os métodos são necessário de serem implementados.

  Um interface possui a vantagem de permitir um classe herdar múltiplas interfaces. Algo que não é permitido entre classes pois a herança entre classes é única 1 p/ 1.


  ## Atalhos do Visual Studio .NET

  **CTRL + K + D**: Formata o código conforme a indentação previamente configurada.(Aula 15. Criando um Projeto C#) contém as orientações de como configurar a forma de organização do código.

  **CTRL + K + C**: Comenta código selecionado com duas barras //.

  **CTRL + K + U**: Descomenta código selecionado.

  **CTRL + D**: Duplica uma linha. Vá para o inicio da linha que deseja duplicar e pressiona na sequencia de tecla.

  **CTRL + TAB**: Visualiza formulários em aberto e permite a seleção e navegação entre eles.

  **CTRL + .**: Com uma classe selecionada visualiza atalhos para construtor e outras opções.

