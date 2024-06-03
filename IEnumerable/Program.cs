namespace IEnumerable
{
    using System.Collections;
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> name = new List<string>(){"shina", "ai", "nakiri"};
            
            IEnumerator<string> enumerator = name.GetEnumerator();
            /*MyIEnumerable ie = new MyIEnumerable(name.ToArray());*/
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
