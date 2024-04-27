using System; 

class URI {

    static void Main(string[] args) { 

        string level1 = Console.ReadLine();
        string level2 = Console.ReadLine();
        string level3 = Console.ReadLine();
        
        if(level1 == "vertebrado")
        {
            if(level2 == "ave")
            {
                if(level3 == "carnivoro")
                {
                    System.Console.WriteLine("aguia");
                }
                else if(level3 == "onivoro")
                {
                    System.Console.WriteLine("pomba");
                }
            }
            else if(level2 == "mamifero")
            {
                if(level3 == "onivoro")
                {
                    System.Console.WriteLine("homem");
                }
                else if(level3 == "herbivoro")
                {
                    System.Console.WriteLine("vaca");
                }
            }
        }
        else if(level1 == "invertebrado")
        {
            if(level2 == "inseto")
            {
                if(level3 == "hematofago")
                {
                    System.Console.WriteLine("pulga");
                }
                else if(level3 == "herbivoro")
                {
                    System.Console.WriteLine("lagarta");
                }
            }
            else if(level2 == "anelideo")
            {
                if(level3 == "hematofago")
                {
                    System.Console.WriteLine("sanguessuga");
                }
                else if(level3 == "onivoro")
                {
                    System.Console.WriteLine("minhoca");
                }
            }
        }
    }

}
