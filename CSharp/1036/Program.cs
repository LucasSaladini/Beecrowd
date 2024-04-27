using System; 

class URI {

    static void Main(string[] args) { 

        string[] input =Console.ReadLine().Split(' ');
        
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);
        double root = Math.Sqrt(Math.Pow(b,2) - (4*a*c));
        
        if(root < 0 || a == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else if(double.IsNaN(root))
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            double result1 = (-b + root) / (2*a);
            double result2 = (-b - root) / (2*a);
        
            System.Console.WriteLine("R1 = {0:F5}", result1);
            System.Console.WriteLine("R2 = {0:F5}", result2);
        }

    }

}
