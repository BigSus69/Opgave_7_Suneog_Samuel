class Colors{

public int Farve = 0;
    void Text(string text, int time = 50) 
    { 
        foreach (char c in text)
         { 
            Console.Write(c); 
            Thread.Sleep(time); 
            } 
        }
    public Colors(){
        List<string> colors = new List<string>(5);
        colors.Add("Pink");
        colors.Add("Grøn");
        colors.Add("Blå");
        colors.Add("Gul");
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

        switch(colorboi){

            case "Gul":
            Text("Bruh, Cringe men okæ :sadge:");
            Farve = 1;
            break;

            case "Blå":
            Text("Damn! Jeg er også blå dabadeedabadej");
            Farve = 2;
            break;

            case "Grøn":
            Text("Mmmmmmmmmmmmmmmmhhhhhhhhhh... Grøn, God Farve");
            Farve = 3;
            break;

            case "Pink":
            Text("Pink?!? Det er jo den mest mandlige farve min ven, passer godt til dine næsebor :thumbsup:");
            Farve = 4;
            break;
        }
    }
}
