namespace assignment5
{
    internal class program
    {
        static void Main(string[] args)
        {

            #region Task 1: Difference between passing value type parameters by value and by reference
            static void Task1()
            {
                int value = 10;
                Console.WriteLine("Initial Value: " + value);

                PassByValue(value);
                Console.WriteLine("After PassByValue: " + value);

                PassByReference(ref value);
                Console.WriteLine("After PassByReference: " + value);
            }
            // pass by value
            static void PassByValue(int num)
            {
                num = 20;
            }
            // pass by ref
            static void PassByReference(ref int num)
            {
                num = 30;
            }
            #endregion

            #region Task 2: Difference between passing reference type parameters by value and by reference
            static void Task2()
            {
                MyClass obj = new MyClass();
                obj.Number = 10;
                Console.WriteLine("Initial Value: " + obj.Number);

                PassByValue2(obj);
                Console.WriteLine("After PassByValue: " + obj.Number);

                PassByReference2(ref obj);
                Console.WriteLine("After PassByReference: " + obj.Number);
            }

            static void PassByValue2(MyClass obj)
            {
                obj.Number = 20;
                obj = new MyClass { Number = 40 };
            }

            static void PassByReference2(ref MyClass obj)
            {
                obj.Number = 30;
                obj = new MyClass { Number = 50 };
            }

    class MyClass
        {
            public int Number { get; set; }
        }
        #endregion

            #region Task 3: Function to accept 4 parameters and return summation and subtraction of two numbers
        static void Task3()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            (int sum, int diff) = SumAndSubtract(num1, num2);
            Console.WriteLine($"Sum: {sum}, Difference: {diff}");
        }
        // the function : 
        static (int, int) SumAndSubtract(int a, int b)
        {
            int sum = a + b;
            int diff = a - b;
            return (sum, diff);
        }
        #endregion

            #region Task 4: Function to calculate the sum of the individual digits of a given number
        static void Task4()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sumOfDigits = SumOfDigits(number);
            Console.WriteLine($"The sum of the digits of the number {number} is: {sumOfDigits}");
        }

        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        #endregion

            #region Task 5: Function named "IsPrime" to check if a number is prime
        static void Task5()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = IsPrime(number);
            Console.WriteLine($"Is {number} a prime number? {isPrime}");
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        #endregion

            #region Task 6: Function named MinMaxArray to return the minimum and maximum values stored in an array using reference parameters
        static void Task6()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            MinMaxArray(numbers, out int min, out int max);
            Console.WriteLine($"Minimum: {min}, Maximum: {max}");
        }

        static void MinMaxArray(int[] array, out int min, out int max)
        {
            min = array[0];
            max = array[0];

            foreach (var num in array)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
        }
        #endregion

            #region Task 7: Iterative function to calculate the factorial of a number
        static void Task7()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int factorial = CalculateFactorial(number);
            Console.WriteLine($"The factorial of {number} is: {factorial}");
        }

        static int CalculateFactorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        #endregion

            #region Task 8: Function named "ChangeChar" to modify a letter in a certain position of a string
        static void Task8()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter position to change (0-based): ");
            int position = int.Parse(Console.ReadLine());

            Console.Write("Enter new character: ");
            char newChar = Console.ReadLine()[0];

            string result = ChangeChar(input, position, newChar);
            Console.WriteLine($"Modified string: {result}");
        }

        static string ChangeChar(string str, int position, char newChar)
        {
            if (position < 0 || position >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(position));
            }
            else 
            {
                char[] chars = str.ToCharArray();
                chars[position] = newChar;
                return new string(chars);
            } 
        }
        #endregion

    }
}
