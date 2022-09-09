using System;
namespace MyFourthProject
{
    public class MyTests
    {
        public static void Main(String[] args)
        {
            // string rootPath = @"/Users/adinashby/Desktop/MyFolder/Folder1";

            //string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);
            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

            //foreach (string file in files)
            //{
            // Console.WriteLine(file);
            // Console.WriteLine(Path.GetFileName(file));
            // Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            // Console.WriteLine(Path.GetFullPath(file));
            // Console.WriteLine(Path.GetDirectoryName(file));

            // var info = new FileInfo(file);
            // Console.WriteLine("Hello " + varName)
            // Console.WriteLine($"Hello { varName }");

            //Console.WriteLine($"{ Path.GetFileName(file) }: {info.Length } bytes");

            //}

            //string newPath = @"/Users/adinashby/Desktop/MyFolder/Folder3";

            //bool directoryExists = Directory.Exists(@"/Users/adinashby/Desktop/MyFolder/Folder3");

            //if (directoryExists)
            //{
            //    Console.WriteLine("The directory exists!");
            //}
            //else
            //{
            //    Console.WriteLine("The directory doesn't exist :(");
            //    Directory.CreateDirectory(newPath);
            //}



            //string[] files = Directory.GetFiles(rootPath);
            //string destinationFolder = @"/Users/adinashby/Desktop/MyFolder/Folder3";

            //foreach (string file in files)
            //{
            //    File.Copy(file, $"{destinationFolder}/{Path.GetFileName(file)}");
            //}

            //foreach (string file in files)
            //{
            //    File.Move(file, $"{destinationFolder}/{Path.GetFileName(file)}");
            //}

            string rootPath = @"/Users/adinashby/Desktop/MyFolder";

            string[] dirs = Directory.GetDirectories(rootPath, "Folder*", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(rootPath, "test*.txt", SearchOption.AllDirectories);

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }


        }
    }
}

