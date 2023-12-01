
## Questão 1 ##

###### Descrição: Lista de Comandos Para verificar se o .NET SDK está instalado corretamente
~~~ c#
dotnet --version - Verifica a versão Dot .NET SDK instalada
dotnet --list-sdks - Lista todas as versões Dot .NET SDK instaladas
dotnet --list-runtimes - Lista todas as versões Dot .NET Runtime instaladas
dotnet --uninstall-sdk <versão> - Remover uma versão específica
dotnet --list-sdks e dotnet --install-sdk <versão> - Atualizar o .NET SDK

Se você estiver usando um sistema operacional diferente, os comandos podem variar um pouco.
~~~
## 2. Tipo de Dados: ##

##### A há vários tipos de dados numéricos inteiros.
~~~ c#

using System;

class Program
{
    static void Main()
    {
        sbyte mySByte = 127;
        byte myByte = 255;
        short myShort = 32767;
        ushort myUShort = 65535;
        int myInt = 2147483647;
        uint myUInt = 4294967295;
        long myLong = 9223372036854775807;
        ulong myULong = 18446744073709551615;

        Console.WriteLine($"sbyte: {mySByte}");
        Console.WriteLine($"byte: {myByte}");
        Console.WriteLine($"short: {myShort}");
        Console.WriteLine($"ushort: {myUShort}");
        Console.WriteLine($"int: {myInt}");
        Console.WriteLine($"uint: {myUInt}");
        Console.WriteLine($"long: {myLong}");
        Console.WriteLine($"ulong: {myULong}");
    }
}

~~~

## 3. Conversão de Tipos de Dados: ##

Resposta: Ao usar um casting para converter um double para int em C#, a parte fracionária é perdida, e apenas a parte inteira do número é mantida. Exemplos

~~~ c#

class Program
{
    static void Main()
    {
        // Variável double com parte fracionária
        double numeroDouble = 10.75;

        // Conversão com casting para int (parte fracionária é perdida)
        int numeroInteiro = (int)numeroDouble;

        // Exibindo os resultados
        Console.WriteLine($"Número double: {numeroDouble}");
        Console.WriteLine($"Conversão para int (com casting): {numeroInteiro}");
    }
}
~~~

## 4. Operadores Aritméticos: ##
 
~~~ c#

using System;

class Program
{
    static void Main()
    {
        // Variáveis
        int x = 10;
        int y = 3;

        // Adição
        int soma = x + y;
        Console.WriteLine($"Adição: {x} + {y} = {soma}");

        // Subtração
        int diferenca = x - y;
        Console.WriteLine($"Subtração: {x} - {y} = {diferenca}");

        // Multiplicação
        int produto = x * y;
        Console.WriteLine($"Multiplicação: {x} * {y} = {produto}");

        // Divisão (observe que a divisão de inteiros resulta em um inteiro)
        int quociente = x / y;
        Console.WriteLine($"Divisão: {x} / {y} = {quociente}");
    }
}


~~~

  ## 5. Operadores Aritméticos## 

~~~ c#
    
 using System;

class Program
{
    static void Main()
    {
        // Variáveis
        int a = 5;
        int b = 8;

        // Verificar se 'a' é maior que 'b'
        if (a > b)
        {
            Console.WriteLine("a é maior que b.");
        }
        else
        {
            Console.WriteLine("a não é maior que b.");
        }
    }
}
~~~

## 6. Operadores de Igualdade: ##

~~~ c#

using System;

class Program
{
    static void Main()
    {
        // Strings
        string str1 = "Hello";
        string str2 = "World";

        // Verificar se as strings são iguais usando o método Equals
        bool saoIguais = str1.Equals(str2);

        // Exibir o resultado
        if (saoIguais)
        {
            Console.WriteLine("As strings são iguais.");
        }
        else
        {
            Console.WriteLine("As strings são diferentes.");
        }
    }
}

~~~

## 7. Operadores Lógicos: ##

~~~ c#
 using System;

class Program
{
    static void Main()
    {
        // Variáveis booleanas
        bool condicao1 = true;
        bool condicao2 = false;

        // Verificar se ambas as condições são verdadeiras usando &&
        if (condicao1 && condicao2)
        {
            Console.WriteLine("Ambas as condições são verdadeiras.");
        }
        else
        {
            Console.WriteLine("Pelo menos uma das condições é falsa.");
        }
    }
}
~~~

## 8. Desafio de Mistura de Operadores: ##

~~~ c#
using System;

class Program
{
    static void Main()
    {
        // Variáveis
        int num1 = 7;
        int num2 = 3;
        int num3 = 10;

        // Verificar se num1 é maior do que num2
        bool condicao1 = num1 > num2;

        // Verificar se num3 é igual a num1 + num2
        bool condicao2 = num3 == num1 + num2;

        // Exibir os resultados
        if (condicao1)
        {
            Console.WriteLine("num1 é maior do que num2.");
        }
        else
        {
            Console.WriteLine("num1 não é maior do que num2.");
        }

        if (condicao2)
        {
            Console.WriteLine("num3 é igual a num1 + num2.");
        }
        else
        {
            Console.WriteLine("num3 não é igual a num1 + num2.");
        }
    }
}
~~~