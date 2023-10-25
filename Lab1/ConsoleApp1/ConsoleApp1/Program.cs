using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Controller x = new Controller();
            x["Tasl1"]()
            Task2();
        }
        
        static void Task2() {
            int limit = int.Parse(Console.ReadLine());
            for (int i = 2; i<=limit; i+=2) {
                Console.WriteLine(i);
            }
        }
        static void Task3() {
            int menuOption = int.Parse(Console.ReadLine());
        }
        class Controller {
            static string Task1() {
                int number = int.Parse(Console.ReadLine());
                int i = number % 2;
                string[] evenOdd = { "even", "odd" };
                string result = evenOdd[i];
                Console.WriteLine(result);
                return result;
            }
            static Task3

            }
        }

    }
}
