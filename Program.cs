namespace Задание_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Random rnd = new Random();
            while (true)
            {
                Console.WriteLine("Задайте необходимое количество чисел N. ");
                Console.Write("Введите N: ");
                n = int.Parse(Console.ReadLine());
                List<int> values = new List<int>(n);
                for (int i = 0; i < n; i++)
                {
                    int x = rnd.Next(-1000, 1001);
                    values.Add(x);
                }
                foreach (int i in values)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine("\nMax число: " + values.Max());
                Console.WriteLine("Min число: " + values.Min() + "\n");
                Console.WriteLine("\tНажмите Enter для нового цикла.");
                Console.ReadKey();
            }
        }
    }
}