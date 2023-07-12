using System.ComponentModel.Design;
using System.Text;

namespace _7._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            int explosionStrenght = 0;
            for (int i = 0; i < input.Length; i++)
            {
                
                if (input[i] == '>' && Char.IsDigit(input[i+1]))
                {
                    explosionStrenght += int.Parse(Convert.ToString(input[i + 1]));
                    sb.Append(input[i]);
                }
                else if (explosionStrenght > 0)
                {
                    explosionStrenght--;
                }
                else 
                {
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb);
        }
    }
}