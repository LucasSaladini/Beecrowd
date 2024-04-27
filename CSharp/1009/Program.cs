using System; 

class URI {

    static void Main(string[] args) { 

        string nome = Console.ReadLine();
        double salario = Math.Round(double.Parse(Console.ReadLine()), 2);
        double venda = Math.Round(double.Parse(Console.ReadLine()), 2);

        double salarioFinal = (venda * 0.15) + salario;
        
        Console.WriteLine($"TOTAL = R$ {salarioFinal.ToString("0.00")}");
    }
}
