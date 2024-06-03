using System.Linq;

namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<students> students = new List<students>();
            students.Add(new students("Dat",20));
            students.Add(new students("Vinh",100));
            students.Add(new students("Kha",1));
            students.Add(new students("Hai",30));
            students.Add(new students("Khang", 2));

            List<students> result = new List<students>();

            /*result = students.Where(n => n.Name.Contains("a")).ToList();*/
            result = students.Skip(2).Take(2).ToList();
            /*var result2 = result.OrderBy(s => s.Age);*/

            /*foreach (var word1 in st)
            {
                if (word1.Name.Contains("a"))
                {
                    result.Add(word1);
                }
            }*/

            foreach (students s in result)
            {
                Console.WriteLine(s.Name +" " + s.Age);
            }
        }
    }
}
