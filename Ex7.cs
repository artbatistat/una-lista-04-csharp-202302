int impar = 0;
int par = 0;

for(int i = 0; i < 10 ; i++)
{
    Console.WriteLine("Digite um numero:");
    int num = Convert.ToInt16(Console.ReadLine());

    if(num % 2 == 1)
    impar++;
    else
    par++;
}

Console.WriteLine("Números pares: {0} \nNúmeros impares: {1}",par,impar);
Console.ReadLine();
