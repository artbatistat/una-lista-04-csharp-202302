string user = "";
string password = "";

do
{
    Console.WriteLine("Digite um nome de usuario:");
    user = Console.ReadLine();
    Console.WriteLine("Digite uma senha:");
    password = Console.ReadLine();

    if(user.ToLower() == password.ToLower())
    Console.WriteLine("A senha não pode ser nome de usuario! Tente novamente.");

}while(user.ToLower() == password.ToLower());

Console.WriteLine("Usuario e senha cadastrados com sucesso!");
Console.ReadLine();