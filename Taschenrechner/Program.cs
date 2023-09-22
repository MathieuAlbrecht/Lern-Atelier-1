// See https://aka.ms/new-console-template for more information

bool MI = true;

while (MI == true)

{
    Console.WriteLine("Gib deine erste Zahl ein");
    String e1 = Console.ReadLine();
    double Zahl1 = Convert.ToDouble(e1);
    

    Console.WriteLine("Welche Operation möchtest du benutzen(+,-,*,/)?");
    String Operation = Console.ReadLine();

    Console.WriteLine("Gib eine zweite Zahl ein");
    string e2 = Console.ReadLine();
    double Zahl2 = Convert.ToDouble(e2);


    if (Operation == "+")
    {
        Console.WriteLine(Zahl1 + Zahl2);
    }
    else if (Operation == "-")
    {
        Console.WriteLine(Zahl1 - Zahl2);
    }
    else if (Operation == "*")
    {
        Console.WriteLine(Zahl1 * Zahl2);
    }
    else if (Operation == "/")
    {
        Console.WriteLine(Zahl1 / Zahl2);
    }
    MI = false;
    Console.WriteLine("Neue Rechnung?");
    string e3 = Console.ReadLine();
    if (e3 == "ja" || e3 == "Ja" || e3 == "JA")
    {
        MI = true;
    }
    else
    {
        MI = false;
    }
}