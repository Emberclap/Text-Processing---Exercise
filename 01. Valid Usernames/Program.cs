namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ")
                .ToArray();

            foreach (string username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    if (username.All(character => char.IsLetterOrDigit(character) || character == '-' || character == '_'))
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}