namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> words = [];

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Woorden: {words.Count}");

                Console.WriteLine("Geef een woord");
                string command = Console.ReadLine();
                
                if (command.ToLower() == "stop")

                {
                    break;
                }
                if (command.ToLower() == "list")
                {
                    foreach (var word in words)
                    {
                        Console.WriteLine(word);
                    }
                    Console.ReadLine();
                }
                else if (command == "letters")
                {

                    var word = words[];

                    while (word.Length > 0)
                    {
                        int count = 0;
                        for (int i = 0; i < word.Length; i++)
                        {
                            if (word[0] == word[i])
                            {
                                count++;
                            }
                           
                        }

                    Console.WriteLine($"karakter '{word[0]}' komt {count} voor");
                    word = word.Replace(word[0].ToString(), string.Empty);
                    }
                    Console.ReadLine();
                }
                words.Add(command);
            }
                Console.WriteLine("dit is je resultaat");
            

            
        }
    }
}
