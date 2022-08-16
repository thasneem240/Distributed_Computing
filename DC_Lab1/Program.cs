using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC_Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World");
            Console.WriteLine("Computing");
            Console.WriteLine(3 + 4);
            Console.Write("Hello ");
            Console.Write("Thasneem Age is ");

            const int num = 18;
            Console.Write(num + "\n");

            long num1 = 1545656L;
            Console.WriteLine(num1);

            float num2 = 18.3f;
            Console.WriteLine(num2);

            double num3 = 18.36789D;
            Console.WriteLine(num3);

            // Type Conversion Methods

            int number = 10;
            double number2 = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(number));
            Console.WriteLine(Convert.ToDouble(number));

            Console.WriteLine(Convert.ToInt32(number2));

            Console.WriteLine(Convert.ToString(myBool));


            //User Input
            Console.Write(" Please Enter Your Name: ");

            string name = Console.ReadLine();
            
            Console.WriteLine(" My name is " + name);

            Console.Write(" Please Enter Your Age: ");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" My Age is " + age);

            // C# Math

            Console.WriteLine(Math.Max(5,10));
            Console.WriteLine(Math.Min(5,10));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Round(9.99));

            // C# Strings

            string txt = "Hello";
            Console.WriteLine(" Length: " + txt.Length);
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());

            string firstName = "Mohamed";
            string lastName = "Thasneem";
            string fullname = firstName + " " + lastName;
            Console.WriteLine(fullname);

            string fullname2 = string.Concat(firstName, lastName);
            Console.WriteLine(fullname2);

            string name2 = $"Name: {firstName} {lastName}"; // String interpolation
            Console.WriteLine(name2);

            Console.WriteLine(txt[0]);
            Console.WriteLine(txt[1]);

            Console.WriteLine(txt.IndexOf("o"));
            Console.WriteLine(txt.IndexOf("p"));

            string txt2 = "Hello world";
            int charPos = txt2.IndexOf("w");
            string newTxt = txt2.Substring(charPos);
            Console.WriteLine(newTxt);

            // Hello "SLIIT" world

            string txt3 = "Hello \"SLIIT\" world";
            Console.WriteLine(txt3);

            int a = 10;
            int b = 20;

            int c = a + b;
            Console.WriteLine(c);

            string d = "10";
            string f = "20";

            string g = d + f;
            Console.WriteLine(g);

            // C# Arrays

            string[] cars;
            cars = new string[] {"Volvo","BMW","Ford" };

            int[] myNumber = { 10,20,30,40};

            Console.WriteLine(cars[0]);

            cars[0] = "Opel";
            Console.WriteLine(cars[0]);

            Console.WriteLine(cars.Length);

            Array.Sort(cars);

            foreach (string car in cars) 
            {
                Console.Write(car + " ");
            }

            Console.WriteLine("\n" + myNumber.Max());
            Console.WriteLine(myNumber.Min());
            Console.WriteLine(myNumber.Sum());

            string[] arr1 = new string[4];
            arr1[0] = "ASD";
            arr1[1] = "QWE";

            string[] arr2 = new string[4] { "dsf","dsdfds","fdf","rtyrt"};
            string[] arr3 = new string[] { "dsf", "dsdfds", "fdf", "rtyrt", "tyy" };
            string[] arr4 = { "dsf", "dsdfds", "fdf", "rtyrt", "tyy" };

            string[] arr5; // Assigning the value later

            // arr5 = { "dsf", "dsdfds", "fdf", "rtyrt", "tyy" }; This will give error we must use new key word here

            arr5 = new string[] { "dsf", "dsdfds", "fdf", "rtyrt", "tyy" };
             











            Console.ReadLine();
        }
    }
}
    
