using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma string: ");
        string original = Console.ReadLine();

        char[] caracteres = original.ToCharArray();
        int tamanho = caracteres.Length;

        for (int i = 0; i < tamanho / 2; i++)
        {
            char temp = caracteres[i];
            caracteres[i] = caracteres[tamanho - 1 - i];
            caracteres[tamanho - 1 - i] = temp;
        }

        string invertida = new string(caracteres);
        Console.WriteLine("String original: " + original);
        Console.WriteLine("String invertida: " + invertida);
    }
}
