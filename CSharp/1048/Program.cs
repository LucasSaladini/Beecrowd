using System; 

class URI {

    static void Main(string[] args) { 

        double salary = double.Parse(Console.ReadLine());
        
        if(salary <= 400)
        {
            double adjustment = salary * 0.15;
            double newSalary = adjustment + salary;
            System.Console.WriteLine("Novo salario: {0:F2}", newSalary);
            System.Console.WriteLine("Reajuste ganho: {0:F2}", adjustment);
            System.Console.WriteLine("Em percentual: 15 %");
        }
        else if(salary >= 400.01 && salary <= 800)
        {
            double adjustment = salary * 0.12;
            double newSalary = adjustment + salary;
            System.Console.WriteLine("Novo salario: {0:F2}", newSalary);
            System.Console.WriteLine("Reajuste ganho: {0:F2}", adjustment);
            System.Console.WriteLine("Em percentual: 12 %");
        }
        else if(salary >= 800.01 && salary <= 1200)
        {
            double adjustment = salary * 0.10;
            double newSalary = adjustment + salary;
            System.Console.WriteLine("Novo salario: {0:F2}", newSalary);
            System.Console.WriteLine("Reajuste ganho: {0:F2}", adjustment);
            System.Console.WriteLine("Em percentual: 10 %");
        }
        else if(salary >= 1200.01 && salary <= 2000)
        {
            double adjustment = salary * 0.07;
            double newSalary = adjustment + salary;
            System.Console.WriteLine("Novo salario: {0:F2}", newSalary);
            System.Console.WriteLine("Reajuste ganho: {0:F2}", adjustment);
            System.Console.WriteLine("Em percentual: 7 %");
        }
        else
        {
            double adjustment = salary * 0.04;
            double newSalary = adjustment + salary;
            System.Console.WriteLine("Novo salario: {0:F2}", newSalary);
            System.Console.WriteLine("Reajuste ganho: {0:F2}", adjustment);
            System.Console.WriteLine("Em percentual: 4 %");
        }

    }

}
