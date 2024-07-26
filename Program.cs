public class LINQWithListCollection
{
    public static void Main(string[]args)
    {
        // populate a List of strings
        List<string> items = new List<string>();
        items.Add("aQua");
        items.Add("RusT");
        items.Add("yElLow");
        items.Add("rEd");

        // convert all strings to uppercase; select those starting with "R"
        var startsWithR =
            from item in items
            let uppercaseString = item.ToUpper()
            where uppercaseString.StartsWith("R")
            orderby uppercaseString
            select uppercaseString;

        // display query results
        foreach (var item in startsWithR)
            Console.Write($"{item} ");

        Console.WriteLine();

        items.Add("rUbY");
        items.Add("SaFfRon");

        //display updated query results
        foreach(var item in startsWithR)
            Console.Write($"{item} ");

        Console.WriteLine();
    } // end Main
} // end class
