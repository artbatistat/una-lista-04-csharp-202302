Random random = new Random();

Console.WriteLine("Digite um número:");
int num1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite um número:");
int num2 = Convert.ToInt16(Console.ReadLine());

if(num1 < num2)
{
    int menor = num1;
    int maior = num2;
    Console.WriteLine("Número aleatorio gerado: "+random.Next(menor,maior));
    Console.ReadLine();
}
else if(num2 < num1)
{
    int menor = num2;
    int maior = num1;
    Console.WriteLine("Número aleatorio gerado: "+random.Next(menor,maior));
    Console.ReadLine();
}
else
{
    Console.WriteLine("Os números digitados são iguais. \n Número: {0}",num1);
    Console.ReadLine();
}

