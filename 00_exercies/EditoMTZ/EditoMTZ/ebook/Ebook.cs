namespace EditoMTZ.ebook;

public abstract class Ebook
{
    public string name { get; set; }
    public string id { get; set; }



    public abstract void Create();
}

public class HTMLFormat : Ebook
{
    public override void Create()
    {
        Console.WriteLine("Creating HTML data file");
    }
}