Console.WriteLine("Input the Calculation");
var input = Console.ReadLine();
var elements = input.Split(' ');
var num1 = int.Parse(elements[0]);
var op = elements[1];
var num2 = int.Parse(elements[2]);
var result =0; 
var elements1 = input.Split('c');
while(elements1 == "c")
if (op == "+") {
    result = num1 + num2;
}
if (op == "-") {
    result = num1 - num2;
}
if (op == "*") {
    result = num1 * num2;
}
if (op == "/") {
    result = num1 / num2;
}
Console.WriteLine(result);
Console.WriteLine("If you wish to continue type (C)");
Console.Read();
