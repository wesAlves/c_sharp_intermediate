using System.IO.Packaging;
using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace EditoMTZ.ebook;

public abstract class Ebook
{
    public string name { get; protected set; }
    public string id { get; protected set; }


    public abstract void Create();

    public void ReadDataFromFile(string dirPath)
    {
        //Need to open a package first
        Package wordPackage = Package.Open(dirPath, FileMode.Open, FileAccess.Read);

        //open the word processing document based on packege
        using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(wordPackage))
        {
            Body body = wordDocument.MainDocumentPart.Document.Body;

            foreach (var element in body)
            {
                var att = element.GetAttributes();

                foreach (var at in att)
                {
                    Console.WriteLine(at.XName);
                }
                
                
            }
        }


        // using var myFile = new StreamReader(dirPath);
        // Console.WriteLine(myFile.ReadToEnd());
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