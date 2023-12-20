// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.MapGet("/", () => "Hello Brad!");

// app.Run();
using System;


string? name;
string? operation;
int num1;
int num2; 
int answer = 0;

Console.WriteLine("Welcome to calculator nation");
Console.WriteLine("What is your name?");
name = Console.ReadLine();
Console.WriteLine("Hello " + name + " What sort of math operation would you like to do?");
Console.WriteLine("Type - for Substract, Type + for Addition, Type x for Multiplication, Type / for Division");
operation = Console.ReadLine();
Console.WriteLine("Pick First Number?");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pick Second Number?");
num2 = Convert.ToInt32(Console.ReadLine());




switch (operation)
{
    case "-": 
        answer = num1 - num2;
        break;
    case "+":
        answer = num1 + num2;
        break;
    case "/":
        answer = num1 * num2;
        break;
    case "x":
        answer = num1 / num2;
        break;
    default:
        Console.WriteLine("Invalid Operation, Try Again");
        break;
}

Console.WriteLine(num1 + " operation " + num2 + " = " + answer);

