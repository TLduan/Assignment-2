using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1  };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Write your code here
                
                Array.Sort(nums); // Sort the array to handle duplicates

                List<int> missingNumbers = new List<int>();
                int expectedNumber = 1;

                for (int i = 0; i < nums.Length; i++)
                {
                    // Skip duplicate values
                    if (i > 0 && nums[i] == nums[i - 1])
                        continue;

                    // Find missing numbers
                    while (expectedNumber < nums[i])
                    {
                        missingNumbers.Add(expectedNumber);
                        expectedNumber++;
                    }

                    expectedNumber++;
                }

                // Add remaining missing numbers till n
                while (expectedNumber <= nums.Length)
                {
                    missingNumbers.Add(expectedNumber);
                    expectedNumber++;
                }

                return missingNumbers;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Write your code here
                List<int> evens = new List<int>();
                List<int> odds = new List<int>();

                // Separate even and odd numbers while preserving order
                foreach (int num in nums)
                {
                    if (num % 2 == 0)
                        evens.Add(num);
                    else
                        odds.Add(num);
                }

                // Combine the lists
                evens.AddRange(odds);

                return evens.ToArray(); // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length;  j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
                return new int[0]; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Write your code here

                // Edge case for less than three input numbers
                if (nums.Length < 3)
                {
                    return nums[0];
                }
                
                for (int i = 0; i < nums.Length; i ++)
                {
                    for (int j = 0; j < nums.Length - 1; j ++)
                    {
                        if (nums[j] > nums[j+1])
                        {
                            int temp = nums[j];
                            nums[j] = nums[j+1];
                            nums[j+1] = temp;
                        }
                    }
                }

                int total = nums.Length;
                int ans = nums[total-1] * nums[total-2] * nums[total-3];
                return ans; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here

                //Edge number for input 0
                if (decimalNumber == 0)
                {
                    return "0";
                }

                string binary = " ";
                while (decimalNumber > 0)
                {
                    int reminder = decimalNumber % 2;
                    binary = reminder + binary;
                    decimalNumber = decimalNumber / 2;
                }
                return binary; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Write your code here
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length-1; j++)
                    {
                        if (nums[j] > nums[j+1])
                        {
                            int temp = nums[j];
                            nums[j] = nums[j+1];
                            nums[j+1] = temp;
                        }
                    }
                }
                return nums[0]; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                if (x < 0)
                {
                    return false;
                }

                int original = x;
                int reversed = 0;

                while (x > 0)
                {
                    int digit = x % 10;
                    reversed = reversed * 10 + digit;
                    x /= 10;
                }

                return reversed == original;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here
                if (n == 0) { return 0; }
                if (n == 1) { return 1; }

                int a = 0;
                int b = 1;
                int result = 0;

                for (int i = 2; i <= n; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }
                return result; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
