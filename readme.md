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




  ---
  ---

  ## Atalhos do Visual Studio .NET

  **CTRL + K + D**: Formata o código conforme a indentação previamente configurada.(Aula 15. Criando um Projeto C#) contém as orientações de como configurar a forma de organização do código.

  **CTRL + K + C**: Comenta código selecionado com duas barras //.

  **CTRL + K + U**: Descomenta código selecionado.

  **CTRL + D**: Duplica uma linha. Vá para o inicio da linha que deseja duplicar e pressiona na sequencia de tecla.

  **CTRL + TAB**: Visualiza formulários em aberto e permite a seleção e navegação entre eles.
