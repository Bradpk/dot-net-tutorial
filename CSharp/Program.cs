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

Console.WriteLine("Calculator Nation!");
Console.WriteLine("What is your name?");
name = Console.ReadLine();
Console.WriteLine("Hello " + name + ", what sort of math operation would you like to do?");

do{
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
    case "x":
        answer = num1 * num2;
        break;
    case "/":
        answer = num1 / num2;
        break;
}

Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + answer);

Console.WriteLine("Would you like to do another calculation?");
Console.WriteLine("Type Y for Yes, Type N for No");
} while (Console.ReadLine()?.ToUpper() == "Y");

Console.WriteLine("Okie Dokie, Cya Later!");
