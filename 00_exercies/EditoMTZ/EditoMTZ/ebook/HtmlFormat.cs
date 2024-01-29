namespace EditoMTZ.ebook;

public class HtmlFormat : Ebook
{
    public HtmlFormat(string ctorName, string ctorId)
    {
        name = ctorName;
        id = ctorId;
    }
    public override void Create()
    {
        Console.WriteLine("Creating HTML data file");
    }
}