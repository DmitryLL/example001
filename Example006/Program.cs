Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "sad")
{
    Console.WriteLine("Ура, это же sad");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username); 
}