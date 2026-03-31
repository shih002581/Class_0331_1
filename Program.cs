namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student joe, mary;

            joe = new Student(1234, "AAA", 92, 88);

            Console.WriteLine(joe.GotStuden());

            Console.WriteLine(Student.count.ToString());

            //Console.WriteLine(joe.count.ToString());
            mary = new Student(1234, "AAA", 92, 88);

            //.WriteLine(mary.ToString());
            Console.WriteLine(Student.count.ToString());

        }
    }
}
