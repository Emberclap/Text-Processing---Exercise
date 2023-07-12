namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();
            string word1 = input[0];
            string word2 = input[1];
            Console.WriteLine(Multiplier(word1, word2));


        }
        static int Multiplier(string word1, string word2)
        {
            int characterSum = 0;
            string longestWord = word1;
            string shortWord =  word2;
            if (word2.Length >= word1.Length)
            {
                longestWord = word2;
                shortWord = word1;
            }
            for (int i = 0; i < longestWord.Length; i++)
            {
                if (i < shortWord.Length)
                {
                    characterSum += word1[i] * word2[i];
                }
                else
                {
                    characterSum += longestWord[i];
                }
            }
            return characterSum;
        }
    }
}