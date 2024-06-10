using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input file path: ");
        string folderPath = Console.ReadLine()??"";
        Console.WriteLine("Input new file name: ");
        string newFileName= Console.ReadLine()??"";
        if(!Directory.Exists(folderPath) || !File.Exists(folderPath) || string.IsNullOrEmpty(folderPath)||string.IsNullOrEmpty(newFileName)){
            Console.WriteLine(new Exception("Ye kya kr rho, ye murkhta hamare sath mat kro"));
            Console.ReadLine();
            return;
        } 
        int i=0;
        string[] files = Directory.GetFiles(folderPath);
        foreach (string filePath in files)
        {
            try{
            FileInfo fileInfo = new FileInfo(filePath);
            string fileName = fileInfo.Name;
            newFileName += i.ToString()+".png";
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

