public class Pieces
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
    public Pieces(string PieceInput, Receipt re)
    {
        if(PieceInput == "flere"){
        Text("Selvfølgelig, du vil have en projektbil, det kan jeg da også godt forstå!");
        Console.WriteLine();
        re.AddItem("Stykke(r) - Flere", 320000);
        Text("Desuden, skulle du have en guide med?");
        Console.WriteLine();
        string GuideInput = Console.ReadLine();
            if(GuideInput == "jo tak")
            {
                Text("Okidoki!");
                Console.WriteLine();
                re.AddItem("Guide - jo tak", 25);
            }
            else
            {
                Text("Det tager jeg som et nej :sadge: Og da du nu har såret mine følelser vil det koste ekstra!");
                Console.WriteLine();
                re.AddItem("Guide - sårede følelser", 10250);
            }
        }
        else if (PieceInput == "et")
        {
        Text("Amen, det er nu også altid dejligt når tingene er samlet for en, og da vi nu ikke behøver splitte bilen ad igen, bliver det endda billigere for dig :)");
        Console.WriteLine();
        re.AddItem("Stykke(r) - Et", 2);
        }
        else
        {
            Text("Det svar der kan jeg altså ikke tage for noget, for denne unødvendige ulejlighed bliver du altså nødt til at betale ekstra.");
            Console.WriteLine();
            re.AddItem("Dårligt svar - ja", 69420);
        }
    }
}