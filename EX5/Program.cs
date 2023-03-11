Console.Write("Введите имя Пользователя, ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, Привет, Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
