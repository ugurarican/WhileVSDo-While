// While Kullanımı
    void While()
{
    Console.WriteLine("Kaç defa While ile yazdırmak istiyorun?");
    int sayac = 1;
    int input = 0;
    input = int.Parse(Console.ReadLine());
    while (sayac <= input)
    {
        Console.WriteLine("Ben bir Patika'lıyım.");
        sayac++;
    }
}
   // Do-While Kullanımı
   void DoWhile()
{
    Console.WriteLine("Kaç defa Do-While yazdırmak istiyorsun?");
    int sayac = 1;
    int input = 0;
    input = int.Parse(Console.ReadLine());
    
    do
    {
        Console.WriteLine("Ben bir Patika'lıyım.");
        sayac++;
    } while (sayac <= input);
    }
Console.WriteLine("1-> While çalışır.");
Console.WriteLine("2-> Do-While çalışır.");
string chose = Console.ReadLine();

if (chose == "1")
{
    While();
}
else if (chose == "2")
{
    DoWhile();
}
else
    Console.WriteLine("Yanlış seçim.");