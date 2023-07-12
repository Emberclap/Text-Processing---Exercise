namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine()
                .Split("\\")
                .ToArray();
            string fileName = "";
            string fileExtension = "";
            foreach (var word in filePath)
            {
                if (word.Contains('.'))
                {
                    fileName = word.Substring(0, word.IndexOf('.'));
                    fileExtension = word.Substring(word.IndexOf('.')+1);
                }
            }
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}