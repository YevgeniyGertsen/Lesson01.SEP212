using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01.SEP212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 5.	Написать приложение, которое выведет на экран 
             * Ваше имя и фамилию. 
             * (Жду что у вас будет приложение, которое я сам
             * запущу и где у меня попросят ввести ФИО, после я нажму Enter 
             * и мне выдастся сообщение –
             * «Приветствую тебя - ФИО»)
             */

            //string fName = "Yevgeniy";
            //string mName = "Gertsen";

            //Console.WriteLine("Yevgeniy");
            //Console.WriteLine(mName);

            Console.Write("Введите ФИО: ");
            string userName = Console.ReadLine();

            Console.Write("Введите год рождения: ");
            string userAge = Console.ReadLine();

            int currentAge = 2022;
            int userAge_ = Convert.ToInt32(userAge);

            int avalAge = currentAge - userAge_;

            if (avalAge >= 18)
            {
                Console.WriteLine("Приветствую тебя " + userName + "!");
            }
            else
            {
                Console.WriteLine("Слишком молод");
            }

        }
    }
}
