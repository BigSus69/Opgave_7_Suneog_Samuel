public class PostStory
{

    void Text(string text, int time = 50)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(time);
        }
    }

    public PostStory()
    {
        Text("Nåh hvad siger du så? god pris ikke sandt? Jo Selvfølgelig!");
        Console.WriteLine();
        Text("Nåh men før du lige går bliver jeg altså nødt til at spørge dig om du kunne være interesseret i at sælge din bil tilbage til mig?");
        Console.WriteLine();
        Text("Det kan godt være det lyder som et lidt sært spørgsmål at stille nu hvor du lige har købt bilen, men det er bare et kriterie der skal opnåes du ved");
        Console.WriteLine();
        Text("Så hvad siger du? Vil du sælge bilen?");
        Console.WriteLine();
        string sidsteSpørgsmål = Console.ReadLine();

        if(sidsteSpørgsmål == "ja")
        {
            Text("HVAD?");
            Console.WriteLine();
            Text("Jamen okay så");
            Console.WriteLine();
            Text("Nu har du solgt din bil tilbage til os :D");
            Console.WriteLine();
            Text("Du skal selvfølgelig stadig betale kvitteringen, du spare bare de 2kr vi gav dig for bilen!");
            Console.WriteLine();
            Text("Det kan selvfølgelig sagtens være du syntes det er et lidt drastisk prisfald, men det er jo bare pga. sådan noget som:");
            Console.WriteLine();
            Text("Inflation, deflation, susflation, Rema 1000's overdrevne remoulade priser, Heinz Ketchup priser peaked for nyligt, Romanian Apple Care -, den store mængde drugs i min kæ-");
            Environment.Exit(0);
        }
        else
        {
            Text("Jamen, så tænker jeg vel det var en god handel for os begge!");
            Console.WriteLine();
            Text("Vi ses jo nok engang, hej hej!");
        }
    }

}