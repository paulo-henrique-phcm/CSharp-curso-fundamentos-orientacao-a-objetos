# Anotações Fundamentos de Orientação a Objetos com C# Balta.io
Neste repositório eu listo as anotações que fiz conforme pratiquei os aprendizados adquiridos no curso `Fundamentos de Orientação a Objetos` com C# da plataforma `Balta.io`.

Obs.: As anotações não abrangem todo o conteúdo do curso, somente aqueles que achei pertinente anotar, isso por que já possuo certa experiência com a linguagem `Python` onde já atuei com `orientação a objetos`. Além disso os exemplos que usei aqui não são os mesmos do curso com finalidade de exercitar os conceitos em casos de uso diferentes.

Espero que minhas breves anotações sejam úteis para aqueles que estão começando com `C#` assim como eu.

# Desmistificando C# com Classes, Herança e Comparação

## 1. Classes Abstratas e Interfaces: Estabelecendo Fundamentos

### 1.1 Classes Abstratas: Criando Modelos
**O que são?**
Classes abstratas são como esboços para criar diferentes tipos de objetos. No exemplo, imaginamos que queremos modelar veículos, e criamos a classe abstrata `Veiculo` com métodos `Mover` e `Parar`. Essa classe não permite a criação direta de instâncias, mas estabelece comportamentos essenciais.

```csharp
public abstract class Veiculo
{
    public abstract void Mover();
    public abstract void Parar();
}
```

**Por que são úteis?**
Elas fornecem uma estrutura base, permitindo que classes derivadas, como `Carro` ou `Aviao`, preencham os detalhes específicos de como cada veículo se move e para.

### 1.2 Interfaces: Contratos de Comportamento
**O que são?**
Interfaces são contratos que garantem que as classes sigam regras específicas. No exemplo, criamos a interface `IAutonomia` com métodos `Recarregar` e `VerificarNivel`. Diferentes classes, como `CarroEletrico` e `AviaoCombustivel`, podem implementar essa interface de maneiras únicas.

```csharp
public interface IAutonomia
{
    void Recarregar();
    void VerificarNivel();
}
```

**Por que são úteis?**
Elas permitem que diferentes classes compartilhem comportamentos comuns, mas ainda forneçam implementações específicas, como diferentes veículos implementando métodos específicos de autonomia.

## 2. Upcast e Downcast: Navegando pelo Universo dos Objetos

### 2.1 Upcast: Ampliando Perspectivas
**O que é?**
Upcast é a capacidade de tratar um objeto de uma classe derivada como se fosse da classe base. No exemplo, transformamos um `Cachorro` em um simples `Animal`.

```csharp
Animal animal = new Cachorro();
```

**Por que é útil?**
Permite manipular objetos de maneira genérica, útil quando queremos tratar diferentes tipos de animais de forma uniforme, mesmo que sejam classes derivadas.

### 2.2 Downcast: Detalhes Específicos
**O que é?**
Downcast é o oposto do Upcast, transformando um objeto da classe base de volta em um tipo mais específico, como um `Gato`.

```csharp
Gato meuGato = (Gato)animal;
```

**Por que é útil?**
Permite acessar métodos e propriedades específicos da classe derivada, útil quando precisamos das características exclusivas de um tipo específico de animal.

## 3. Comparação de Objetos: Identificando Semelhanças

### 3.1 Igualdade de Referência: Compartilhando Objetos
**O que é?**
Igualdade de referência verifica se duas variáveis apontam para o mesmo objeto na memória. No exemplo, temos duas instâncias da classe `Pessoa` que compartilham a mesma referência.

```csharp
Pessoa pessoa1 = new Pessoa("João");
Pessoa pessoa2 = pessoa1;

bool saoIguais = (pessoa1 == pessoa2);  // true, ambos apontam para o mesmo objeto
```

**Por que é útil?**
Ajuda a identificar se duas variáveis estão referenciando o mesmo objeto, útil para situações onde queremos saber se dois objetos são, na verdade, o mesmo.

### 3.2 Método `Equals()`: Comparação de Propriedades
**O que é?**
O método `Equals()` compara o conteúdo de dois objetos. Vamos usar um exemplo com a classe `Pessoa`, onde a igualdade depende da implementação das propriedades.

```csharp
Pessoa pessoa1 = new Pessoa("João");
Pessoa pessoa2 = new Pessoa("João");

bool saoIguais = pessoa1.Equals(pessoa2);  // Depende da implementação de Equals() na classe Pessoa
```

**Por que é útil?**
Permite uma comparação mais flexível e personalizada, baseada no conteúdo dos objetos, útil para objetos onde a igualdade é definida por suas propriedades específicas.

### 3.3 Implementação de `IEquatable<T>`: Personalizando a Comparação
**O que é?**
A interface `IEquatable<T>` permite criar regras específicas para comparar objetos. Vamos criar um exemplo com a classe `Livro` e a comparação baseada no título.

```csharp
public class Livro : IEquatable<Livro>
{
    public string Titulo { get; set; }

    public bool Equals(Livro other)
    {
        return this.Titulo == other.Titulo;
    }
}
```

**Por que é útil?**
Fornece uma maneira estruturada e personalizada de comparar objetos, especialmente útil quando precisamos definir critérios específicos de igualdade, como comparar livros pelo título.

## 4. Delegates e Eventos: Comunicação Dinâmica

### 4.1 Delegates: Orquestrando Ações
**O que são?**
Delegates são como instruções de controle, úteis para coordenar ações entre diferentes partes do código. No exemplo, definimos um `ComandoDeJogo` que pode ser atribuído a diferentes métodos.

```csharp
public delegate void ComandoDeJogo();
```

**Por que são úteis?**
Permitem flexibilidade na execução de ações, especialmente quando diferentes partes do código precisam se comunicar sem depender diretamente umas das outras.

### 4.2 Eventos: Notificando Acontecimentos Importantes
**O que são?**
Eventos são como alertas, notificando partes do código sobre eventos específicos. No exemplo, criamos um `SistemaNotificacao` que permite que objetos se inscrevam para serem notificados quando um evento ocorre.

```csharp
public class SistemaNotificacao
{
    public event ComandoDeJogo NotificarEvento;
}
```

**Por que são úteis?**
Facilitam a comunicação entre diferentes partes do código, permitindo que objetos respondam a eventos específicos sem depender diretamente uns dos outros.

Ao explorar esses conceitos interconectados, você estará mais preparado para compreender e utilizar classes, herança e comparação em C#. Se tiver mais dúvidas ou quiser explorar algum aspecto específico, estou aqui para ajudar!


# Entendendo Generics em C#: Flexibilidade Sem Sacrificar Tipo

## 1. O que são Generics?

Generics em C# proporcionam flexibilidade na criação de estruturas, métodos e classes, permitindo que operem com diferentes tipos de dados sem sacrificar a segurança de tipo. Em vez de definir um tipo específico, você pode criar componentes que trabalham com tipos genéricos, proporcionando reutilização de código e maior abstração.

## 2. Declarando uma Classe Genérica

Vamos criar uma classe de Pilha genérica como exemplo:

```csharp
public class Pilha<T>
{
    private List<T> itens = new List<T>();

    public void Empilhar(T item)
    {
        itens.Add(item);
    }

    public T Desempilhar()
    {
        if (itens.Count == 0)
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }

        T item = itens[itens.Count - 1];
        itens.RemoveAt(itens.Count - 1);
        return item;
    }
}
```

Nesta classe, `T` é um parâmetro de tipo genérico. Isso significa que você pode usar a mesma implementação da pilha para diferentes tipos de dados.

## 3. Utilizando a Classe Genérica

Vamos agora usar a classe genérica `Pilha` com diferentes tipos:

```csharp
class Program
{
    static void Main()
    {
        // Pilha de inteiros
        Pilha<int> pilhaDeInteiros = new Pilha<int>();
        pilhaDeInteiros.Empilhar(1);
        pilhaDeInteiros.Empilhar(2);
        int numeroDesempilhado = pilhaDeInteiros.Desempilhar();

        // Pilha de strings
        Pilha<string> pilhaDeStrings = new Pilha<string>();
        pilhaDeStrings.Empilhar("Olá");
        pilhaDeStrings.Empilhar("Mundo");
        string palavraDesempilhada = pilhaDeStrings.Desempilhar();
    }
}
```

Aqui, temos duas pilhas, uma para inteiros e outra para strings, ambas usando a mesma implementação da classe genérica `Pilha`.

## 4. Vantagens de Generics

- **Reutilização de Código:** A mesma implementação pode ser utilizada para diversos tipos de dados.
- **Segurança de Tipo:** O compilador verifica os tipos em tempo de compilação, evitando erros de tipo em tempo de execução.
- **Desempenho:** Não há perda de desempenho, pois os tipos são conhecidos em tempo de compilação.

Generics são uma ferramenta poderosa em C#, proporcionando flexibilidade e segurança de tipo. Se surgirem dúvidas ou se precisar de mais exemplos, sinta-se à vontade para perguntar!





# Entendendo Tratamento de Erros em C#: Garantindo Robustez em Sua Aplicação

## 1. O que é Tratamento de Erros?

O tratamento de erros em C# é uma prática essencial para garantir que sua aplicação seja robusta e capaz de lidar com situações inesperadas. Ele envolve a identificação, captura e manipulação de exceções durante a execução do programa, permitindo que você forneça uma resposta adequada a erros que possam ocorrer.

## 2. Lidando com Exceções

Usando um exemplo simples:

```csharp
public class Calculadora
{
    public int Dividir(int numerador, int denominador)
    {
        try
        {
            return numerador / denominador;
        }
        catch (DivideByZeroException ex)
        {
            // Captura a exceção específica de divisão por zero
            Console.WriteLine($"Erro: {ex.Message}");
            return 0;  // Valor padrão para situações de exceção
        }
        catch (Exception ex)
        {
            // Captura outras exceções não previstas
            Console.WriteLine($"Erro não esperado: {ex.Message}");
            throw;  // Lança a exceção novamente após tratamento
        }
    }
}
```

Neste exemplo, a classe `Calculadora` possui um método `Dividir` que pode gerar exceções, como divisão por zero. O bloco `try-catch` permite lidar com essas exceções de maneira controlada.

## 3. Utilizando Tratamento de Erros

Vamos agora utilizar a classe `Calculadora`:

```csharp
class Program
{
    static void Main()
    {
        Calculadora minhaCalculadora = new Calculadora();

        int resultado = minhaCalculadora.Dividir(10, 2);  // Resultado: 5

        // Tratando um possível erro
        int resultadoComErro = minhaCalculadora.Dividir(5, 0);  // Resultado: 0
    }
}
```

Aqui, ao tentar dividir por zero, o tratamento de erro evita que a aplicação quebre, permitindo que você tome medidas adequadas.

## 4. Importância do Tratamento de Erros

- **Robustez da Aplicação:** Evita que a aplicação quebre devido a situações inesperadas.
- **Identificação de Problemas:** Facilita a identificação e resolução de problemas durante o desenvolvimento e em produção.
- **Experiência do Usuário:** Contribui para uma melhor experiência do usuário ao lidar com erros de forma controlada.

O tratamento de erros é uma prática crucial em programação, proporcionando confiabilidade e robustez ao seu código. Se tiver perguntas ou quiser explorar mais exemplos, estou aqui para ajudar!

# Entendendo o Contexto de Notificações em C#

## 1. O que são Notificações?

O contexto de notificações em C# é uma abordagem que visa lidar com validações e erros de maneira mais flexível, sem interromper a execução do código. Em vez de lançar exceções, as notificações coletam informações sobre problemas encontrados durante a execução e permitem um tratamento mais controlado.

## 2. A Classe `Notification`

A classe `Notification` representa uma notificação específica, contendo informações sobre a propriedade relacionada e a mensagem de erro. Isso é útil para fornecer feedback detalhado sobre o que deu errado.

```csharp
namespace Balta.NotificationContext
{
    public sealed class Notification
    {
        public Notification()
        {
        }

        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; set; }

        public string Message { get; set; }
    }
}
```

## 3. A Classe `Notifiable`

A classe `Notifiable` é uma classe abstrata que serve como base para objetos que desejam suportar notificações. Ela contém uma lista de notificações e métodos para adicionar notificações individualmente ou em lote.

```csharp
namespace Balta.NotificationContext
{
    public abstract class Notifiable
    {
        public Notifiable()
        {
            Notifications = new List<Notification>();
        }

        public List<Notification> Notifications { get; set; }

        public void AddNotifications(IEnumerable<Notification> notification)
        {
            this.Notifications.AddRange(notification);
        }

        public void AddNotification(Notification notification)
        {
            this.Notifications.Add(notification);
        }

        public bool IsInvalid => Notifications.Any();
    }
}
```

## 4. Utilizando o Contexto de Notificações

Vamos agora ver como usar o contexto de notificações em uma classe concreta:

```csharp
public class Cliente : Notifiable
{
    public string Nome { get; set; }

    public void Registrar()
    {
        if (string.IsNullOrEmpty(Nome))
        {
            AddNotification(new Notification("Nome", "Nome é um campo obrigatório."));
        }

        // Outras validações e lógica de negócios...

        if (IsInvalid)
        {
            // Tratar notificações, como enviar mensagens ao usuário ou registrar em logs.
        }
        else
        {
            // Lógica para registrar o cliente.
        }
    }
}
```

Aqui, a classe `Cliente` herda de `Notifiable` e pode usar os métodos para adicionar notificações. Ao final do método `Registrar`, você pode verificar se há notificações e tomar decisões apropriadas.

## 5. Benefícios do Contexto de Notificações

- **Tratamento Flexível:** Permite que o código continue a ser executado mesmo com notificações.
- **Feedback Detalhado:** Fornece informações detalhadas sobre problemas encontrados.
- **Controle na Lógica de Negócios:** Facilita a integração de validações na lógica de negócios.

O contexto de notificações é uma abordagem útil para lidar com validações e erros de forma mais controlada, especialmente em cenários onde interromper a execução do código não é desejado. A escolha entre notificações e exceções depende das necessidades específicas do projeto e das preferências da equipe de desenvolvimento.