using System;
using System.IO;

class Program
{
    static void Main()
    {
        string folderPath = "F:\\HomeTogether_v0.22\\HomeTogether_v0.22\\HomeTogether\\Character";
       // string fileNameToRemove = "UserCreated";
        int i=0;

        string[] files = Directory.GetFiles(folderPath);
        foreach (string filePath in files)
        {
            try{
            FileInfo fileInfo = new FileInfo(filePath);
            string fileName = fileInfo.Name;
            string newFileName = i.ToString()+".png";
            string destinationPath = Path.Combine(folderPath, newFileName);
            if(File.Exists(destinationPath)){
                 i++;
                continue;
            }
            File.Move(filePath, destinationPath);
            Console.WriteLine($"File '{filePath}' renamed to '{destinationPath}'.");
            i++;
            }
            catch(Exception e){
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
        }
    }
}

