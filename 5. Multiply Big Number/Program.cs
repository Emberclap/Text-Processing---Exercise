using System.Text;

namespace _5._Multiply_Big_Number
{

    internal class Program
    {
        static void Main(string[] args)
        {
            char[] firstNumber = Console.ReadLine().ToCharArray();
            int secondNumber = int.Parse(Console.ReadLine());
            if (secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder sb = new StringBuilder();

            int parse = 0;
            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                parse = int.Parse(Convert.ToString(firstNumber[i])) * secondNumber + parse;
                sb.Insert(0, (parse % 10));
                parse /= 10;

            }
            if (parse > 0)
            {
                sb.Insert(0, parse);
            }
           
            Console.WriteLine(sb);
        }
    }
}
