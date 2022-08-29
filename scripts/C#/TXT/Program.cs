using System;
using System.IO;
string fileName = @"C:\Users\kater\source\repos\Convertor\Convertor\people.txt";

string text = File.ReadAllText(fileName);
Console.WriteLine(text);
