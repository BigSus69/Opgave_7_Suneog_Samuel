class Colors{

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
            break;

            case "Blå":
            Text("Damn! Jeg er også blå dabadeedabadej");
            break;
        }
    }
}
