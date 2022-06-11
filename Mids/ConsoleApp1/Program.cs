// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text;

Console.WriteLine("Hello, World!");

string filename = @"H:\myfile.txt";
FileStream stream = null;
stream = new FileStream(filename, FileMode.OpenOrCreate);

using(StreamWriter writer = new StreamWriter(stream,  Encoding.UTF8))
{
    writer.WriteLine("First Lec of File Handling");
    writer.WriteLine("How do we write ti text file in C#");
    writer.WriteLine("Congrtas You Started Desktop Application Development");
}
if(stream != null)
    stream.Dispose();

