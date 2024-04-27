using System; 

class URI {

    static void Main(string[] args) { 

        double x1, y1, x2, y2;
        
        string[] p1 = Console.ReadLine().Split(' ');
        x1 = double.Parse(p1[0]);
        y1 = double.Parse(p1[1]);

        string[] p2 = Console.ReadLine().Split(' ');
        x2 = double.Parse(p2[0]);
        y2 = double.Parse(p2[1]);

        double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        
        Console.WriteLine("{0:F4}", result);

    }

}
