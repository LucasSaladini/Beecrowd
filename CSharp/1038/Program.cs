using System;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        Dictionary<int, double> food = new Dictionary<int, double>();

        food.Add(1, 4.00);
        food.Add(2, 4.50);
        food.Add(3, 5.00);
        food.Add(4, 2.00);
        food.Add(5, 1.50);
        
        string[] order = Console.ReadLine().Split(' ');
        
        int x = int.Parse(order[0]);
        int y = int.Parse(order[1]);
        
        double result = food[x] * y;
        
        Console.WriteLine("Total: R$ {0:F2}", result);

    }

}
