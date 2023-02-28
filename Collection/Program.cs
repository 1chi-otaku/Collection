using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        public static void FrequencyDictionary()
        {
            Dictionary<string,int> dictionary = new Dictionary<string,int>();
            Console.WriteLine("Enter text: ");
            string str = Console.ReadLine();
            string[] mas = str.Split(' ', '.', ',', '-', '!', '?');
            int count = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i+1; j < mas.Length; j++)
                {
                    if (mas[i] == mas[j])
                        count++;
                }
                if (!dictionary.ContainsKey(mas[i]))
                {
                    dictionary.Add(mas[i], count);
                }
                count = 1;
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }
        public static void EngRusDictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Blueberry", "Голубика");
            dictionary.Add("Colour", "Цвет");
            dictionary.Add("Destiny", "Судьба");

            int choice = -1;

            while (choice != 0)
            {
                Console.Clear();
                Console.WriteLine("1 - Print Dictionary");
                Console.WriteLine("2 - Search");
                Console.WriteLine("3 - Add");
                Console.WriteLine("0 - Exit");

                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        foreach (var item in dictionary)
                            Console.WriteLine(item);
                        break;
                    case 2:
                        Console.WriteLine("1 - Search English word");
                        Console.WriteLine("2 - Search Russian word");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice != 1 && choice != 2) break;
                        Console.WriteLine("Enter a word:");
                        string search = Console.ReadLine();
                        if(choice == 1)
                        {
                            if (dictionary.ContainsKey(search))
                                Console.WriteLine(" '{0}' - '{1}'", search, dictionary[search]);
                            else
                                Console.WriteLine("Failed.");
                        }
                        else
                        {
                            if (dictionary.ContainsValue(search))
                                Console.WriteLine(" '{0}' - '{1}'", dictionary[search], search);
                            else
                                Console.WriteLine("Failed.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter word on English");
                        string eng = Console.ReadLine();
                        Console.WriteLine("Enter word on russian");
                        dictionary.Add(eng, Console.ReadLine());
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
            
           
        }
        static void Main(string[] args)
        {
            #region lab
            //FrequencyDictionary();
            #endregion
            #region hw
            EngRusDictionary();
            #endregion
        }



    }
}
