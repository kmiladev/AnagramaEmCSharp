using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Chama o método imprimirAnagramas diretamente, já que ele agora é estático
        string palavra1 = "amor";
        string palavra2 = "roma";

        imprimirAnagramas(palavra1, palavra2);
    }

    private static void imprimirAnagramas(string p01, string p02)
    {
        // Converter em lista usando letras maiúsculas para facilitar a comparação.
        char[] char1 = p01.ToUpper().ToCharArray();
        char[] char2 = p02.ToUpper().ToCharArray();

        // Ordenar alfabeticamente.
        Array.Sort(char1);
        Array.Sort(char2);

        // Armazenar em nova variável a palavra já ordenada e formatada
        string novaP01 = new string(char1);
        string novaP02 = new string(char2);

        // Comparar as duas novas strings e aplicar uma condicional reduzida
        string resultado = novaP01 == novaP02 ? "Isto é um Anagrama" : "Isto não é um Anagrama";

    // imprimindo informações na tela

        Console.WriteLine("Verificando se as duas palavras impressas na tela são Anagramas");
        Console.WriteLine("A palavra 01 é: " + p01 + " e a palavra 2 é: " + p02);
        Console.WriteLine(resultado);

    }
}
   
