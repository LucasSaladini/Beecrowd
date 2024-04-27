using System; 

class URI {

    static void Main(string[] args) { 

        double salary = double.Parse(Console.ReadLine());

        if(salary <= 2000)
        {
            System.Console.WriteLine("Isento");
        }
        else if(salary >= 2000.01 && salary <= 3000)
        {
            double temp =  (salary - 2000);
            double taxes = temp * 0.08;
            System.Console.WriteLine("R$ {0:F2}", taxes);
        }
        else if(salary >= 3000.01 && salary <= 4500)
        {
            double temp1 = salary - 3000;
            double temp2 = salary - (2000 + temp1);
            double taxes = temp2 * 0.08 + temp1 * 0.18;
            System.Console.WriteLine("R$ {0:F2}", taxes);
        }
        else
        {
            double temp1 = salary - 4500;
            double temp2 = salary - (temp1 + 3000);
            double temp3 = salary - (temp1 + temp2 +2000);
            double taxes1 = temp1 * 0.28;
            double taxes2 = temp2 * 0.18;
            double taxes3 = temp3 * 0.08;
            double taxes = taxes1 + taxes2 + taxes3;
            System.Console.WriteLine("R$ {0:F2}", taxes);
        }

    }

}
