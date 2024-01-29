namespace EditoMTZ.ebook;

public abstract class Ebook
{
    public string name { get; protected set; }
    public string id { get; protected set; }


    public void Rename(string newName)
    {
        name = newName;
    }

    public void Download()
    {
        Console.WriteLine("Downloading file...");
    }

    public abstract void Create();
}