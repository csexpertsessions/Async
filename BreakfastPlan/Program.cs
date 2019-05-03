using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");
            Egg egg = FryEggs(2);
            Console.WriteLine("eggs are ready");
            Bacon bacon = FryBacon(3);
            Console.WriteLine("Bacon is ready");
            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJan(toast);
            Console.WriteLine("toast is ready");
            Juice oj = PourOJ();
            Console.WriteLine("OJ is ready");
            Console.WriteLine("");
            Console.WriteLine("Breakfast is ready!".ToUpper());
        }

        static Coffee PourCoffee()
        {
            Console.WriteLine("pouring coffee...");
            Task.Delay(2000).Wait();
            return new Coffee();
        }

        static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Warming up the egg pan...");
            Task.Delay(1000).Wait();
            Console.WriteLine($"cracking {howMany} eggs...");
            Console.WriteLine("cooking the eggs...");
            Task.Delay(3000).Wait();
            Console.WriteLine("putting eggs on plate");
            return new Egg();
        }

        static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon on the pan ...");
            Console.WriteLine("cooking the first side of bacon...");
            Task.Delay(4000).Wait();
            Console.WriteLine("flipping the bacon...");
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(4000).Wait();
            Console.WriteLine("putting the bacon on plate");
            return new Bacon();
        }

        static Toast ToastBread(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bread in the toaster ...");
            Console.WriteLine("start toasting ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("remove the bread from toaster...");
            Task.Delay(1000).Wait();
            return new Toast();
        }

        static void ApplyJan(Toast toast)
        {
            Console.WriteLine("putting buttor on the toast...");
            Task.Delay(1000).Wait();
        }

        static void ApplyButter(Toast toast)
        {
            Console.WriteLine("putting jam on the toast...");
            Task.Delay(1000).Wait();
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("pouring OJ...");
            Task.Delay(1000).Wait();
            return new Juice();
        }


    }


}
