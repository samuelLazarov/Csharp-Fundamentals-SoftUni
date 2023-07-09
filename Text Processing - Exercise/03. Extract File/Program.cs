string filePath = Console.ReadLine();

int lastIndexOfSlash = filePath.LastIndexOf(@"\") + 1;

int length = filePath.LastIndexOf(".") - filePath.LastIndexOf(@"\") - 1;

string fileName = filePath.Substring(lastIndexOfSlash, length);
    

string fileExt = filePath.Substring(filePath.LastIndexOf(".") + 1);

Console.WriteLine("File name: {0}", fileName);

Console.WriteLine("File extension: {0}", fileExt);


//Console.WriteLine("File name: {0}", Path.GetFileNameWithoutExtension(filePath));

//Console.WriteLine("File extension: {0}", Path.GetExtension(filePath).Trim('.'));