//TODO:
    //Upload a file, in format .docx or .xml
    //The file must have attributes for each block in xml structure
    //Create a entry in database, file, building block, user processing

    using EditoMTZ.ebook;

    var ebook01 = new HTMLFormat();
    ebook01.Create();
    

    Console.WriteLine(ebook01.id);
    // Console.WriteLine(ebook01.name);