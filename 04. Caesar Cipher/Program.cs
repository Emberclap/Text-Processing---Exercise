namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string encryptedText = "";
            foreach (var ch in text)
            {
                int encrypt = ch+3;
                encryptedText += Char.ConvertFromUtf32(encrypt);
            }
            Console.WriteLine(encryptedText);
        }
    }
}