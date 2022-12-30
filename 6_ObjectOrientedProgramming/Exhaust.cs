public class Exhaust
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
    public Exhaust(string ExhaustInput, Receipt re)
    {
        if(ExhaustInput == "Udstødning"){
        Text("Cool... ");
        Thread.Sleep(5000);
        Text("Måske lige lovligt priviligeret, men det er vel dit valg at du vil flexe på alle andre.");
        Console.WriteLine();
        re.AddItem("Udstødning - Ja tak", 15000);
        }
        else
        {
        Text("Okidoki, ingen udstødning til dig min ven, måske lidt farligt ikke, men måske er du en fan af udstødning i lungerne lige som jeg [Episk fistbump]");
        Console.WriteLine();
        re.AddItem("Udstødning - Nej tak", 1000);
        }
    }
}