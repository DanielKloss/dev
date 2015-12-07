using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 20, 31, 40 };
            List<string> cities = new List<string>() { "London", "New York", "Tokyo", "Madrid" };

            // ... Find index of first odd element in numbers.
            int oddIndex = numbers.FindIndex(number => number % 2 != 0);
            Console.WriteLine(oddIndex);
            Console.ReadLine();

            // ... Find city where character count is more than 6.
            string cityWithLotsOfCharacters = cities.FirstOrDefault<string>(city => city.Length > 6);
            Console.WriteLine(cityWithLotsOfCharacters);
            Console.ReadLine();

            // Use implicitly typed lambda expression.
            // ... Assign it to a Func instance.
            Func<int, int> func1 = parameter => parameter + 1;

            // Use lambda expression with statement body.
            Func<int, int> func2 = parameter => { return parameter + 1; };

            // Use formal parameters with expression body.
            Func<int, int> func3 = (int parameter) => parameter + 1;

            // Use parameters with a statement body.
            Func<int, int> func4 = (int parameter) => { return parameter + 1; };

            // Use multiple parameters.
            Func<int, int, int> func5 = (parameter1, parameter2) => parameter1 * parameter2;

            // Use no parameters in a lambda expression.
            Action func6 = () => Console.WriteLine();

            // Use delegate method expression.
            Func<int, int> func7 = delegate(int parameter) { return parameter + 1; };

            // Use delegate expression with no parameter list.
            Func<int> func8 = delegate { return 1 + 1; };

            // Invoke each of the lambda expressions and delegates we created.
            // ... The methods above are executed.
            Console.WriteLine(func1.Invoke(1));
            Console.ReadLine();

            Console.WriteLine(func2.Invoke(1));
            Console.ReadLine();

            Console.WriteLine(func3.Invoke(1));
            Console.ReadLine();

            Console.WriteLine(func4.Invoke(1));
            Console.ReadLine();

            Console.WriteLine(func5.Invoke(2, 2));
            Console.ReadLine();

            func6.Invoke();
            Console.ReadLine();

            Console.WriteLine(func7.Invoke(1));
            Console.ReadLine();

            Console.WriteLine(func8.Invoke());
            Console.ReadLine();
        }
    }
}
