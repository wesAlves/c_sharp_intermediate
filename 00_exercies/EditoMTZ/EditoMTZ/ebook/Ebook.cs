namespace EditoMTZ.ebook;

public abstract class Ebook
{
    public string name { get; protected set; }
    public string id { get; protected set; }


    public abstract void Create();

    public void ReadDataFromFile()
    {

        // var myDir = Directory.GetDirectories("../../");
        //
        // Console.WriteLine(myDir);
        
        // try
        // {
        //     using var myFile = new StreamReader("*.txt");
        //     Console.WriteLine(myFile.ReadToEnd());
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e);
        // }
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