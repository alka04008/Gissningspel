Random rng = new Random ();
int tal = rng.Next(1,101);
Console.WriteLine("Programmet har generat ett slumpmässigt tal mellan 1-100, kan du gissa vilket det är?");
int i = 0;
for (int f=1;i!=tal;f++)
{
i = Convert.ToInt32(Console.ReadLine());
if(i < tal)
    Console.WriteLine("Ditt tal är mindre än programmets tal, ta och försök igen.");
else if (i > tal)
    Console.WriteLine("Ditt tal är större än proggrammets tal, ta och försök igen.");
    else if (f==1)
    Console.WriteLine("Woow du gissade rätt på ditt första försök, bra jobbat");
else
    Console.WriteLine("Grattis din gissning på "+ tal + " är rätt,men du behövde gissa " + f + " gånger,kan du gissa bättre nästa gång?");
}