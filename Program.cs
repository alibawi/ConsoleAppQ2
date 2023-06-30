// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

public class Program
{
    private static void Main(string[] args)
    {

        // Test Question 1
        Console.WriteLine("Test Question 1");
        Console.WriteLine("Input first number");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second number");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{Q1(n1, n2)}");
        Console.WriteLine();

        // Test Question 2
        Console.WriteLine("Test Question 2");
        Console.WriteLine(Q2(15));
        Console.WriteLine();

        // Test Question 3
        Console.WriteLine("Test Question 3");
        Console.WriteLine(Q3(14));
        Console.WriteLine();

        // Test Question 4
        Console.WriteLine("Test Question 4");
        Console.WriteLine(Q4(2015));
        Console.WriteLine();

        // Test Question 5
        Console.WriteLine("Test Question 5");
        Console.WriteLine(Q5(21));
        Console.WriteLine();

        // Test Question 6
        Console.WriteLine("Test Question 6");
        Console.Write("Input value of m :");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The value of m = {m}");
        Console.WriteLine($"The value of n = {Q6(-5)}");
        Console.WriteLine();

        // Test Question 7
        Console.WriteLine("Test Question 7");
        Console.WriteLine(Q7(135));
        Console.WriteLine();

        // Test Question 8
        Console.WriteLine("Test Question 8");
        Console.Write("Input the 1st number :");
        int no1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 2nd number :");
        int no2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 3rd number :");
        int no3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Q8(no1, no2, no3));
        Console.WriteLine();

        // Test Question 9
        Console.WriteLine("Test Question 9");
        Console.WriteLine(); Console.Write("Input the value for x coordinate :");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(); Console.Write("Input the value for y coordinate :");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Q9(x, y));
        
        // Test Question 10
        Console.WriteLine("Test Question 10");
        Console.WriteLine(Q10(72, 65, 51));
        Console.WriteLine();

        // Test Question 11
        Console.WriteLine("Test Question 11");
        Console.WriteLine(Q11(1, 5, 7));
        Console.WriteLine();

        // Test Question 12
        Console.WriteLine("Test Question 12");
        Q12();
        Console.WriteLine();

        // Test Question 13
        Console.WriteLine("Test Question 13");
        Console.WriteLine(Q13(42));
        Console.WriteLine();

        // Test Question 14
        Console.WriteLine("Test Question 14");
        Console.WriteLine(Q14(50, 50, 60));
        Console.WriteLine();

        // Test Question 15
        Console.WriteLine("Test Question 14");
        Console.WriteLine(Q15(40, 55, 65));
        Console.WriteLine();

        // Test Question 16
        Console.WriteLine("Test Question 16");
        Console.WriteLine(Q16('k'));
        Console.WriteLine();

        // Test Question 17
        Console.WriteLine("Test Question 17");
        Console.WriteLine(Q17(500, 700));
        Console.WriteLine();

        // Test Question 18
        Console.WriteLine("Test Question 18");
        Q18(1001, "James", 800);
        Console.WriteLine();

        // Test Question 19
        Console.WriteLine("Test Question 19");
        Console.WriteLine(Q19('a'));
        Console.WriteLine();

        // Test Question 20
        Console.WriteLine("Test Question 20");
        Q20(4);
        Console.WriteLine();

        // Test Question 21
        Console.WriteLine("Test Question 21");
        Q21(4);
        Console.WriteLine();

        // Test Question 22
        Console.WriteLine("Test Question 22");
        Q22(4);
        Console.WriteLine();

        // Test Question 23
        Console.WriteLine("Test Question 23");
        Q23(7);
        Console.WriteLine();

        // Test Question 48
        Console.WriteLine("Test Question 48");
        Console.WriteLine("Enter (1) for area of Circle ");
        Console.WriteLine("Enter (2) for area of Rectangle ");
        Console.WriteLine("Enter (3) for area of Triangle ");
        int options = Convert.ToInt32(Console.ReadLine());
        Q24(options);
        Console.WriteLine();

        // Test Question 22
        Console.WriteLine("Test Question 22");
        Console.WriteLine();

        // Test Question 23
        Console.WriteLine("Test Question 23");
        Console.WriteLine();

        // Test Question 24
        Console.WriteLine("Test Question 24");
        Console.WriteLine();

        // Test Question 25
        Console.WriteLine("Test Question 25");
        Console.WriteLine();

        // Test Question 26
        Console.WriteLine("Test Question 26");
        Console.WriteLine();

        // Test Question 27
        Console.WriteLine("Test Question 27");
        Console.WriteLine();

        // Test Question 28
        Console.WriteLine("Test Question 28");
        Console.WriteLine();

        // Test Question 29
        Console.WriteLine("Test Question 29");
        Console.WriteLine();
    }


    /// <summary>
    /// Write a C# Sharp program to accept two integers and check whether they are equal or not.
    /// Test Data :
    /// Input 1st number: 5
    /// Input 2nd number: 5
    /// Expected Output :
    /// 5 and 5 are equal
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public static string Q1(int num1, int num2)
    {
        return num1 == num2 ? $"{num1} and {num2} are equal" : $"{num1} and {num2} are not equal";
    }

    /// <summary>
    /// Write a C# Sharp program to check whether a given number is even or odd.
    /// Test Data : 15
    /// Expected Output :
    /// 15 is an odd integer
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static string Q2(int num)
    {
        string result = num % 2 == 0 ? "even" : "odd";

        return $"{num} is an {result} integer";
    }

    /// <summary>
    /// Write a C# Sharp program to check whether a given number is positive or negative.
    /// Test Data : 14
    /// Expected Output :
    /// 14 is a positive number
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static string Q3(int num)
    {
        string result = num >= 0 ? "positive" : "negative";
        return $"{num} is a {result} number";
    }

    /// <summary>
    /// Write a C# Sharp program to find out whether a given year is a leap year or not.
    /// Test Data : 2016
    /// Expected Output :
    /// 2016 is a leap year.
    /// </summary>
    /// <param name="year"></param>
    /// <returns></returns>
    public static string Q4(int year)
    {
        return year % 4 == 0 && year % 100 != 0 ? $"{year} is a leap year" : $"{year} is not a leap year";

    }

    /// <summary>
    /// Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
    /// Test Data : 21
    /// Expected Output:
    /// Congratulation! You are eligible for casting your vote.
    /// </summary>
    /// <param name="age"></param>
    /// <returns></returns>
    public static string Q5(int age)
    {
        return age > 17 ? "Congratulation! You are eligible for casting your vote" : "You are not eligible for casting your vote";
    }

    /// <summary>
    /// Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 
    /// 0 when m is 0 and -1 when m is less than 0.
    /// Test Data : -5
    /// Expected Output:
    /// The value of n = -1
    /// </summary>
    /// <param name="m"></param>
    /// <returns></returns>
    public static int Q6(int m)
    {
        if (m > 0) return 1;
        if (m == 0) return 0;
        return -1;
    }

    /// <summary>
    /// Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
    /// Test Data : 135
    /// Expected Output :
    /// The person is Dwarf.
    /// </summary>
    /// <param name="h"></param>
    /// <returns></returns>
    public static string Q7(int h)
    {
        if (h < 150)
        {
            return "The person is Dwarf";
        }
        else if (h >= 150 && h <= 165)
        {
            return "The person is normal height";
        }
        else if (h >= 165 && h <= 195)
        {
            return "The person is taller";
        }
        else
        {
            return "The person is abnormal height";
        }
    }

    /// <summary>
    /// Write a C# Sharp program to find the largest of three numbers.
    /// Test Data :
    /// Input the 1st number :25
    /// Input the 2nd number :63
    /// Input the 3rd number :10
    /// Expected Output :
    /// The 2nd Number is the greatest among three
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <param name="num3"></param>
    /// <returns></returns>
    public static string Q8(int num1, int num2, int num3)
    {
        if (num1 > num2)
        {
            if (num1 > num3)
            {
                return "The 1st Number is the greatest among three";
            }
            else
            {
                return "The 3rd Number is the greatest amount three";
            }
        }
        else if (num2 > num3)
        {
            return "The 2nd Number is the greatest amount three";
        }
        else
        {
            return "The 3rd Number is the greatest amount three";
        }
    }


    /// <summary>
    /// Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
    /// Test Data :
    /// Input the value for X coordinate :7
    /// Input the value for Y coordinate :9
    /// Expected Output :
    /// The coordinate point(7,9) lies in the First quadrant.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public static string Q9(int x, int y)
    {
        if (x > 0)
        {
            if (y > 0)
            {
                return $"The coordinate point({x},{y}) lies in the First quadrant.";
            }
            else
            {
                return $"The coordinate point({x},{y}) lies in the forth quadrant.";
            }
        }
        else
        {
            if (y > 0)
            {
                return $"The coordinate point({x},{y}) lies in the second quadrant.";
            }
            else
            {
                return $"The coordinate point({x},{y}) lies in the third quadrant.";
            }
        }
    }

    /// <summary>
    /// Write a C# Sharp program to determine the eligibility for admission to a professional course based on the following criteria:
    /// Marks in Maths >=65
    /// Marks in Phy >=55
    /// Marks in Chem>=50
    /// Total in all three subject >=180
    /// or
    /// Total in Math and Subjects >=140
    /// Test Data :
    /// Input the marks obtained in Physics :65
    /// Input the marks obtained in Chemistry :51
    /// Input the marks obtained in Mathematics :72
    /// Expected Output :
    /// The candidate is eligible for admission.
    /// </summary>
    /// <param name="Maths"></param>
    /// <param name="Phy"></param>
    /// <param name="Chem"></param>
    /// <returns></returns>
    public static string Q10(int Maths, int Phy, int Chem)
    {
        int total = Maths + Phy + Chem;
        if (Maths >= 65 && Phy >= 55 && Chem >= 50)
        {
            if (total >= 180 || (Maths + Phy >= 140))
            {
                return "The candidate is eligible for admission";
            }
            else
            {
                return "The candidate is not eligible for admission ";
            }
        }
        else
        {
            return "The candidate is not eligible for admission ";
        }
    }

    /// <summary>
    /// Write a C# Sharp program to calculate the root of a quadratic equation.
    /// Test Data :
    /// Input the value of a : 1
    /// Input the value of b : 5
    /// Input the value of c : 7
    /// Expected Output :
    /// Root are imaginary;
    /// No Solution.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <returns></returns>
    public static string Q11(int a, int b, int c)
    {
        return "";
    }

    /// <summary>
    /// Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
    /// Test Data :
    /// Input the Roll Number of the student :784
    /// Input the Name of the Student :James
    /// Input the marks of Physics, Chemistry and Computer Application : 70 80 90
    /// Expected Output :
    /// Roll No : 784
    /// Name of Student : James
    /// Marks in Physics : 70
    /// Marks in Chemistry : 80
    /// Marks in Computer Application : 90
    /// Total Marks = 240
    /// Percentage = 80.00
    /// Division = First
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static void Q12()
    {
        Console.Write("Input the Roll Number of the student :");
        double rollNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the name of the Studednt :");
        string name = Console.ReadLine();
        Console.WriteLine("Input the marks of ");
        Console.Write("Physics:");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.Write("Chemistry:");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Computer Application:");
        double com = Convert.ToDouble(Console.ReadLine());

        double total = p + c + com;
        double per = total / 3;

        Console.WriteLine("Expected Output :");
        Console.WriteLine($"Roll No : {rollNumber}");
        Console.WriteLine($"Name of Student :{name}");
        Console.WriteLine($"Marks in Physics : {p}");
        Console.WriteLine($"Marks in Chemistry :{c}");
        Console.WriteLine($"Marks in Computer Application : {com}");
        Console.WriteLine($"Total Marks = {total}");
        Console.WriteLine($"Percentage = {per}");
        string rank = "";
        if (per >= 80)
        {
            rank = "first";
        }
        else if (per < 80 && per >= 70)
        {
            rank = "second";
        }
        else if (per < 70 && per >= 50)
        {
            rank = "pass";
        }
        else
        {
            rank = "fail";
        }
        Console.WriteLine($"Division = {rank}");
    }

    /// <summary>
    /// Write a C# Sharp program to read temperature in centigrade and display a suitable message according to the temperature state below:
    /// Temp< 0 then Freezing weather
    /// Temp 0-10 then Very Cold weather
    /// Temp 10-20 then Cold weather
    /// Temp 20-30 then Normal in Temp
    /// Temp 30-40 then Its Hot
    /// Temp >=40 then Its Very Hot
    /// Test Data :
    /// 42
    /// Expected Output :
    /// Its very hot.
    /// </summary>
    /// <param name="temp"></param>
    /// <returns></returns>
    public static string Q13(int temp)
    {
        if (temp < 0) return "Freezing weather";
        if (temp >= 0 && temp <= 10) return "Very Cold weather";
        if (temp >= 10 && temp <= 20) return "Cold weather";
        if (temp >= 20 && temp <= 30) return "Normal in Temp";
        if (temp >= 30 && temp <= 40) return "Its Hot";
        return "Its Very Hot";
    }

    /// <summary>
    /// Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
    /// Test Data :
    /// 50 50 60
    /// Expected Output :
    /// This is an isosceles triangle.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static string Q14(int a, int b, int c)
    {
        if (a == b)
        {
            if (a == c)
            {
                return "This ia a Equilateral triangle.";
            }
            else
            {
                return "This is an isosceles triangle.";
            }
        }
        else if (a == c || b == c)
        {
            return "This is an isosceles triangle.";
        }
        else
        {
            return "This is Scalene triangle.";
        }
    }

    /// <summary>
    /// Write a C# Sharp program to check whether a triangle can be formed by the given angles value.
    /// Test Data :
    /// 40 55 65
    /// Expected Output :
    /// The triangle is not valid.
    /// </summary>
    /// <returns></returns>
    public static string Q15(int a1, int a2, int a3)
    {
        if(a1 + a2 + a3 == 180)
        {
            return "The triangle is valid";
        }
        else
        {
            return "The triangle is not valid";
        }
    }
    /// <summary>
    /// Write a C# Sharp program to check whether an alphabet letter is a vowel or a consonant.
    /// Test Data :
    /// k
    /// Expected Output :
    /// The alphabet is a consonant.
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string Q16(char c)
    {
        if(c == 'a' || c == 'i' || c == 'o' || c == 'u' ||  c == 'e')
        {
            return "The alphabet is a vowel.";
        }
        return "The alphabet is a consonant.";
    }

    /// <summary>
    /// Write a C# Sharp program to calculate profit and loss on a transaction.
    /// Test Data :
    /// 500 700
    /// Expected Output :
    /// You can book your profit amount : 200
    /// </summary>
    /// <param name="cost"></param>
    /// <param name="amnt"></param>
    /// <returns></returns>
    public static string Q17(double cost, double amnt)
    {
        return $"You can book your profit amount : {amnt - cost}";
    }

    /// <summary>
    /// Write a C# Sharp program to calculate and print the electricity bill of a customer. From the keyboard, the customer's name, ID, and unit consumed should be taken and displayed along with the total amount due.
    /// The charge are as follow :
    /// Unit
    /// Charge/unit
    /// upto 199
    /// @1.20
    /// 200 and above but less than 400
    /// @1.50
    /// 400 and above but less than 600
    /// @1.80
    /// 600 and above
    /// @2.00
    /// 
    /// If bill exceeds Rs. 400 then a surcharge of 15% will be charged and the minimum bill should be of Rs. 100/-
    /// Test Data :
    /// 1001
    /// James
    /// 800
    /// Expected Output :
    /// Customer IDNO :1001
    /// Customer Name :James
    /// unit Consumed :800
    /// Amount Charges @Rs. 2.00 per unit : 1600.00
    /// Surchage Amount : 240.00
    /// Net Amount Paid By the Customer : 1840.00
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static void Q18(int Id, string CustomerName, double UnitCons)
    {
        double UnitCharge = 0;
        if (UnitCons <= 199)
        {
            UnitCharge = 1.2;
        }
        else if(UnitCons >= 200 && UnitCons <= 400)
        {
            UnitCharge = 1.5;
        }
        else if(UnitCons > 400 && UnitCons <= 600)
        {
            UnitCharge = 1.8;
        }
        else
        {
            UnitCharge = 2;
        }

        double amount = UnitCharge * UnitCons;
        Console.WriteLine($"Customer IDNO :{Id}");
        Console.WriteLine($"Customer Name :{CustomerName}");
        Console.WriteLine($"Unit Consumed :{UnitCons}");
        Console.WriteLine($"Amount Charegs @Rs. {UnitCharge} per unit :{amount}");

        double subcharge = 0;
        if(amount > 400)
        {
            subcharge = amount + amount * (15 / 100);
        }
        Console.WriteLine($"Net Amount Paid By the Cusomter : {amount + subcharge}");

    }

    /// <summary>
    /// Write a program in C# Sharp to accept a grade and declare the equivalent description :
    /// Grade
    /// Description
    /// E
    /// Excellent
    /// V
    /// Very Good
    /// G
    /// Good
    /// A
    /// Average
    /// F
    /// Fail
    /// 
    /// Test Data :
    /// Input the grade :a
    /// Expected Output :
    /// You have chosen : Average
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    public static string Q19(char grade)
    {
        
        if (grade == 'E' || grade == 'e') return "Excellent";
        if (grade == 'V' || grade == 'v') return "Very Good";
        if (grade == 'G' || grade == 'g') return "Good";
        if (grade == 'A' || grade == 'a') return "Average";
        return "Fail";
    }

    /// <summary>
    /// Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.
    /// Test Data :
    /// 4
    /// Expected Output :
    /// Thursday
    /// </summary>
    /// <param name="DayNumber"></param>
    /// <returns></returns>
    public static void Q20(int DayNumber)
    {
        switch (DayNumber)
        {
            case 1:
                Console.WriteLine("Saturday");
                break;
            case 2:
                Console.WriteLine("Sunday");
                break;
            case 3:
                Console.WriteLine("Monday");
                break;
            case 4:
                Console.WriteLine("Tuesday");
                break;
            case 5:
                Console.WriteLine("Wednesday");
                break;
            case 6:
                Console.WriteLine("Thursday");
                break;
            case 7:
                Console.WriteLine("Friday");
                break;
            default:
                Console.WriteLine("Invaild day number");
                break;
        }
       
    }

    /// <summary>
    /// 21. Write a program in C# Sharp to read any digit, display in the word.
    /// Test Data :
    /// 4
    /// Expected Output :
    /// Four
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static void Q21(int digit)
    {
        switch (digit)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Tow");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("Invalid digit");
                break;
        }
    }

    /// <summary>
    /// Write C# Sharp program to read any Month Number in integer and display Month name.
    /// Test Data :
    /// 4
    /// Expected Output:
    /// April
    /// </summary>
    /// <param name="month"></param>
    /// <returns></returns>
    public static void Q22(int month)
    {
        switch (month)
        {
            case 1:
                Console.WriteLine("January");
                break;
            case 2:
                Console.WriteLine("Feberuary");
                break;
            case 3:
                Console.WriteLine("March");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("June");
                break;
            case 7:
                Console.WriteLine("July");
                break;
            case 8:
                Console.WriteLine("August");
                break;
            case 9:
                Console.WriteLine("Septemper");
                break;
            case 10:
                Console.WriteLine("October");
                break;
            case 11:
                Console.WriteLine("November");
                break;
            case 12:
                Console.WriteLine("December");
                break;
            default:
                Console.WriteLine("Invalid month");
                break;
        }
    }


    /// <summary>
    /// Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month.
    /// Test Data :
    /// 7
    /// Expected Output:
    /// Month have 31 days
    /// </summary>
    /// <param name="month"></param>
    /// <returns></returns>
    public static void Q23(int month)
    {
        switch (month)
        {
            case 1:
            case 3: 
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Month have 31 days");
                break;
            case 2:
                Console.WriteLine("The Febraury Month have 28 days but in leap year the month have 29 days");
                break;
            case 4: 
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Month have 30 days");
                break;
            default:
                Console.WriteLine("Invalid month number");
                break;
        }
    }

    /// <summary>
    /// Write a C# Sharp program that calculates the area of geometrical shapes using a menu-driven approach.
    /// Test Data :
    /// Input your choice : 1
    /// Input radius of the circle : 5
    /// Expected Output :
    /// The area is : 78.500000
    /// </summary>
    /// <param name="option"></param>
    /// <returns></returns>
    public static void Q24(int option)
    {
        double area = 0;
        switch (option)
        {
            case 1: // Circle
                Console.Write("Input radius of the circle:");
                double r = Convert.ToDouble(Console.ReadLine());
                area = r * r * 3.14;
                break;
            case 2: // Rectangle
                Console.Write("Input width of the rectangle:");
                double w = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input height of the rectangle:");
                double h = Convert.ToDouble(Console.ReadLine());
                area = w * h;
                break;
            case 3: // Trainglar
                Console.Write("Input width of the rectangle:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input height of the rectangle:");
                double h1 = Convert.ToDouble(Console.ReadLine());
                area = 1/2 * b * h1;
                break;
            default:
                Console.WriteLine("Invalid your choice");
                break;

        }
        Console.WriteLine($"The area is : {area}");
    }

}
