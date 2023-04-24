namespace Bai_Giua_Ki
{
    internal class Result
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the cylinder: ");
            double radius = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of the cylinder: ");
            double height = double.Parse(Console.ReadLine());

            Cylinder cylinder = new Cylinder(radius, height);
            cylinder.Process();

            Console.WriteLine("Cylinder Calculations:");
            Console.WriteLine(cylinder.Result());
        }
    }
}