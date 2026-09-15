
Console.WriteLine("Hello!");

Console.WriteLine("What was the total for your oil change?");

double oilChangeTotal = double.Parse(Console.ReadLine());

Console.WriteLine("What was the total for your tires?");

double tireTotal = double.Parse(Console.ReadLine());

Console.WriteLine("What was the total for your inspection?");

double inspectionTotal = double.Parse(Console.ReadLine());

double total = oilChangeTotal + tireTotal + inspectionTotal;
total = total + (total * 0.06); 
Console.WriteLine($"Your subtotal is: ${total:F2}");         
Console.WriteLine($"Your tax is: ${total - oilChangeTotal - tireTotal - inspectionTotal:F2}");
Console.WriteLine($"Your total with tax is: ${total:F2}");
