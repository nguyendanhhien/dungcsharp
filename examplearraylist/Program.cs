public class Program
{
    public static void Main(string[] args)
    {
        List<string> mylist = new List<string>();
        mylist.Add("Organge");
        mylist.Add("Banana");
        mylist.Add("Lemon");
        foreach (var item in mylist)
        {
            Console.WriteLine(item);

        }
        for (var i = 0; i < mylist.Count; i++)
        {
            Console.WriteLine(mylist[i]);
        }
    }
}
