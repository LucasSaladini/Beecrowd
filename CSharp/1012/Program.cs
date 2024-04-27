using System; 

class URI {

    static void Main(string[] args) { 

        double a, b, c;
	double pi = 3.14159;

	double triangulo, circulo, trapezio, quadrado, retangulo;

	string[] input = Console.ReadLine().Split(' ');

	a = double.Parse(input[0]);
	b = double.Parse(input[1]);
	c = double.Parse(input[2]);

	triangulo = (a * c) / 2;
	circulo = pi * Math.Pow(c, 2);
	trapezio = ((a + b) * c) / 2;
	quadrado = Math.Pow(b, 2);
	retangulo = a * b;

	Console.WriteLine("TRIANGULO: {0:F3}\nCIRCULO: {1:F3}\nTRAPEZIO: {2:F3}\nQUADRADO: {3:F3}\nRETANGULO: {4:F3}", triangulo, circulo, trapezio, quadrado, retangulo);

    }

}
