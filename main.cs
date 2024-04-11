/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Program
{
    static void Main()
    {
        char[] array = new char[] { 'r', 'a', 'd', 'a', 'r', 'a', 'y' };

        bool isSymmetrical = CheckSymmetry(array);

        if (isSymmetrical)
        {
            Console.WriteLine("Массив является симметричным");
        }
        else
        {
            Console.WriteLine("Массив не является симметричным");
        }
    }

    static bool CheckSymmetry(char[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (array[i] != array[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }