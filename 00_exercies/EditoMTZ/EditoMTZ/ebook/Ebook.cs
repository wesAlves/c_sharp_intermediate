namespace EditoMTZ.ebook;

public abstract class Ebook
{
    public string name { get; protected set; }
    public string id { get; protected set; }


    public abstract void Create();

    public void ReadDataFromFile(string dirPath)
    {

        using var myFile = new StreamReader(dirPath);
        Console.WriteLine(myFile.ReadToEnd());
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