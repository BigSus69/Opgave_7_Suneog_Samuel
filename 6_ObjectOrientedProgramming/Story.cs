class Story
{
    public int StoryProgression = 0;
    Receipt re;

    void Text(string text, int time = 50)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(time);
        }
    }
    public Story()
    {
        re = new Receipt();
        TellStory(1);
        re.Print();
    }

    public void TellStory(int progression){
        if (progression == 1)
        {
            Text("Du kommer ind i Mihneas dealership");
            Console.WriteLine();
            Text("Du ser hans mange lovligt anskaffede biler og bildele");
            Console.WriteLine();
            Text("Mihnea spørger om du er interesseret i en bil");
            Console.WriteLine();
            Text("Han antager at du gerne vil og fortsætter uden dit svar");
            Console.WriteLine();
            Text("Mihnea sætter dig ned ved det store bord og spørger om du vil have en farvet bil");
            Console.WriteLine();
            string input = Console.ReadLine(); //red
            Colors color1 = new Colors(input, re);
            TellStory(2);
        }
        else if (progression == 2)
        {
            //Dette skal ændres til noget der hentyder til at du får valgmuligheder om lidt
            Text("Mihnea spørger om du er interesseret i det nymoderne fænomen ved navn 'Hjul'?");
            Console.WriteLine();

            string HjulInput = Console.ReadLine(); //red
            Wheels wheels = new Wheels(HjulInput, re);
            TellStory(3);
        }
        else if (progression == 3)
        {
            Text("Nåh, normalt ville det være nu jeg ville spørge hvor mange dører du vil have, men det er min gud for doven til at spørge om så øhh....");
            Console.WriteLine();
            Text("Motorer amiright!?!");
            Console.WriteLine();
            Text(". ");
            Thread.Sleep(2000);
            Text(". ");
            Thread.Sleep(2000);
            Text(". ");
            Console.WriteLine();
            Text("Cool, jeg er ikke blevet slået ihjel af gud endnu! Det må betyde du skal have en motor! Vil du have en motor? (Plz sig ja..)");
            Console.WriteLine();

            string MotorInput = Console.ReadLine(); //red
            Motor motor = new Motor(MotorInput, re);
            TellStory(4);
        }
        else if (progression == 4)
        {
            Text("Nu kommer vi til en af de svære spørgsmål der ofte tager noget tid at tænke over...");
            Thread.Sleep(5000);
            Console.WriteLine();
            Text("Udstødning eller ej? (Det er markant billigere uden)");
            Console.WriteLine();
            string ExhaustInput = Console.ReadLine();
            Exhaust exhaust = new Exhaust(ExhaustInput, re);
            TellStory(5);
        }
        else if (progression == 5)
        {
            Text("Skulle bilen helst være i et stykke eller flere stykker?");
            Console.WriteLine();
            string PieceInput = Console.ReadLine();
            Pieces pieces = new Pieces(PieceInput, re);
            TellStory(6);
        }
        else if (progression == 6)
        {
            Text("I denne moderne verden har der været store debatter om sådan noget som genbrugelige materialer!");
            Console.WriteLine();
            Text("Derfor er det blevet obligatorisk for os bilsælgere at spørge om du helst vil støtte genbrug eller ej! Så hvad støtter du?");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();
            Text("Tak for svaret! Jeg er faktisk 100% ligeglad med dit svar, da vi her ved Mihneas dealership TM har sørget for at alle vores materialer er lige ugenbrugelige!");
            Console.WriteLine();
            string MaterialInput = Console.ReadLine();
            Material material = new Material(MaterialInput, re);
            TellStory(7);
        }
        else if (progression == 7)
        {
            Text("Desuden, kunne du være interesseret i at konvertere din bil til elektrisk?");
            Console.WriteLine();
            Console.ReadLine();
            Text("Hvad siger du? for jeg syntes det lyder som om du vil have MERE GAS???");
            re.AddItem("Gas - MERE GAS!", 1001);
            Console.WriteLine();
            Text("Se det er noget jeg kan forstå!");
            Console.WriteLine();
            Text("Nåh, det her vil måske lyde lidt trist efter alt det vi har været igennem...");
            Console.WriteLine();
            Text("Men vi er faktisk ved at nå slutningen af dit bilkøb :pensive:");
            Console.WriteLine();
            Text("Der er dog en ting tilbage før jeg kan lade dig gå!");
            Console.WriteLine();
            Text("Kunne du være interesseret i Romanian Apple Care+ ???");
            Console.WriteLine();
            Text("Det er kun et lille bitte månedligt abonnement der vil stoppe dig fra at miste din bil sekundet du forlader vores dealership!");
            Console.WriteLine();
            Text("Ud over det vil vi også prøve at fikse din bil hvis der nogensinde skulle ske et lille uheld!!!");
            Console.WriteLine();
            Text("Så hvad siger du? 'jo tak' eller 'nej tak'?");
            Console.WriteLine();
            string RomanianAppleCareInput = Console.ReadLine();
            RomanianAppleCare romanianAppleCare = new RomanianAppleCare(RomanianAppleCareInput, re);
        }
    }

}