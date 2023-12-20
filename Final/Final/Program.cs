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
        Console.WriteLine("Please choose the number of the function that you would like to try.");
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Function(a1));
        Console.WriteLine(FunctionB(a1));
        Console.WriteLine(FunctionS(a1));
        Console.WriteLine(FunctionA(a1));
        Console.WriteLine(FunctionC(a1));
        Console.WriteLine(FunctionH(a1));
        Console.WriteLine(FunctionM(a1));

        runStartUpCode();
    }
    static void runStartUpCode()
    {
        for(int i = 1; i < 20; i++)
        {
            Console.WriteLine("Hello there, my name is Ashton and today I have a variety of programs for you to choose from.");
            Console.WriteLine("Choose a function:\n 1: Sum \n 2: Convert \n 3: PlusOne \n 4: Power \n 5: AgeDays \n 6: triArea \n 7: lessThanOrEqualToZero \n 8: lessThan100 \n 9: EqualTo \n 10: GiveMeSomething \n 11: Reverse \n 12: howManySeconds \n 13: internalAnglesSum \n 14: nameString \n 15: AndYes \n 16: Points \n 17: perimeterOfRec \n 18: helloName \n 19: animals \n 20: footballPoints \n 21: monthName \n 22: findMinMax \n 23: GetAbsSum \n 24: calculateExponent \n 25: MultiplyByLength \n 26: HammingDistance");
            Console.WriteLine("Please choose the number of the function that you would like to try.");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Function(a1));
            Console.WriteLine(FunctionB(a1));
            Console.WriteLine(FunctionS(a1));
            Console.WriteLine(FunctionA(a1));
            Console.WriteLine(FunctionC(a1));
            Console.WriteLine(FunctionH(a1));
            Console.WriteLine(FunctionM(a1));
        }
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
            return true;
        }
        else
        {
            return false;
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
        Console.WriteLine("The minimum value is " + b + " and the maximum value is");
        return c;


    }
    public static int? getAbsSum(int a, int b, int c, int d, int e)
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
    public static int? MultiplyByLength(int[] a)
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
    public static bool? FunctionR(int a)
    {
        if(a == 0)
        {
            return false;
        }
        else
        {
            return null;
        }
    }
    public static int? FunctionM(int a)
    {
        if (a == 25)
        {
            Console.WriteLine("This function returns the value of a number multipled by how many integers are in array");
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a6 = Convert.ToInt32(Console.ReadLine());
            int[] z = { a1, a2, a3, a4, a5, a6 };
            return MultiplyByLength(z);
        }
        else
        {
            return null;
        }

    }
    public static int? FunctionH(int a)
    {
        if(a == 26)
        {
            Console.WriteLine("This function gives the difference in the two phrases that the user inputs");
            Console.WriteLine("Enter a phrase");
            string a1 = Console.ReadLine();
            Console.WriteLine("Enter a phrase of the same length as the previous phrase");
            string a2 = Console.ReadLine();
            return HammingDistance(a1, a2); 

        }
        else
        {
            return null;
        }
    }
    public static int? FunctionA(int a)
    {
        if (a == 22)
        {
            Console.WriteLine("This function tells the user what the minimum and maximum values are of the array that they input values for");
            Console.WriteLine("Enter a number");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a4 = Convert.ToInt32(Console.ReadLine());
            int []c = {z, a1, a2, a3, a4 };
            return FindMinMax(c);
        }
        else if(a == 23)
        {
            Console.WriteLine("This function gives the sum of all values that the user inputs.  All of the inputs are returned with their absolute values");
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a5 = Convert.ToInt32(Console.ReadLine());
            return getAbsSum(a1, a2, a3, a4, a5);
        }
        else
        {
            return null;
        }
    }
    public static int? FunctionC(int a)
    {
        if(a == 24)
        {
            Console.WriteLine("This function lets the user pick a base(b) and an exponent(e)");
            Console.WriteLine("Enter a base");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an exponent");
            int a2 = Convert.ToInt32(Console.ReadLine());
            return CalculateExponent(a1, a2);
        }
        else
        {
            return null;
        }
    }
    public static int? Function(int a)
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
            Console.WriteLine("This function returns the value of the amount of days in a certain amount of years");
            Console.WriteLine("Enter a number that you would like to use for years");
            int a1 = Convert.ToInt32(Console.ReadLine());
            return AgeDays(a1);
        }
        else if (a == 6)
        {
            Console.WriteLine("This function returns the area of a triangle");
            Console.WriteLine("Enter a number for the base of the triangle");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number for the height of the triangle");
            int a2 = Convert.ToInt32(Console.ReadLine());
            return triArea(a1, a2);
        }
        else if (a == 12)
        {
            Console.WriteLine("This function returns how many secodns are in a certain amount of hours");
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            return howManySeconds(a1);
        }
        else if (a == 13)
        {
            Console.WriteLine("This function returns the sum of internal angles after the user inputs how many sides they want");
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            return internalAnglesSum(a1);
        }
        else if (a == 16)
        {
            Console.WriteLine("This function returns the amount of points from a game.  The first type of points is worth two and the second type is worth 3");
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a2 = Convert.ToInt32(Console.ReadLine());
            return points(a1, a2);
        }
        else if (a == 17)
        {
            Console.WriteLine("This function returns the perimeter of a rec");
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a2 = Convert.ToInt32(Console.ReadLine());
            return perimeterOfRec(a1, a2);
        }
        else if (a == 19)
        {
            Console.WriteLine("This returns the amount of animals in a farm.  The first amount of animals is the value times 2, the second is the value times 4, and the third is the value times 4");
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number for the height of the triangle");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a3 = Convert.ToInt32(Console.ReadLine());
            return animals(a1, a2, a3);
        }
        else if (a == 20)
        {
            Console.WriteLine("This function returns the amount of football points.  The first value is the value times 3, the second value is just that, and the third value is times 0");
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a3 = Convert.ToInt32(Console.ReadLine());
            return FootballPoints(a1, a2, a3);
        }
        
        else
        {
            return null;

        }
    }
    public static string FunctionS(int a)
    {
        if(a == 10)
        {
            Console.WriteLine("This function returns whatever string you input and puts something before it");
            Console.WriteLine("Enter a name or phrase");
            string a1 = Console.ReadLine();
            return GiveMeSomething(a1);
        }
        else if(a == 14)
        {
            Console.WriteLine("This function returns the name that the user inputs and adds Edabit after it");
            Console.WriteLine("Enter a name");
            string a1 = Console.ReadLine();
            return nameString(a1);
        }
        else if(a == 18)
        {
            Console.WriteLine("This function tells the user hello after they input their name");
            Console.WriteLine("Enter a name");
            string a1 = Console.ReadLine();
            return HelloName(a1);
        }
        else if(a == 21)
        {
            Console.WriteLine("This function gives a month that corresponds to a number that they choose");
            Console.WriteLine("Enter a number 1-12");
            int a1 = Convert.ToInt32(Console.ReadLine());
            return MonthName(a1);
        }
        
        else
        {
            return null;
        }
    }
    public static bool? FunctionB(int a)
    {
        if (a == 7)
        {
            Console.WriteLine("This function checks to see if your number is less than or equal to zero");
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            return lessThanOrEqualToZero(a1);
        }
        else if (a == 8)
        {
            Console.WriteLine("This function lets the user know if the two integers are less than 100");
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a2 = Convert.ToInt32(Console.ReadLine());
            return lessThan100(a1, a2);
        }
        else if (a == 9)
        {
            Console.WriteLine("This function lets the user know if both numbers that they choose are equal to each other");
            Console.WriteLine("Enter a number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int a2 = Convert.ToInt32(Console.ReadLine());
            return IsEqual(a1, a2);
        }
        else if (a == 11)
        {
            Console.WriteLine("This function tells the user if the boolean that they input is true or false to true");
            Console.WriteLine("Enter a boolean");
            bool a1 = Convert.ToBoolean(Console.ReadLine());
            return Reverse(a1);
        }
        else if (a == 15)
        {
            Console.WriteLine("This function tells the user if the two booleans that they input are true or false");
            Console.WriteLine("Enter a boolean");
            bool a1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter a boolean");
            bool a2 = Convert.ToBoolean(Console.ReadLine());
            return andYes(a1, a2);
        }
        else
        {
            return null;
        }
    }
}
