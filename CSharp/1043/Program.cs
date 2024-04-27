using System; 

class URI {

    static void Main(string[] args) { 

        string[] numbers = Console.ReadLine().Split(' ');

        double n1 = double.Parse(numbers[0]);
        double n2 = double.Parse(numbers[1]);
        double n3 = double.Parse(numbers[2]);
        
        if(n1 < n2 + n3 && n2 < n1 + n3 && n3 < n2 + n1)
        {
            double perimetro = n1 + n2 + n3;
            System.Console.WriteLine("Perimetro = {0:F1}", perimetro);
        }
        else
        {
            double area = ((n1 + n2) * n3) / 2;
            System.Console.WriteLine("Area = {0:F1}", area);
        }

    }

}
