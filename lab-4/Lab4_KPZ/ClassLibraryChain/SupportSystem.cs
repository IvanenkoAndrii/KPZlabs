using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryChain
{
    public class SupportSystem
    {
        private SupportHandler handlerChain;

        public SupportSystem()
        {
            var level1 = new FirstLevelSupport();
            var level2 = new SecondLevelSupport();
            var level3 = new ThirdLevelSupport();
            var level4 = new FourthLevelSupport();

            level1.SetNextHandler(level2);
            level2.SetNextHandler(level3);
            level3.SetNextHandler(level4);

            this.handlerChain = level1;
        }

        public void Start()
        {
            Console.WriteLine("Ласкаво просимо до системи підтримки користувачів!");

            while (true)
            {
                ShowMenu();
                Console.Write("Ваш вибір: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 0)
                        continue;

                    bool handled = handlerChain.HandleRequest(choice);
                    if (handled)
                        break;
                    else
                        Console.WriteLine("Не вдалося визначити рівень підтримки. Спробуйте ще раз.");
                }
                else
                {
                    Console.WriteLine("Невірний ввід. Будь ласка, введіть число від 1 до 4.");
                }
            }

            Console.WriteLine("\nДякуємо, що звернулися до служби підтримки!");
        }

        private void ShowMenu()
        {
            Console.WriteLine("\nБудь ласка, оберіть тип проблеми:");
            Console.WriteLine("1. Проблеми з рахунком або платежами");
            Console.WriteLine("2. Проблеми з інтернетом або мережею");
            Console.WriteLine("3. Проблеми з обладнанням");
            Console.WriteLine("4. Скарги та спеціальні запити");
            Console.WriteLine("0. Повторити меню");
        }
    }
}