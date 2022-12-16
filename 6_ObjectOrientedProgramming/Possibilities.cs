class Colors
{

    public string Farve = "Ingen farve";
    void Text(string text, int time = 50)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(time);
        }
    }
    public Colors(string colorChoice)
    {
        List<string> colors = new List<string>(5);
        colors.Add("Pink");
        colors.Add("Grøn");
        colors.Add("Blå");
        colors.Add("Gul");
        Console.WriteLine();
        Text("Heldige dig! Vi har nemlig mange farver til rådighed");
        Console.WriteLine();
        Text("Dine muligheder:");
        Console.WriteLine();
        Text("===============");
        Console.WriteLine();
        // Print original order
        foreach (string a in colors)
            Text(a + (" "));
        Console.WriteLine();
        string colorboi = Console.ReadLine();

        switch (colorboi)
        {

            case "Gul":
                Text("Bruh, Cringe men okæ :sadge:");
                Console.WriteLine();
                Farve = "Gul";
                break;

            case "Blå":
                Text("Damn! Jeg er også blå dabadeedabadej");
                Console.WriteLine();
                Farve = "Blå";
                break;

            case "Grøn":
                Text("Mmmmmmmmmmmmmmmmhhhhhhhhhh... Grøn, God Farve");
                Console.WriteLine();
                Farve = "Grøn";
                break;

            case "Pink":
                Text("Pink?!? Det er jo den mest mandlige farve min ven, passer godt til dine næsebor :thumbsup:");
                Console.WriteLine();
                Farve = "Pink";
                break;
        }
    }


}

class Wheels
{
    public Wheels(string HjulInput){
        string hjulGoBrr = Console.ReadLine();
        
    }
}