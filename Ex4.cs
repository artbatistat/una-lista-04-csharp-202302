double num = 0;
double soma = 0;

for(int i = 0; i < 5;i++)
{
    Console.WriteLine("Digite um número:");
    num = Convert.ToDouble(Console.ReadLine());
    soma += num;
}

Console.WriteLine("Soma dos números: {0}",soma);
Console.WriteLine("Média dos números: "+((soma)/5));
Console.ReadLine();
