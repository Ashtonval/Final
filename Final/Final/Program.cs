// See https://aka.ms/new-console-template for more information
using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

class Challenges
{

    static void Main()
    {
        Console.WriteLine("Hello there, my name is Ashton and today I have a variety of programs for you to choose from.");
        Console.WriteLine("Choose a function:\n 1: Sum \n 2: Convert \n 3: PlusOne \n 4: Power \n 5: AgeDays \n 6: triArea \n 7: lessThanOrEqualToZero \n 8: lessThan100 \n 9: EqualTo \n 10: GiveMeSomething \n 11: Reverse \n 12: howManySeconds \n 13: internalAnglesSum \n 14: nameString \n 15: AndYes \n 16: Points \n 17: perimeterOfRec \n 18: helloName \n 19: animals \n 20: footballPoints \n 21: monthName \n 22: findMinMax \n 23: GetAbsSum \n 24: calculateExponent \n 25: MultiplyByLength \n 26: HammingDistance");
        Console.WriteLine("Please choose the number of the function that you would like to try");
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Function(a1));



        /*Console.WriteLine("Enter a number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a number");
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a number");
        int a2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a number");
        int a3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a number");
        int a4 = Convert.ToInt32(Console.ReadLine());*/




        //User Input for Int
        /*Console.WriteLine("Enter your number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of draws");
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of losses");
        int a2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The month is " + MonthName(a));*/


    }

    public static int Sum(int x, int y)
    {
        int c = x + y;
        return c;
    }

    public static int convert(int minutes)
    {
        int sec = minutes
            * 60;
        return sec;
    }
    public static int PlusOne(int number)
    {
        int n = number + 1;
        return n;
    }
    public static int Power(int v, int c)
    {
        int p = v * c;
        return p;
    }

    public static int AgeDays(int days)
    {
        int y = 365;
        int d = days * y;
        return d;
    }
    public static int triArea(int b, int y)
    {
        int a = (b * y) / 2;
        return a;
    }
    public static bool lessThanOrEqualToZero(int a)
    {
        if (a <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }

    }
    public static bool lessThan100(int a, int b)
    {
        if (a + b < 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool IsEqual(int a, int b)
    {
        if (a == b)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static string GiveMeSomething(string a)
    {
        string c = "something " + a;
        return c;
    }
    public static bool Reverse(bool a)
    {
        if (a == true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public static int howManySeconds(int a)
    {
        int b = 3600 * a;
        return b;
    }
    public static int internalAnglesSum(int n)
    {
        int a = (n - 2) * 180;
        return a;
    }
    public static string nameString(string a)
    {
        string l = " Edabit";
        return a + l;
    }
    public static bool andYes(bool a, bool b)
    {
        if (a && b == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static int points(int a, int b)
    {
        return 2 * a + b * 3;
    }
    public static int perimeterOfRec(int a, int b)
    {
        return a * 2 + b * 2;
    }

    public static string HelloName(string a)
    {
        string b = "Hello ";
        string c = "!";
        return b + a + c;
    }
    public static int animals(int a, int b, int c)
    {
        return a * 2 + b * 4 + c * 4;
    }
    public static int FootballPoints(int w, int d, int l)
    {
        return w * 3 + d * 1 + l * 0;
    }
    public static string MonthName(int a)
    {
        string j = "January";
        string f = "February";
        string march = "March";
        string april = "April";
        string may = "May";
        string june = "June";
        string july = "July";
        string august = "August";
        string s = "September";
        string o = "October";
        string n = "November";
        string d = "December";
        if (a == 1) { return j; }
        else if (a == 2) { return f; }
        else if (a == 3) { return march; }
        else if (a == 4) { return april; }
        else if (a == 5) { return may; }
        else if (a == 6) { return june; }
        else if (a == 7) { return july; }
        else if (a == 8) { return august; }
        else if (a == 9) { return s; }
        else if (a == 10) { return o; }
        else if (a == 11) { return n; }
        else if (a == 12) { return d; }
        else { return "Unavailable at this time"; }

    }
    public static int FindMinMax(int[] a)
    {
        int b = a.Min();
        int c = a.Max();
        Console.WriteLine("The minimum value is " + b);
        return (c);


    }
    public static int getAbsSum(int a, int b, int c, int d, int e)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        c = Math.Abs(c);
        d = Math.Abs(d);
        e = Math.Abs(e);
        int[] z = { a + b + c + d + e };
        return z[0];
    }
    public static int CalculateExponent(int a, int b)
    {
        int z = (int)Math.Pow(a, b);
        return z;
    }
    public static string MultiplyByLength(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            a[0] = a[i] * a.Length;
            Console.WriteLine("The value is " + a[0]);

        }
        return null;
    }
    public static int HammingDistance(string str1, string str2)
    {
        int i = 0, count = 0;
        while (i < str1.Length)
        {
            if (str1[i] != str2[i])
                count++;
            i++;
        }
        return count;
    }
    public static int Function(int a)
    {

        if (a == 1)
        {
            Console.WriteLine("This function returns the sum of two numbers");
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a2 = Convert.ToInt32(Console.ReadLine());
            return Sum(a1, a2);
        }
        else if (a == 2)
        {
            Console.WriteLine("This function returns the amount of seconds in the minute value that you give");
            Console.WriteLine("Enter a number for minutes");
            int a1 = Convert.ToInt32(Console.ReadLine());
            return convert(a1);
        }
        else if (a == 3)
        {
            Console.WriteLine("This function takes whatever number you input and adds 1 to it");
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            return PlusOne(a1);
        }
        else if (a == 4)
        {
            Console.WriteLine("This Function finds the product of two values that you give");
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a2 = Convert.ToInt32(Console.ReadLine());
            return Power(a1, a2);
        }
        else if (a == 5)
        {
           
        }
        else if (a == 6)
        {

        }
        else if (a == 7)
        {

        }
        else if (a == 8)
        {

        }
        else if (a == 9)
        {

        }
        else if (a == 10)
        {

        }
        else if (a == 11)
        {

        }
        else if (a == 12)
        {

        }
        else if (a == 13)
        {

        }
        else if (a == 14)
        {

        }
        else if (a == 15)
        {

        }
        else if (a == 16
            )
        {

        }
        else if (a == 17)
        {

        }
        else if (a == 18)
        {

        }
        else if (a == 19)
        {

        }
        else if (a == 20)
        {

        }
        else if (a == 21)
        {

        }
        else if (a == 22)
        {

        }
        else if (a == 23)
        {

        }
        else if (a == 24)
        {

        }
        else if (a == 25)
        {

        }
        else if (a == 26)
        {

        }
        else
        {
            return null;
        }
    }
}
