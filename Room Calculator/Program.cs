// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("welcome to Grand Circus' Room Detail Generator!");

double length;
double width;
double area;
double perimeter;
double volume;
double surfArea;
double height;



    Console.WriteLine("Please enter length");
    length = double.Parse(Console.ReadLine());
    Console.WriteLine("Please enter width");
    width = double.Parse(Console.ReadLine());
    Console.WriteLine("Please enter height");
    height = double.Parse(Console.ReadLine());
Console.WriteLine();

    area = length * width;
    Console.WriteLine("The area is  "+ area);
    perimeter = length + length + width + width;
    Console.WriteLine("The perimeteris  "+ perimeter);
    volume = area * height;
    Console.WriteLine("The volume is "+ volume);
    surfArea = (2*(length * height)) + (2*(length * width)) + (2*(width * height));
    Console.WriteLine("The surface area is  "+ surfArea);
Console.WriteLine();

if (area <= 250)
    {
        Console.WriteLine("This a small-sized room");
    }
    else if (area < 650)
    {
        Console.WriteLine("This is a medium-sized room");
    }
    else  if (area >= 650)
    {
               Console.WriteLine("This is a large-sized room");
    }
Console.WriteLine();
    Console.WriteLine("Thank you for using the room Detail Generator!");
