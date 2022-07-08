﻿using System;

namespace Cycles_Library
{
    public class CyclesHelper
    {
        public static int RaiseToThePower(int number, int raise)
        {
            int sum = number;

            for (int i = 1; i < raise; i++)
            {
                sum *= number;
            }

            return sum;
        }

        public static int GetLessSquareFromA(int a)
        {
            int result = 1;

            for (; result * result < a; ++result)
            {
            }

            return --result;
        }

        public static int GetLargestDivisorOfA(int a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Number is less or equal to 0");
            }

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

        public static int GetSummOfRangeDivisibleBySeven(int a, int b)
        {
            if (b < a)
            {
                Swap(ref a, ref b);
            }

            int result = default;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    result += i;
                }
            }
            
            return result;
        }
        
        public static int GetElementOfFibboSeries(int number)
        {
            if (number <= 0)
            {
               throw new ArgumentException("Number is less or equal to 0");
            }

            int a = 1;
            int b = 1;

            for (int i = 1; i < number; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }

        public static int GetGreatestDivisiorByEuclid(int a, int b)
        {
            while ((a != 0) && (b != 0))
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }  
            }

            return a + b;
        }
        
        public static double GetNumberByBinaryAlgorithm(double a)
        {

            double n = default;
            int min = 1;
            double temp = a;

            while (min <= a)
            {
                double mid = a / 2;
                double cubicValue = mid * mid * mid;
                if (cubicValue > temp)
                {
                    a = mid;
                    continue;
                }
                else if (cubicValue < temp)
                {
                    ++a;
                    continue;
                }
                else
                {
                    n = mid;
                    break;
                }
            }

            return n;
        }

        public static int GetNumberOfOddDigits(int number)
        {
            int count = 0;

            while (number != 0)
            {
                if (number % 2 != 0)
                {
                    count++;
                }

                number /= 10;
            }

            return count;
        }

        public static int ReverseNumber(int number)
        {
            int result = 0;

            while (number != 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }

            return result;
        }

        public static bool VerifySameDigits(int firstNumber, int secondNumber)
        {
            bool result = false;
            string firstInput = Convert.ToString(firstNumber);
            string secondInput = Convert.ToString(secondNumber);

            for (int i = 0; i < firstInput.Length; i++)
            {
                for (int j = 0; j < secondInput.Length; j++)
                {
                    if (firstInput[i] == secondInput[j])
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}

