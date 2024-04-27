using System;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        Dictionary<string, string> ddd = new Dictionary<string, string>
        {
            {"61", "Brasilia"},
            {"71", "Salvador"},
            {"11", "Sao Paulo"},
            {"21", "Rio de Janeiro"},
            {"32", "Juiz de Fora"},
            {"19", "Campinas"},
            {"27", "Vitoria"},
            {"31", "Belo Horizonte"}
        };
        
        string dddBusca = Console.ReadLine();
        
        if(ddd.TryGetValue(dddBusca , out string dddEncontrado)){
            System.Console.WriteLine(dddEncontrado);
        }
        else
        {
            System.Console.WriteLine($"DDD nao cadastrado");
        }

    }

}
