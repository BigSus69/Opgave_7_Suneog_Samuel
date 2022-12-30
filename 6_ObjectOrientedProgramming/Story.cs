class Story
{
    public int StoryProgression = 0;
    Receipt re;

    void Text(string text, int time = 1)
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
            Text("Nåh, normalt ville det være nu jeg ville spørge hvor mange døre du vil have, men det er min gud for doven til at spørge om så øhh....");
            Console.WriteLine();
            Text("Motorer amiright!?!");
            Console.WriteLine();
            Thread.Sleep(1000);
            Text(". ");
            Thread.Sleep(1000);
            Text(". ");
            Thread.Sleep(1000);
            Text(". ");
            Console.WriteLine();
            Text("Cool, jeg er ikke blevet slået ihjel af gud endnu! Det må betyde du skal have en motor! Vil du have en motor? (Plz sig ja..)");
            Console.WriteLine();

            string MotorInput = Console.ReadLine(); //red
            Motor motor = new Motor(MotorInput, re);
        }
    }

}