using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamspaces
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Example #2: Write one string to a text file.
            //string text = "we want to write this to our file.";
            //// WriteAllText creates a file, writes the specified string to the file,
            //// and then closes the file.    You do NOT need to call Flush() or Close().
            //File.WriteAllText(@"C:\Projects\CSharpBeginners\Lesson17\WriteText.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");
            File.WriteAllText(@"C:\Projects\CSharpBeginners\Lesson17\WriteText.txt", reply);


            // using namespace
            Console.WriteLine(reply);
            Console.ReadLine();
        }
    }
}