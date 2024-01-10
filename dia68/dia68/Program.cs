static void yhteenlasku(int a, int b)
{
    int summa = a + b;
    Console.WriteLine("Lukujen {0} ja {1} summa on {2}", a, b, summa);
}
yhteenlasku(3, 5);
static void fahrenheit(int a)
{
    double fah = a * 1.8 + 32;
    Console.WriteLine("Celsiusaste {0} on Fahrenheiteita {1}", a, fah);
}
fahrenheit(10);
static void peruslaskutoimitukset(int a, int b)
{
    int summa, erotus, tulo;
    double osamaara;
    summa= a + b;
    erotus = a - b;
    tulo = a * b;
    osamaara = (double)a / b;
    Console.WriteLine("Lukujen {0} ja {1} \nsumma on {2}\nerotus on {3}\ntulo on {4} \nosamaara on {5}", a, b, summa, erotus, tulo, osamaara);
}
peruslaskutoimitukset(8, 5);
static void jakoj(int a, int b)
{
    int jakojaannos = a % b;
    Console.WriteLine("Lukujen {0} ja {1} jakojäännös on {2}", a, b, jakojaannos);
}
jakoj(5, 2);
static void tervehdys()
{
    Console.Write("Anna etunimesi: ");
    string etunimi = Console.ReadLine();
    Console.WriteLine("Hei {0}", etunimi);
}
tervehdys();
static void yhteenlasku2()
{
    Console.Write("Anna yhteenlaskun 1. numero: ");
    int eka = int.Parse(Console.ReadLine());
    Console.Write("Anna yhteenlaskun 2. numero: ");
    int toka = int.Parse(Console.ReadLine());
    int summa = eka + toka;
    Console.WriteLine("Lukujen {0} ja {1} summa on {2}", eka, toka, summa);
}
yhteenlasku2();
static void fahrenheit2()
{
    Console.Write("Anna Celsiusarvo: ");
    double cel = double.Parse(Console.ReadLine());
    double fah = cel * 1.8 + 32;
    Console.WriteLine("{0} Celsiusastetta on {1} Fahrenheit astetta", cel, fah);
}
fahrenheit2();
static void peruslaskutoimitukset2()
{
    Console.Write("Anna 1. luku: ");
    int l1 = int.Parse(Console.ReadLine());
    Console.Write("Anna 2. luku: ");
    int l2 = int.Parse(Console.ReadLine());
    int summa, erotus, tulo;
    double osamaara;
    summa = l1 + l2;
    erotus = l1 - l2;
    tulo = l1 * l2;
    osamaara = (double)l1 / l2;
    Console.WriteLine("Lukujen {0} ja {1} \nsumma on {2}\nerotus on {3}\ntulo on {4} \nosamaara on {5}", l1, l2, summa, erotus, tulo, osamaara);
}
peruslaskutoimitukset2();
static void jakoj2()
{
    Console.Write("Anna jaettava: ");
    int jaettava = int.Parse(Console.ReadLine());
    Console.Write("Anna jakaja: ");
    int jakaja = int.Parse(Console.ReadLine());
    double jakojaannos = (double)jaettava % jakaja;
    Console.WriteLine("Lukujen {0} ja {1} jakojäännös on {2}", jaettava, jakaja, jakojaannos);
}
jakoj2();
static void kertotaulu()
{
    Console.Write("Anna kertotaulun perusluku: ");
    int luku = int.Parse(Console.ReadLine());
    for(int i = 1; i<=10; i++)
    {
        Console.WriteLine("{0} x {1} = {2}", luku, i, luku*i);
    }
}
kertotaulu();