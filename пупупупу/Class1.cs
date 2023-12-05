using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace пупупупу
{
    class Program
    {
        static void Main()
        {
            Animal[] animals = new Animal[]
            {
        new Lion("Лев", "Бегает", "Короткая", "Громкий", "Король"),
        new Tiger("Тигр", "Бегает", "Длинная", "В полоску", "Зимний"),
        new Owl("Сова", "Летает", "Клювастый", "Отличное", 160),
        new Parrot("Попугай", "Летает", "Клювастый", "Яркий", 10),
        new Shark("Акула", "Плавает", "Остроиглая", "Агрессивная", "Плотные уплощенные"),
        new Crocodile("Крокодил", "Плавает", "Хладнокровное", "Мощная", "Серый")
            };

            foreach (var animal in animals)
            {
                animal.ShowProperties();
                Console.WriteLine(animal.ToString());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

