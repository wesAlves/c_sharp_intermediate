//TODO:
//Upload a file, in format .docx or .xml
//The file must have attributes for each block in xml structure
//Create a entry in database, file, building block, user processing

using EditoMTZ.ebook;

var ebook01 = new HtmlFormat("jaca", "1243");
ebook01.ReadDataFromFile();

var dirPath = @"../../../../EditoMTZ/file.txt";

using (var myFile = new StreamReader(dirPath))
{
    Console.WriteLine(myFile.ReadToEnd());
}

// var myDir = Directory.EnumerateDirectories(dirPath);
//
// foreach (var directory in myDir)
// {
//     Console.WriteLine(directory);
// }
