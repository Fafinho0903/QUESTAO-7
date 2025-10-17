int tab, i;


Console.WriteLine("Escreva o número para ser multiplicado:");
tab = int.Parse(Console.ReadLine());
Console.Clear();

i = 1;
while (i < 11)
{
    Console.WriteLine($"{tab} * {i} = {tab * i}");
    i = i + 1;
}
