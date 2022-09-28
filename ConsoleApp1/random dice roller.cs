using System;
//CalcCirclePerimeter() - this will take in a radius and use that to find the perimeter of the circle and return it.
//GenerateRandomCircle() - this will Create a random object, and geenrate a number from 1 to 100 and pass that number into the CalcPerimeter()


//with tthe next mehod in C#, the first number aka the min is inclusive
// The second aka your max number is exclusive

internal class Program
{
    public static void Main(string[] args)
    {
        double rad = GetRadius();
        double p = GetPerm (rad);
            Console.WriteLine(p);
        Console.WriteLine("Radius: ");
        Console.WriteLine("perm is"
       

        static double GetPerm(double radius)
        {
           double perimeter = 2 * Math.PI * radius;
            return perimeter;   
        }
      
        static double GetRadius()
        { 
         Random r = new Random();
            double radius = r.Next(1,101);
            return radius;
        }
    }
}