using System;
using System.IO;

namespace lab4
{ 
    class Program
    {     
        public interface IAbstractRedactor
        {
            IAbstractSettings GetSettings();
        }
        class MacRedactor : IAbstractRedactor
        {
            public IAbstractSettings GetSettings()
            {
                return new MacSettings();
            }
        }
        class WindowsRedactor : IAbstractRedactor
        {
            public IAbstractSettings GetSettings()
            {
                return new WindowsSettings();
            }
        }
        class UbuntuRedactor : IAbstractRedactor
        {
            public IAbstractSettings GetSettings()
            {
                return new UbuntuSettings();
            }
        }
        public interface IAbstractSettings
        {
            string WhichOS();
            string SetSettings1();
            string SetSettings2();
            string SetSettings3();
            string SetSettings4();
            string SetSettings5();
            string SetSettings6();
            string SetSettings7();
            string SetSettings8();
            string SetSettings9();
            string SetSettings10();

        }
        class MacSettings : IAbstractSettings
        {
            public string WhichOS()
            {
                return "Эти настройки для Mac:";
            }
            public string SetSettings1()
            {
                return "Меняем настройку 1 под Mac";
            }
            public string SetSettings2()
            {
                return "Меняем настройку 2 под Mac";
            }
            public string SetSettings3()
            {
                return "Меняем настройку 3 под Mac";
            }
            public string SetSettings4()
            {
                return "Меняем настройку 4 под Mac";
            }
            public string SetSettings5()
            {
                return "Меняем настройку 5 под Mac";
            }
            public string SetSettings6()
            {
                return "Меняем настройку 6 под Mac";
            }
            public string SetSettings7()
            {
                return "Меняем настройку 7 под Mac";
            }
            public string SetSettings8()
            {
                return "Меняем настройку 8 под Mac";
            }
            public string SetSettings9()
            {
                return "Меняем настройку 9 под Mac";
            }
            public string SetSettings10()
            {
                return "Меняем настройку 10 под Mac";
            }
        }
        class WindowsSettings : IAbstractSettings
        {
            public string WhichOS()
            {
                return "Эти настройки для Windows:";
            }
            public string SetSettings1()
            {
                return "Меняем настройку 1 под Windows";
            }
            public string SetSettings2()
            {
                return "Меняем настройку 2 под Windows";
            }
            public string SetSettings3()
            {
                return "Меняем настройку 3 под Windows";
            }
            public string SetSettings4()
            {
                return "Меняем настройку 4 под Windows";
            }
            public string SetSettings5()
            {
                return "Меняем настройку 5 под Windows";
            }
            public string SetSettings6()
            {
                return "Меняем настройку 6 под Windows";
            }
            public string SetSettings7()
            {
                return "Меняем настройку 7 под Windows";
            }
            public string SetSettings8()
            {
                return "Меняем настройку 8 под Windows";
            }
            public string SetSettings9()
            {
                return "Меняем настройку 9 под Windows";
            }
            public string SetSettings10()
            {
                return "Меняем настройку 10 под Windows";
            }
        }
        class UbuntuSettings : IAbstractSettings
        {
            public string WhichOS()
            {
                return "Эти настройки для Ubuntu:";
            }
            public string SetSettings1()
            {
                return "Меняем настройку 1 под Ubuntu";
            }
            public string SetSettings2()
            {
                return "Меняем настройку 2 под Ubuntu";
            }
            public string SetSettings3()
            {
                return "Меняем настройку 3 под Ubuntu";
            }
            public string SetSettings4()
            {
                return "Меняем настройку 4 под Ubuntu";
            }
            public string SetSettings5()
            {
                return "Меняем настройку 5 под Ubuntu";
            }
            public string SetSettings6()
            {
                return "Меняем настройку 6 под Ubuntu";
            }
            public string SetSettings7()
            {
                return "Меняем настройку 7 под Ubuntu";
            }
            public string SetSettings8()
            {
                return "Меняем настройку 8 под Ubuntu";
            }
            public string SetSettings9()
            {
                return "Меняем настройку 9 под Ubuntu";
            }
            public string SetSettings10()
            {
                return "Меняем настройку 10 под Ubuntu";
            }
        }

        class Client
        {
            public void Mac()
            {
                ClientMethod(new MacRedactor());
                Console.WriteLine();
            }
            public void Windows()
            {
                ClientMethod(new WindowsRedactor());
                Console.WriteLine();
            }
            public void Ubuntu()
            {
                ClientMethod(new UbuntuRedactor());
                Console.WriteLine();
            }
            public void ClientMethod(IAbstractRedactor redactor)
            {
                var Settings = redactor.GetSettings();
                Console.WriteLine(Settings.WhichOS());
                Console.WriteLine(Settings.SetSettings1());
                Console.WriteLine(Settings.SetSettings2());
                Console.WriteLine(Settings.SetSettings3());
                Console.WriteLine(Settings.SetSettings4());
                Console.WriteLine(Settings.SetSettings5());
                Console.WriteLine(Settings.SetSettings6());
                Console.WriteLine(Settings.SetSettings7());
                Console.WriteLine(Settings.SetSettings8());
                Console.WriteLine(Settings.SetSettings9());
                Console.WriteLine(Settings.SetSettings10());
            }
        }
        static void Main(string[] args)
        {
            
            string name;
            Console.WriteLine("Введите название Операционной системы:");
            name = Console.ReadLine();
            switch (name)
            {
                case "Mac OS":
                    new Client().Mac();
                    break;
                case "Windows":
                    new Client().Windows();
                    break;
                case "Ubuntu":
                    new Client().Ubuntu();
                    break;
                default:
                    Console.WriteLine("Invalid OS name! Write the correct name");
                    break;
            }
            Console.ReadLine();
            
        }
    }
}
