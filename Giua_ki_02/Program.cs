namespace Giua_ki_02
{
    internal class Program
    {
        class Animal
        {
            public double weight;
            public string name;

            public void Show()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Weight: " + weight);
            }

            public void SetMe(double weight, string name)
            {
                this.weight = weight;
                this.name = name;
            }
        }

        class Lion : Animal
        {
            public Lion(double weight, string name)
            {
                SetMe(weight, name);
            }
        }

        class Tiger : Animal
        {
            public Tiger(double weight, string name)
            {
                SetMe(weight, name);
            }
        }
        static void Main(string[] args)
        {
            Lion lion = new Lion(200, "Simba");
            Tiger tiger = new Tiger(150, "Shere Khan");

            lion.Show();
            tiger.Show(); 
        }
    }
}