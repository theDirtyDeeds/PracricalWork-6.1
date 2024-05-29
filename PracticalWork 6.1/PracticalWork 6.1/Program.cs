using System.Reflection.Metadata;

namespace PracticalWork_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие: \n1: Запись.\n2: Чтение.");

            int userChoise = Convert.ToInt32(Console.ReadLine());

            switch (userChoise)
            {
                case 1:
                    Recording();
                    break;
                case 2:
                    Reading();
                    break;
            }
        }

        static string Recording()
        {

            Console.WriteLine("Введите данные нового сотрудника: ");

            Console.WriteLine("ID: ");

            int iD = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ФИО: ");

            string name = Console.ReadLine();

            Console.WriteLine("Возраст: ");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Рост: ");

            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Дата рождения: ");

            string birthDay = Console.ReadLine();

            Console.WriteLine("Место рождения: ");

            string birthPlace = Console.ReadLine();

            string employerData = $"{iD},{DateTime.Now:g},{name},{age},{height},{birthDay},{birthPlace}";

            string[] employer = employerData.Split(" ");

            foreach (string e in employer)
            {
                Console.WriteLine(e);
            }

            File.AppendAllText(@"E:\data.txt", employerData + Environment.NewLine);

            Console.WriteLine("Сотрудник добавлен");

            return employerData;

        }
        static string Reading()
        {
            string path = @"E:\data.txt";

            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                using (StreamReader reader = fileInfo.OpenText()) 
                {
                    string text = reader.ReadToEnd();
                    
                    Console.WriteLine(text);
                }
            }

            return path;
        }


    }
}
