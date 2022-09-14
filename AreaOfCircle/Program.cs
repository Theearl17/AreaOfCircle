Console.WriteLine("Enter the radius of your circle?");
var radius = double.Parse(Console.ReadLine());
Console.WriteLine($" Your area of a circle is:{AreaOfCircle(radius)}");


    static double AreaOfCircle(double radius)

{
    return Math.PI * Math.Pow (radius, 2); 
}