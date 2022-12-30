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
        Text("FÆNOMENALT! Dine muligheder:");
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

            case "0":
                Text("Øhhhhhhhhhhhhhhhhhh... Nårh jo, du har vel hjul derhjemme... Ikke sandt? Eller, ved du hvad det er dit privatliv, du må gøre som du vil! :smile:");
                Console.WriteLine();
                HjulInput = "0";
                re.AddItem("Hjul - 0", 230582378563247987);
                break;

            case "1":
                Text("Uha, du er da vel nok moderne! Selvfølgelig koster fremskridt altid lidt ekstra, men det har du vel råd til!");
                Console.WriteLine();
                HjulInput = "1";
                re.AddItem("Hjul - 1", 2596420);
                break;

            case "2":
                Text("Cykelbiler har altid været interessante for mig, jeg er glad for at jeg ikke er den eneste!");
                Console.WriteLine();
                HjulInput = "2";
                re.AddItem("Hjul - 2", 69420);
                break;

            case "3":
                Text("Jeg har hørt trehjulede biler skulle være mere stabile end firhjulede, så det er da vel nok dejligt at andre støtter det større billede!");
                Console.WriteLine();
                HjulInput = "3";
                re.AddItem("Hjul - 3", 0.69420);
                break;
    }
}
}
