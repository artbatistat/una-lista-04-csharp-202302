int nota = 0;

do
{

Console.Write("Digite uma nota (entre 0 e 10):");
nota = Convert.ToInt16(Console.ReadLine());

if(nota < 0 || nota > 10)
Console.WriteLine("Valor invalida!");
    
}while(nota < 0 || nota > 10);

Console.WriteLine("Nota digitada: {0}",nota);
Console.ReadLine();