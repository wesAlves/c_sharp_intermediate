namespace EditoMTZ.ebook;

public abstract class Ebook
{
    public string name { get; protected set; }
    public string id { get; protected set; }


    public abstract void Create();

    public void ReadDataFromFile(object file)
    {
        for (var i = 0; i < 100;)
        {
            Console.WriteLine("jaca {0}", i);
            i++;
        }
    }

    public void Rename(string newName)
    {
        name = newName;
    }

    public void Download()
    {
        Console.WriteLine("Downloading file...");
    }
}