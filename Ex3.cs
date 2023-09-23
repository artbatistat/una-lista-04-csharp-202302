
bool correto = false;
string nome = "";
int idade = 0;
double salario = 0;
string sexo,estadocivil;


{
    Console.WriteLine("Digite seu nome:");
    nome = Console.ReadLine();

    Console.WriteLine("Digite sua idade:");
    idade = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Digite seu salario:");
    salario = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Qual o seu sexo? \n(F = Feminino) \n(M = Masculino)");
    sexo = Console.ReadLine();

    Console.WriteLine("Qual o seu estado civil: \n(S = Solteiro) \n(C = Casado) \n(V = Viuvo) \n(D = Divorciado)");
    estadocivil = Console.ReadLine();

    if(nome.Length < 3)
    {
        Console.WriteLine("Nome com menos que 3 caracteres.");
        correto = false;
    }
    else if(idade < 0 || idade > 150)
    {
        Console.WriteLine("Idade invalida.");
        correto = false;
    }
    else if(salario < 0)
    {
        Console.WriteLine("Salario invalido.");
        correto = false;
    }
    else if(sexo.ToLower() != "f" && sexo.ToLower() != "m")
    {
        Console.WriteLine("Sexo invalido.");
        correto = false;
    }
    else if(estadocivil.ToLower() != "s" && estadocivil.ToLower() != "c" && estadocivil.ToLower() != "v" && estadocivil.ToLower() != "d")
    {
        Console.WriteLine("Estado civil invalido");
        correto = false;
    }
    else
    {
        correto = true;
    }

}while(correto == false);

Console.WriteLine("Nome: {0} \nIdade: {1} \nSalario: {2} \nSexo: {3} \nEstado Civil: {4}",nome,idade,salario,sexo,estadocivil);
Console.ReadLine();

