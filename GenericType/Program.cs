namespace GenericType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            //Console.WriteLine(list.Contains(1)); 
            //list.Remove(5);
            Console.WriteLine($"Sum:{list.Sum()}");
            //Sum ve remove alinmir
            Console.WriteLine(list);
            list.AddRange(6, 7, 8);
            Console.WriteLine(list);
        }
    }
}
