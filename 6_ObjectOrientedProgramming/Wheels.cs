public class Wheels
{
    private Receipt re;

    void Text(string text, int time = 50)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(time);
        }
    }
    public Wheels(string HjulInput, Receipt re){

        //Kunne være int, men jeg gider ikke helt
        List<string> wheels = new List<string>(5);
        wheels.Add("0");
        wheels.Add("1");
        wheels.Add("2");
        wheels.Add("3");
        Console.WriteLine();
        Text("Dine muligheder:");
        Console.WriteLine();
        Text("===============");
        Console.WriteLine();
        // Print original order
        foreach (string a in wheels)
            Text(a + (" "));
        Console.WriteLine();
        string colorboi = Console.ReadLine();

        switch (colorboi)
        {

            case "Gul":
                Text("Bruh, Cringe men okæ :sadge:");
                Console.WriteLine();
                HjulInput = "0";
                re.AddItem("Hjul - 0", 230582378563247987);
                break;

            case "Blå":
                Text("Damn! Jeg er også blå dabadeedabadej");
                Console.WriteLine();
                HjulInput = "1";
                re.AddItem("Hjul - 1", 2596420);
                break;

            case "Grøn":
                Text("Mmmmmmmmmmmmmmmmhhhhhhhhhh... Grøn, God Farve");
                Console.WriteLine();
                HjulInput = "2";
                re.AddItem("Hjul - 2", 69420);
                break;

            case "Pink":
                Text("Pink?!? Det er jo den mest mandlige farve min ven, passer godt til dine næsebor :thumbsup:");
                Console.WriteLine();
                HjulInput = "3";
                re.AddItem("Hjul - 3", 0.69420);
                break;
    }
}

    public Wheels(Receipt re)
    {
        this.re = re;
    }
}
