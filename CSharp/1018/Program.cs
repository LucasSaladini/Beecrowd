using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int numeroNotas = int.Parse(Console.ReadLine());
        int[] notasPossiveis = new int[] { 100, 50, 20, 10, 5, 2, 1};

        System.Console.WriteLine(numeroNotas);
        
        for (int i = 0; i < notasPossiveis.Length; i++)
        {
            int notas = numeroNotas / notasPossiveis[i];
            System.Console.WriteLine(notas + " nota(s) de R$ " + notasPossiveis[i].ToString("F2", CultureInfo.CreateSpecificCulture("pt-BR")));

            numeroNotas = numeroNotas % notasPossiveis[i];
        }

    }

}
