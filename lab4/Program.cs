using System;
using System.IO;

namespace lab4
{
    /// <summary>
    /// Класс для реализации поставленной задачи
    /// </summary>
    class Program
    {
        /// <summary>
        /// Общий интерфейс редактора
        /// </summary>
        public interface IAbstractRedactor
        {
            /// <summary>
            /// Функция для возврата настроек соответствующей Операционной системы
            /// </summary>
            /// <returns>изменяемые настройки</returns>
            IAbstractSettings GetSettings();
        }
        /// <summary>
        /// Класс Mac редактора
        /// </summary>
        class MacRedactor : IAbstractRedactor
        {
            /// <summary>
            /// Функция для настроек Mac OS
            /// </summary>
            /// <returns>Настройки редактора под Mac OS</returns>
            public IAbstractSettings GetSettings()
            {
                return new MacSettings();
            }
        }
        /// <summary>
        /// Класс Windows редактора
        /// </summary>
        class WindowsRedactor : IAbstractRedactor
        {
            /// <summary>
            /// Функция для настроек Windows
            /// </summary>
            /// <returns>Настройки редактора Windows</returns>
            public IAbstractSettings GetSettings()
            {
                return new WindowsSettings();
            }
        }
        /// <summary>
        /// Класс Ubuntu редактора
        /// </summary>
        class UbuntuRedactor : IAbstractRedactor
        {
            /// <summary>
            /// Настройки Ubuntu редактора
            /// </summary>
            /// <returns>Настройки под Ubuntu</returns>
            public IAbstractSettings GetSettings()
            {
                return new UbuntuSettings();
            }
        }
        /// <summary>
        /// Интерфейс настроек
        /// </summary>
        public interface IAbstractSettings
        {
            /// <summary>
            /// Функция выводящая название ОС
            /// </summary>
            /// <returns>Название ОС под изменение настроек</returns>
            string WhichOS();
            /// <summary>
            /// Изменение настройки 1
            /// </summary>
            /// <returns>Изменяется настройка 1</returns>
            string SetSettings1();
            /// <summary>
            /// Изменение настройки 2
            /// </summary>
            /// <returns>Изменяется настройка 2</returns>
            string SetSettings2();
            /// <summary>
            /// Изменение настройки 3
            /// </summary>
            /// <returns>Изменяется настройка 3</returns>
            string SetSettings3();
            /// <summary>
            /// Изменение настройки 4
            /// </summary>
            /// <returns>Изменяется настройка 4</returns>
            string SetSettings4();
            /// <summary>
            /// Изменение настройки 5
            /// </summary>
            /// <returns>Изменяется настройка 5</returns>
            string SetSettings5();
            /// <summary>
            /// Изменение настройки 6
            /// </summary>
            /// <returns>Изменяется настройка 6</returns>
            string SetSettings6();
            /// <summary>
            /// Изменение настройки 7
            /// </summary>
            /// <returns>Изменяется настройка 7</returns>
            string SetSettings7();
            /// <summary>
            /// Изменение настройки 8
            /// </summary>
            /// <returns>Изменяется настройка 8</returns>
            string SetSettings8();
            /// <summary>
            /// Изменение настройки 9
            /// </summary>
            /// <returns>Изменяется настройка 9</returns>
            string SetSettings9();
            /// <summary>
            /// Изменение настройки 10
            /// </summary>
            /// <returns>Изменяется настройка 10</returns>
            string SetSettings10();

        }
        /// <summary>
        /// Класс настроек Mac
        /// </summary>
        class MacSettings : IAbstractSettings
        {
            /// <summary>
            /// Функция выводящая название ОС
            /// </summary>
            /// <returns>Название ОС под изменение настроек</returns>
            public string WhichOS()
            {
                return "Эти настройки для Mac:";
            }
            /// <summary>
            /// Изменение настройки 1
            /// </summary>
            /// <returns>Изменяется настройка 1</returns>
            public string SetSettings1()
            {
                return "Меняем настройку 1 под Mac";
            }
            /// <summary>
            /// Изменение настройки 2
            /// </summary>
            /// <returns>Изменяется настройка 2</returns>
            public string SetSettings2()
            {
                return "Меняем настройку 2 под Mac";
            }
            /// <summary>
            /// Изменение настройки 3
            /// </summary>
            /// <returns>Изменяется настройка 3</returns>
            public string SetSettings3()
            {
                return "Меняем настройку 3 под Mac";
            }
            /// <summary>
            /// Изменение настройки 4
            /// </summary>
            /// <returns>Изменяется настройка 4</returns>
            public string SetSettings4()
            {
                return "Меняем настройку 4 под Mac";
            }
            /// <summary>
            /// Изменение настройки 5
            /// </summary>
            /// <returns>Изменяется настройка 5</returns>
            public string SetSettings5()
            {
                return "Меняем настройку 5 под Mac";
            }
            /// <summary>
            /// Изменение настройки 6
            /// </summary>
            /// <returns>Изменяется настройка 6</returns>
            public string SetSettings6()
            {
                return "Меняем настройку 6 под Mac";
            }
            /// <summary>
            /// Изменение настройки 7
            /// </summary>
            /// <returns>Изменяется настройка 7</returns>
            public string SetSettings7()
            {
                return "Меняем настройку 7 под Mac";
            }
            /// <summary>
            /// Изменение настройки 8
            /// </summary>
            /// <returns>Изменяется настройка 8</returns>
            public string SetSettings8()
            {
                return "Меняем настройку 8 под Mac";
            }
            /// <summary>
            /// Изменение настройки 9
            /// </summary>
            /// <returns>Изменяется настройка 9</returns>
            public string SetSettings9()
            {
                return "Меняем настройку 9 под Mac";
            }
            /// <summary>
            /// Изменение настройки 10
            /// </summary>
            /// <returns>Изменяется настройка 10</returns>
            public string SetSettings10()
            {
                return "Меняем настройку 10 под Mac";
            }
        }
        /// <summary>
        /// Класс настроек Windows
        /// </summary>
        class WindowsSettings : IAbstractSettings
        {
            /// <summary>
            /// Функция выводящая название ОС
            /// </summary>
            /// <returns>Название ОС под изменение настроек</returns>
            public string WhichOS()
            {
                return "Эти настройки для Windows:";
            }
            /// <summary>
            /// Изменение настройки 1
            /// </summary>
            /// <returns>Изменяется настройка 1</returns>
            public string SetSettings1()
            {
                return "Меняем настройку 1 под Windows";
            }
            /// <summary>
            /// Изменение настройки 2
            /// </summary>
            /// <returns>Изменяется настройка 2</returns>
            public string SetSettings2()
            {
                return "Меняем настройку 2 под Windows";
            }
            /// <summary>
            /// Изменение настройки 3
            /// </summary>
            /// <returns>Изменяется настройка 3</returns>
            public string SetSettings3()
            {
                return "Меняем настройку 3 под Windows";
            }
            /// <summary>
            /// Изменение настройки 4
            /// </summary>
            /// <returns>Изменяется настройка 4</returns>
            public string SetSettings4()
            {
                return "Меняем настройку 4 под Windows";
            }
            /// <summary>
            /// Изменение настройки 5
            /// </summary>
            /// <returns>Изменяется настройка 5</returns>
            public string SetSettings5()
            {
                return "Меняем настройку 5 под Windows";
            }
            /// <summary>
            /// Изменение настройки 6
            /// </summary>
            /// <returns>Изменяется настройка 6</returns>
            public string SetSettings6()
            {
                return "Меняем настройку 6 под Windows";
            }
            /// <summary>
            /// Изменение настройки 7
            /// </summary>
            /// <returns>Изменяется настройка 7</returns>
            public string SetSettings7()
            {
                return "Меняем настройку 7 под Windows";
            }
            /// <summary>
            /// Изменение настройки 8
            /// </summary>
            /// <returns>Изменяется настройка 8</returns>
            public string SetSettings8()
            {
                return "Меняем настройку 8 под Windows";
            }
            /// <summary>
            /// Изменение настройки 9
            /// </summary>
            /// <returns>Изменяется настройка 9</returns>
            public string SetSettings9()
            {
                return "Меняем настройку 9 под Windows";
            }
            /// <summary>
            /// Изменение настройки 10
            /// </summary>
            /// <returns>Изменяется настройка 10</returns>
            public string SetSettings10()
            {
                return "Меняем настройку 10 под Windows";
            }
        }

        /// <summary>
        /// Класс настроект Ubuntu
        /// </summary>
        class UbuntuSettings : IAbstractSettings
        {
            /// <summary>
            /// Функция выводящая название ОС
            /// </summary>
            /// <returns>Название ОС под изменение настроек</returns>
            public string WhichOS()
            {
                return "Эти настройки для Ubuntu:";
            }
            /// <summary>
            /// Изменение настройки 1
            /// </summary>
            /// <returns>Изменяется настройка 1</returns>
            public string SetSettings1()
            {
                return "Меняем настройку 1 под Ubuntu";
            }
            /// <summary>
            /// Изменение настройки 2
            /// </summary>
            /// <returns>Изменяется настройка 2</returns>
            public string SetSettings2()
            {
                return "Меняем настройку 2 под Ubuntu";
            }
            /// <summary>
            /// Изменение настройки 3
            /// </summary>
            /// <returns>Изменяется настройка 3</returns>
            public string SetSettings3()
            {
                return "Меняем настройку 3 под Ubuntu";
            }
            /// <summary>
            /// Изменение настройки 4
            /// </summary>
            /// <returns>Изменяется настройка 4</returns>
            public string SetSettings4()
            {
                return "Меняем настройку 4 под Ubuntu";
            }
            /// <summary>
            /// Изменение настройки 5
            /// </summary>
            /// <returns>Изменяется настройка 5</returns>
            public string SetSettings5()
            {
                return "Меняем настройку 5 под Ubuntu";
            }
            /// <summary>
            /// Изменение настройки 6
            /// </summary>
            /// <returns>Изменяется настройка 6</returns>
            public string SetSettings6()
            {
                return "Меняем настройку 6 под Ubuntu";
            }
            /// <summary>
            /// Изменение настройки 7
            /// </summary>
            /// <returns>Изменяется настройка 7</returns>
            public string SetSettings7()
            {
                return "Меняем настройку 7 под Ubuntu";
            }
            /// <summary>
            /// Изменение настройки 8
            /// </summary>
            /// <returns>Изменяется настройка 8</returns>
            public string SetSettings8()
            {
                return "Меняем настройку 8 под Ubuntu";
            }
            /// <summary>
            /// Изменение настройки 9
            /// </summary>
            /// <returns>Изменяется настройка 9</returns>
            public string SetSettings9()
            {
                return "Меняем настройку 9 под Ubuntu";
            }
            /// <summary>
            /// Изменение настройки 10
            /// </summary>
            /// <returns>Изменяется настройка 10</returns>
            public string SetSettings10()
            {
                return "Меняем настройку 10 под Ubuntu";
            }
        }

        /// <summary>
        /// Класс под клиента
        /// </summary>
        class Client
        {
            /// <summary>
            /// Процедура вывода настроек для Mac
            /// </summary>
            public void Mac()
            {
                ClientMethod(new MacRedactor());
                Console.WriteLine();
            }
            /// <summary>
            /// Процедура вывода настроект Windows
            /// </summary>
            public void Windows()
            {
                ClientMethod(new WindowsRedactor());
                Console.WriteLine();
            }
            /// <summary>
            /// Процедура вывода настроек Ubuntu
            /// </summary>
            public void Ubuntu()
            {
                ClientMethod(new UbuntuRedactor());
                Console.WriteLine();
            }
            /// <summary>
            /// Процедура вывода на экран изменяемых настроек и типа файла
            /// </summary>
            /// <param name="redactor для обращения к функциям интерфейса редактора"></param>
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
        /// <summary>
        /// основное тело программы
        /// </summary>
        /// <param name="args"></param>
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
