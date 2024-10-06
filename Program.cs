//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
for (int i = 1; i < 11; i++) 
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

for (int i = 1; i < 21; i++)
{
    Console.WriteLine(i);
}

// 3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

for (int i = 1; i < 21; i ++)
{
    if (i %2 ==0)
    Console.WriteLine(i);
}

//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int toplam = 0;


for (int i = 1; i < 151; i ++)
{
    toplam += i;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);

//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int ciftToplam = 0;

for (int i = 1; i < 121; i++)
{
    if (i % 2 == 0)
     Console.WriteLine(i);
    ciftToplam += i;
}

Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamları: " + ciftToplam);

int tekToplam = 0;

for (int i = 1; i < 121; i++)
{
    if (i % 2 != 0)
        Console.WriteLine(i);
    tekToplam += i;
}

Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamları: " + tekToplam);