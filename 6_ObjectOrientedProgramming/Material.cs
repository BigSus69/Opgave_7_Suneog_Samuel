public class Material
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
    public Material(string MaterialInput, Receipt re){

        //Kunne være int, men jeg gider ikke helt
        List<string> materials = new List<string>(6);
        materials.Add("Råddent træ");
        materials.Add("Titanium");
        materials.Add("Jern");
        materials.Add("Obamium");
        materials.Add("Corleonite");
        materials.Add("Amogusium");
        Console.WriteLine();
        Text("Dine materiale muligheder:");
        Console.WriteLine();
        Text("============================================================");
        Console.WriteLine();
        // Print original order
        foreach (string a in materials)
            Text(a + (" "));
        Console.WriteLine();
        string colorboi = Console.ReadLine();

        switch (colorboi)
        {

            case "Råddent træ":
                Text("Jeg er glad for at jeg ikke er den eneste der syntes at holdbarhed er overrated!");
                Console.WriteLine();
                re.AddItem("Materiale - Råddent træ", 1321322189503);
                break;

            case "Titanium":
                Text("Selvfølgelig vil du have titanium! Let, holdbart og et meget dyrt materiale... Dog, for dig min ven, så kan jeg give dig 10kr rabat!");
                Console.WriteLine();
                re.AddItem("Materiale - Titanium", 2596420);
                re.SubtractItem("Titanium rabat", 10);
                break;

            case "Jern":
                Text("Jern er nu et dejligt materiale! Fantastisk valg min ven!");
                Console.WriteLine();
                re.AddItem("Materiale - Jern", 23);
                break;

            case "Obamium":
                Text("Godt valg, dog er det ikke særlig nemt at forme, så jeg håber du bliver glad for din pyramideformede bil :)");
                Console.WriteLine();
                re.AddItem("Materiale - Obamium", 51518);
                break;

            case "Corleonite":
                Text("Det bedste materiale, da det involverer mord! Ligesom visse diamanter, dog havde vi ikke råd til at bestille flere bloddiamanter hjem sidste måned, så det er lidt trist.");
                Console.WriteLine();
                re.AddItem("Materiale - Corleonite", 4518126521);
                break;

            case "Amogusium":
                Text("Amogus.");
                Console.WriteLine();
                re.AddItem("Materiale - Amogusium", 7152155141552141);
                break;
    }
}
}