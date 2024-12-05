using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //1-Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("Enter A Number");
            //int Number;
            //bool flag= int.TryParse(Console.ReadLine(), out Number);
            //if (flag)
            //    Console.WriteLine(Number);
            //else
            //    Console.WriteLine("Please Enter A Number"); 
            #endregion

            #region Q02
            //2-Write C# program that converts a string to an integer,
            //but the string contains non-numeric characters. And mention what will happen 
            //Console.Write("Enter Msg : ");
            //string msg = Console.ReadLine();
            //int Num;
            //if(int.TryParse(msg,out Num))
            //    Console.WriteLine("string contains numeric characters");
            //else
            //    Console.WriteLine("string contains non-numeric characters");
            //when user enter non-numeric characters int.TryParse(msg,out Num) will return false and execute else statement


            #endregion

            #region Q03
            ////3-Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //Console.Write("Enter first Number");
            //double Num01=Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter second Number");
            //float Num02 = float.Parse(Console.ReadLine());
            //Console.WriteLine($"Sum {Num01} + {Num02} = {Num01+Num02}");
            //floating number must declare = > float num=Value F; to make the compiler understand that is float
            #endregion

            #region Q04
            ////4-Write C# program that Extract a substring from a given string.
            //Console.Write("Enter Original String: ");
            //string OriginalString=Console.ReadLine();
            //Console.Write("Enter the starting index of the substring : ");
            //int index=int.Parse(Console.ReadLine());
            //Console.Write("Enter the length of the substring : ");
            //int len=int.Parse(Console.ReadLine());
            //Console.WriteLine($"Extracted substring : {OriginalString.Substring(index,len)}");


            #endregion

            #region Q05
            //5-Write C# program that Assigning one value type variable to another
            //and modifying the value of one variable and mention what will happen
            //int Number01 = 10;
            //int Number02 = Number01;
            ////Copy the Value of Number01 to Number02
            //Number01 = 20;
            //the value of Number01 changed to 20
            // Number01=20      |   Number02=10
            #endregion

            #region Q06
            //6-Write C# program that Assigning one reference type variable to another
            //and modifying the object through one variable and mention what will happen
            //object obj01 = new object();
            //obj01 = "First Object";
            //object obj02 = new object();
            //obj02 = obj01;
            //// Now obj01 and obj02 refer to same object 
            //obj02 = "Second Object";
            ////create new object and obj02 still refer to "First Object"
            //Console.WriteLine(obj01);
            #endregion

            #region Q07
            //7-Write C# program that take two string variables and print them as one variable 
            //Console.Write("Enter first text : ");
            //string text01 = Console.ReadLine();
            //Console.Write("Enter second text : ");
            //string text02 = Console.ReadLine();
            //string allText = string.Format("{0}{1}", text01, text02);
            //Console.WriteLine(allText);
            #endregion

            #region Q08
            //8-	Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is 
            // Interest = (principal * rate * time) / 100
            //Console.WriteLine("Enter the Principal : ");
            //double Principal=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the Rate : ");
            //double Rate = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the Time : ");
            //double Time = Convert.ToDouble(Console.ReadLine());
            //double Interest = (Principal * Rate * Time) / 100;
            //Console.WriteLine($"Interest = {Interest}");
            #endregion

            #region Q09
            //9-	Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is
            // BMI = (Weight) / (Height * Height)
            //Console.Write("Enter the Weight in kilograms : ");
            //double weight=double.Parse(Console.ReadLine());
            //Console.Write("Enter the height in meters: ");
            //double height = double.Parse(Console.ReadLine());
            //double BMI = (weight) / (height * height);
            //Console.WriteLine($"BMI = {BMI}");
            #endregion

            #region Q10
            //10-	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
            //Console.WriteLine("Enter The Temperature");
            //int Temperature=int.Parse(Console.ReadLine());
            //string msg = Temperature < 10 ? "Just Cold" : Temperature > 30 ? "Just Hot" : "Just Good";
            //Console.WriteLine(msg);

            #endregion

            #region Q11
            //            11 - Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex:
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001
            //------------------------------------------------------------
            //Console.WriteLine("Enter the date (yyyy/mm/dd)");
            //string date = Console.ReadLine();
            //DateOnly dateOnly =DateOnly.Parse(date);
            //Console.WriteLine($"Today’s date : {dateOnly.Day} , {dateOnly.Month} , {dateOnly.Year}");
            //Console.WriteLine($"Today’s date : {dateOnly.Day} / {dateOnly.Month} / {dateOnly.Year}");
            //Console.WriteLine($"Today’s date : {dateOnly.Day} - {dateOnly.Month} - {dateOnly.Year}");



            #endregion

            #region Q12
            //DateTime date = new DateTime(2024, 6, 14); 
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            // The Output is The event is on 06/14/2024 (C)
            #endregion

            #region Q13
            //    f)	A value 1 will be assigned to d. 
            //because !(30<20) ==> true ==> 1
            #endregion

            #region Q14
            //d)	6 1
            #endregion



        }
    }
}
