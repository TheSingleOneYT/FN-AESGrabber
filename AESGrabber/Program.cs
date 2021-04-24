using System.Net;
using System.Diagnostics;
using System.IO;
using System;

namespace AESGrabber
{
    class Program
    {
        const string aesurl = @"https://benbotfn.tk/api/v1/aes";
        static void Main(string[] args)
        {
            var wc = new WebClient();
            Console.WriteLine("Executing, gaining AES keys...");
            var aes = wc.DownloadString(aesurl).Split(new[] { '\r', '\n' })[0].Replace(" ", "");
            Console.WriteLine("Grabbed AES key(s)");
            Console.WriteLine(aes + "\nType Open To Open AES Key File.");
            var EXELoc = Directory.GetCurrentDirectory();
            File.WriteAllText(EXELoc + "/AESKeys.txt", aes);
            var Response = Console.ReadLine();

            if (Response == "Open")
            {
                Process.Start(EXELoc + "/AESKeys.txt");
                Console.ReadLine();
            }
            else
            {
                
            }
        }
    }
}