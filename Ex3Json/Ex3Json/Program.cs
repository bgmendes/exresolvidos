using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        string jsonString = File.ReadAllText(@"caminho/do/arquivo.json");
        List<FaturamentoDiario> faturamentoMensal = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(jsonString);

        decimal menorFaturamento = decimal.MaxValue;
        decimal maiorFaturamento = decimal.MinValue;
        decimal somaFaturamento = 0;
        int diasAcimaDaMedia = 0;

        foreach (FaturamentoDiario dia in faturamentoMensal)
        {
            if (dia.Valor < menorFaturamento && dia.Valor > 0)
            {
                menorFaturamento = dia.Valor;
            }

            if (dia.Valor > maiorFaturamento)
            {
                maiorFaturamento = dia.Valor;
            }

            if (dia.Valor > 0)
            {
                somaFaturamento += dia.Valor;
            }
        }

        decimal mediaMensal = somaFaturamento / faturamentoMensal.Count(dia => dia.Valor > 0);

        foreach (FaturamentoDiario dia in faturamentoMensal)
        {
            if (dia.Valor > mediaMensal)
            {
                diasAcimaDaMedia++;
            }
        }

        Console.WriteLine("Menor faturamento: " + menorFaturamento);
        Console.WriteLine("Maior faturamento: " + maiorFaturamento);
        Console.WriteLine("Dias acima da média: " + diasAcimaDaMedia);
    }
}

class FaturamentoDiario
{
    public int Dia { get; set; }
    public decimal Valor { get; set; }
}
