int tab, taba, tabb, i, m;


Console.WriteLine("Escreva o 1° número para ser multiplicado:");
tab = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o 2° número para ser multiplicado:");
taba = int.Parse(Console.ReadLine());
Console.WriteLine("\r");

i = 1;
tabb = tab;
m = 1;
while (tabb < taba+1)
{
    Console.WriteLine($"{tabb} * {m} = {tabb * m}\n");

    if (i != 11 )
    {
        i = i + 1;
        m = m + 1;

    }
 
        if (m == 11)
        {
            i = 1;
            m = 1;
            tabb = tabb + 1;
        Console.WriteLine("\r");
        }
}

