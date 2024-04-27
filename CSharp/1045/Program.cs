using System; using System.Linq;

namespace Uri1045 { 
internal class Program { static void Main(string[] args) { 
	double A, B, C; double[] vetNums = new double[3]; string[] num = Console.ReadLine().Split(' ');

        for (int i = 0; i < num.Length; i++)
        {
            vetNums[i] = double.Parse(num[i].Replace('.', ','));
        }
        vetNums = vetNums.OrderByDescending(x => x).ToArray();

        A = vetNums[0];
        B = vetNums[1];
        C = vetNums[2];

        if (A >= B + C)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else if (A * A == B * B + C * C)
        {
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        else if (A * A > B * B + C * C)
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        else if (A * A < B * B + C * C)
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }

        if (A == B && B == C)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        else if (A == B || B == C || A == C)
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
        Console.ReadLine();
	    }
	}

}
