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
            Text("Mihnea spørger hvor mange hjul du vil have");
            Console.WriteLine();

            string HjulInput = Console.ReadLine(); //red
            Wheels wheels = new Wheels(HjulInput, re);
        }
    }

}