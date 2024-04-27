using System; 

class URI {

    static void Main(string[] args) { 

        string[] hours = Console.ReadLine().Split(' ');
        
        int h1 = int.Parse(hours[0]);
        int h2 = int.Parse(hours[1]);
        
        if(h1 > h2)
        {
            int total = (24 - h1) + h2;
            System.Console.WriteLine($"O JOGO DUROU {total} HORA(S)");
        }
        else if(h2 > h1)
        {
            int total = h2 - h1;
            System.Console.WriteLine($"O JOGO DUROU {total} HORA(S)");
        }
        else
        {
            System.Console.WriteLine("O JOGO DUROU 24 HORA(S)");
        }

    }

}
