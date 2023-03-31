using System;

class Program
{
    static void Main(string[] args)
    {
        double total = 0.0;

        // Armazenando o faturamento de cada estado em um dicionário
        var faturamento = new Dictionary<string, double>() {
      {"SP", 67836.43},
      {"RJ", 36678.66},
      {"MG", 29229.88},
      {"ES", 27165.48},
      {"Outros", 19849.53}
    };

        // Calculando o faturamento total
        foreach (var estado in faturamento)
        {
            total += estado.Value;
        }

        // Calculando o percentual de representação de cada estado
        foreach (var estado in faturamento)
        {
            double percentual = (estado.Value / total) * 100;
            Console.WriteLine(estado.Key + " - " + percentual.ToString("F2") + "%");
        }
    }
}
