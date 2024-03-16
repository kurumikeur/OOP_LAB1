// See https://aka.ms/new-console-template for more information
using Zadanie2;

Console.WriteLine("Hello, World!");

Date time = new EU_Date();
time = new EU_DateDecorator(time);

Console.WriteLine(time.GetTime());