using System;
using System.Text;
using System.Threading;
using KPZLab2.Factory_method;
using KPZLab2.Abstract_factory;
using KPZLab2.Singelton;
using KPZLab2.Prototype;
using KPZLab2.Builder;

namespace KPZLab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Оберіть режим роботи програми:");
            Console.WriteLine("1. Придбання підписки");
            Console.WriteLine("2. Виробництво техніки");
            Console.WriteLine("3. Тест Authenticator (Одинак)");
            Console.WriteLine("4. Тест Virus Prototype");
            Console.WriteLine("5. Тест Builder (Герой та Ворог)");
            Console.Write("Ваш вибір: ");
            string modeChoice = Console.ReadLine();

            if (modeChoice == "1")
            {
                RunSubscriptionPurchase();
            }
            else if (modeChoice == "2")
            {
                RunDeviceFactory();
            }
            else if (modeChoice == "3")
            {
                RunAuthenticatorTest();
            }
            else if (modeChoice == "4")
            {
                RunVirusPrototypeTest();
            }
            else if (modeChoice == "5")
            {
                RunBuilderTest();
            }
            else
            {
                Console.WriteLine("Невірний вибір");
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }

        static void RunSubscriptionPurchase()
        {
            Console.WriteLine("Виберіть спосіб придбання підписки:");
            Console.WriteLine("1. WebSite");
            Console.WriteLine("2. MobileApp");
            Console.WriteLine("3. ManagerCall");
            Console.Write("Ваш вибір: ");
            string choice = Console.ReadLine();

            ISubscriptionPurchase subscriptionPurchase = null;
            switch (choice)
            {
                case "1":
                    subscriptionPurchase = new WebSite();
                    break;
                case "2":
                    subscriptionPurchase = new MobileApp();
                    break;
                case "3":
                    subscriptionPurchase = new ManagerCall();
                    break;
                default:
                    Console.WriteLine("Невірний вибір");
                    return;
            }

            Console.WriteLine("\nВиберіть тип підписки:");
            Console.WriteLine("1. Domestic");
            Console.WriteLine("2. Educational");
            Console.WriteLine("3. Premium");
            Console.Write("Ваш вибір: ");
            string subChoice = Console.ReadLine();

            string subscriptionType = "";
            switch (subChoice)
            {
                case "1":
                    subscriptionType = "Domestic";
                    break;
                case "2":
                    subscriptionType = "Educational";
                    break;
                case "3":
                    subscriptionType = "Premium";
                    break;
                default:
                    Console.WriteLine("Невірний вибір");
                    return;
            }

            Subscription subscription = subscriptionPurchase.CreateSubscription(subscriptionType);
            Console.WriteLine("\nІнформація про придбану підписку:");
            subscription.DisplayInfo();
        }

        static void RunDeviceFactory()
        {
            Console.WriteLine("Виберіть бренд техніки:");
            Console.WriteLine("1. IProne");
            Console.WriteLine("2. Kiaomi");
            Console.WriteLine("3. Balaxy");
            Console.Write("Ваш вибір: ");
            string brandChoice = Console.ReadLine();

            IDeviceFactory deviceFactory = null;
            switch (brandChoice)
            {
                case "1":
                    deviceFactory = new IProneFactory();
                    break;
                case "2":
                    deviceFactory = new KiaomiFactory();
                    break;
                case "3":
                    deviceFactory = new BalaxyFactory();
                    break;
                default:
                    Console.WriteLine("Невірний вибір бренду");
                    return;
            }

            Console.WriteLine("Виберіть тип девайсу:");
            Console.WriteLine("1. Laptop");
            Console.WriteLine("2. Netbook");
            Console.WriteLine("3. EBook");
            Console.WriteLine("4. Smartphone");
            Console.Write("Ваш вибір: ");
            string deviceChoice = Console.ReadLine();

            IDevice device = null;
            switch (deviceChoice)
            {
                case "1":
                    device = deviceFactory.CreateLaptop();
                    break;
                case "2":
                    device = deviceFactory.CreateNetbook();
                    break;
                case "3":
                    device = deviceFactory.CreateEBook();
                    break;
                case "4":
                    device = deviceFactory.CreateSmartphone();
                    break;
                default:
                    Console.WriteLine("Невірний вибір типу девайсу");
                    return;
            }

            Console.WriteLine("\nІнформація про створений девайс:");
            device.DisplayInfo();
        }

        static void RunAuthenticatorTest()
        {
            Authenticator auth1 = Authenticator.Instance;
            Authenticator auth2 = Authenticator.Instance;

            Console.WriteLine("Перевірка одиночного створення екземпляру Authenticator:");
            Console.WriteLine("HashCode auth1: " + auth1.GetHashCode());
            Console.WriteLine("HashCode auth2: " + auth2.GetHashCode());

            if (auth1 == auth2)
            {
                Console.WriteLine("Singleton працює: обидва екземпляри ідентичні.");
            }
            else
            {
                Console.WriteLine("Singleton НЕ працює: екземпляри різні.");
            }

            Console.WriteLine("\nПеревірка роботи в багатопоточному режимі:");
            int numThreads = 5;
            Thread[] threads = new Thread[numThreads];

            for (int i = 0; i < numThreads; i++)
            {
                threads[i] = new Thread(() =>
                {
                    Authenticator auth = Authenticator.Instance;
                    Console.WriteLine($"Потік {Thread.CurrentThread.ManagedThreadId}: {auth.GetHashCode()}");
                });
                threads[i].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }
        }

        static void RunVirusPrototypeTest()
        {
            Virus grandParent = new Virus(10.5, 100, "Virus Grand", "Alpha");

            Virus parent1 = new Virus(5.0, 50, "Virus Parent 1", "Beta");
            Virus parent2 = new Virus(5.2, 52, "Virus Parent 2", "Beta");
            grandParent.Children.Add(parent1);
            grandParent.Children.Add(parent2);

            Virus child1 = new Virus(2.5, 20, "Virus Child 1", "Gamma");
            Virus child2 = new Virus(2.6, 21, "Virus Child 2", "Gamma");
            parent1.Children.Add(child1);
            parent1.Children.Add(child2);

            Virus child3 = new Virus(2.7, 19, "Virus Child 3", "Gamma");
            parent2.Children.Add(child3);

            Console.WriteLine("Оригінальне сімейство вірусів:");
            grandParent.DisplayInfo();

            Virus clonedGrandParent = (Virus)grandParent.Clone();

            Console.WriteLine("\nКлоноване сімейство вірусів:");
            clonedGrandParent.DisplayInfo();

            Console.WriteLine("\nЗміна клонованого сімейства:");
            clonedGrandParent.Name = "Virus Grand Cloned";
            if (clonedGrandParent.Children.Count > 0)
            {
                clonedGrandParent.Children[0].Name = "Virus Parent 1 Cloned";
            }

            Console.WriteLine("\nПісля змін, оригінальне сімейство вірусів:");
            grandParent.DisplayInfo();

            Console.WriteLine("\nПісля змін, клоноване сімейство вірусів:");
            clonedGrandParent.DisplayInfo();
        }

        static void RunBuilderTest()
        {
            CharacterDirector director = new CharacterDirector();

            ICharacterBuilder heroBuilder = new HeroBuilder();
            director.ConstructHero(heroBuilder);
            Character hero = heroBuilder.Build();
            Console.WriteLine("Герой:");
            Console.WriteLine(hero);

            ICharacterBuilder enemyBuilder = new EnemyBuilder();
            director.ConstructEnemy(enemyBuilder);
            Character enemy = enemyBuilder.Build();
            Console.WriteLine("Ворог:");
            Console.WriteLine(enemy);
        }
    }
}
