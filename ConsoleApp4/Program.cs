using System;
using System.ComponentModel.Design;

public class Program
{
    //------FUNCTIONS------


    static void PrintArray(int[] intArray, string mess)
    {
        foreach (int k in intArray)
        {
            Console.WriteLine("{0} : {1}", mess, k);
        }
    }

    //-----END OF FUNCTIONS------

    static void Main(string[] args)
    {/*
        int[] favNums = new int[3];
        favNums[0] = 23;
        Console.WriteLine("favNum 0 : {0}", favNums[0]);
        string[] customers = { "Lynne", "Nii", "Ayitey"};
        var employees = new[] { "Naa", "Ayeley", "Tagoe" };
        object[] randomArray = { "Ayeley", 45, 1.234 };
        Console.WriteLine("randomArray 0: {0}",
            randomArray[0].GetType());
        Console.WriteLine("Array Size : {0}", randomArray.Length);
        for (int j = 0; j < randomArray.Length; j++)
        {
            Console.WriteLine("Array : {0} : Value {1}", j, randomArray[j]);
        }
        Console.WriteLine("---------------");
        string[,] custNames = new string[2, 2] { { "Alma", "Samuel"},
        {"Joseph", "Kemp" } };
        Console.WriteLine("MD Value : {0}",
            custNames.GetValue(1, 0));
        for (int j = 0; j < custNames.GetLength(0); j++)
        {
            for (int k = 0; k < custNames.GetLength(0); k++)
            {
                Console.WriteLine("{0} ", custNames[j, k]);
            }
            Console.WriteLine();

        }


        int[] randNums = { 1, 4, 9, 2 };
        PrintArray(randNums, "ForEach");
        Console.WriteLine("------------------");

        Array.Sort(randNums);
        Array.Reverse(randNums);
        Console.WriteLine("1 at index : {0}",
            Array.IndexOf(randNums, 1);
        randNums.SetValue(0, 1);
        int[] srcArray = { 1, 2, 3 );
        int[] destArray = new int[2];
        int startInd = 0;
        int length = 2;
        Array.Copy(srcArray, startInd, destArray, 0, length);
        PrintArray(destArray, "Copy");
        Array anotherArray = Array.CreateInstance(typeof(int), 10);
        srcArray.CopyTo(anotherArray, 5);
        foreach(int m in anotherArray)
        {
            Console.WriteLine("CopyTo : {0}", m);
        }

        int[] numArray = { 1, 11, 22 };
        Console.WriteLine("> 10 : {0}", Array.Find(numArray, m));
        */

        int age = 22;
        if (age >= 17) && (age <= 19);
        {
            Console.WriteLine("Go to L100");
        }
        if (age >= 19) && (age > 21))
        {
            Console.WriteLine("Go to L200");
        }
        if (age >= 21) && (age <= 23))
        {
            Console.WriteLine("Go to L300");
        } else 
        { 
            Console.WriteLine("Finish your degree");
        }

        if ((age < 18)) || (age > 90))
        {
            Console.WriteLine("You shouldn't work");
        }
        Console.WriteLine("!true = " + (!true));

        bool canDrive = age >= 18 ? true : false;

        switch (age)
        {
            case 1:
            case 2:
                Console.WriteLine("Go to Daycare");
                break;
            case 3: 
            case 4:
                Console.WriteLine("Go to Preschool");
                break;
            case 5:
                break;
                Console.WriteLine("Go to Kindergarten");
            default:
                Console.WriteLine("Go to another school");
                goto OtherSchool;
        }

    OtherSchool:
        Console.WriteLine("Elementary, Middle, High School");
     }
}