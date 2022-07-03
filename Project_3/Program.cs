using System;

namespace Project_3
{
    class Program
    {
        static int RaiseToThePower(int number, int raise)
        {
            int sum = number;
            for (int i = 1; i < raise; i++)
            {
                sum *= number;
            }
            return sum;
        }

        static int GetLessSquareFromA(int a)
        {
            int result = default;

            for (int i = 1; i <= a; i++)
            {
               int numberSquare = i;
               numberSquare *= numberSquare;

                if (numberSquare < a)
                {
                    result++;
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        static int GetLargestDivisorOfA(int a)
        {
            int result = default;

            for (int i = a / 2; i > 1; i--)
            {
                if (a % 1 == 0)
                {
                    result += i;
                    break;
                }
            }

            return result;
        }

        static int GetSummOfRangeDivisibleBySeven(int a, int b)
        {
            int result = default;

            if (b > a)
            {
                for (; a < b; b--)
                {
                    if (b % 7 == 0)
                    {
                        result += b;
                    }
                }
            }
            return result;
        }

        static int GetElementOfFibboSeries(int number)
        {
            int a = default;
            int b = 1;
            int result = default;
            for (int i = 2; i < number; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }
            return result;
        }

        static int GetGreatestDivisiorByEuclid(int a, int b)
        {
            while ((a != 0) && (b != 0))
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            return Math.Max(a, b);
        }

        //TODO use binary search algorithm.
        static double GetNumberByBinaryAlgorithm(double a)
        {
            double n = default;
            double cbrtA = Math.Cbrt(a);

            while (cbrtA < a)
            {

            }
            return n;
        }

        static int GetNumberOfOddDigits(int number)
        {
            int result = default;
            string userInpunt = Convert.ToString(number);
            for (int i = 0; i < userInpunt.Length; i++)
            {
                if (userInpunt[i] % 2 != 0)
                {
                    result++;
                }
            }

            return result;
        }

        static int ReverseNumber(int number)
        {
            string result = default;
            string userInput = Convert.ToString(number);
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                result += userInput[i];
            }
            return Convert.ToInt32(result);
        }

        static string VerifySameDigits(int firstNumber, int secondNumber)
        {
            string result = "NO";
            string firstInput = Convert.ToString(firstNumber);
            string secondInput = Convert.ToString(secondNumber);

            for (int i = 0; i < firstInput.Length; i++)
            {
                for (int j = 0; j < secondInput.Length; j++)
                {
                    if (firstInput[i] == secondInput[j])
                    {
                        result = "YES";
                        return result;
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetNumberByBinaryAlgorithm(9261));
        }
    }
}

