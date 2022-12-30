public class RomanianAppleCare
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
    public RomanianAppleCare(string RomanianAppleCareInput, Receipt re)
    {
        if(RomanianAppleCareInput == "jo tak"){
        Text("Ved du hvad? Du var altid min yndlingskunde!");
        Console.WriteLine();
        re.AddItem("Romanian Apple Care + - Ja tak", 9999999999999999);
        }
        else if(RomanianAppleCareInput == "Jo tak")
        {
        Text("Ved du hvad? Du var altid min yndlingskunde!");
        Console.WriteLine();
        re.AddItem("Romanian Apple Care + - Ja tak", 9999999999999999);
        }
        else
        {
        Text("[Mihnea klør ansigt suspiciously] Selvfølgelig, jeg ønsker dig den bedste tid med din nye bil, intet problem der...");
        Console.WriteLine();
        re.AddItem("Romanian Apple Care + - Nej tak", 0);
        }
    }
}