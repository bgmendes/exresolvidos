using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        int num1 = 0, num2 = 1, num3, i;
        bool pertence = false;

        Console.Write(num1 + "\n" + num2 + "\n"); // quebra de linha após cada número

        for (i = 2; i < numero; i++)
        {
            num3 = num1 + num2;
            Console.Write(num3 + "\n"); // quebra de linha após cada número
            if (num3 == numero)
            {
                pertence = true;
            }
            num1 = num2;
            num2 = num3;
        }

        if (pertence)
        {
            Console.WriteLine(numero + " - Este número que foi digitado pertence à sequência");
        }
    }
}
