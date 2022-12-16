class Story
{
    public int StoryProgression = 0;

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
        TellStory(1);
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
            Colors color1 = new Colors(input);
            TellStory(2);
        }
        else if (progression == 2)
        {
            Text("Mihnea spørger hvad for nogle hjul du vil have");
            Console.WriteLine();
            Text("(Du kan få lige hvad du vil have!)");

            string HjulInput = Console.ReadLine(); //red
            Wheels color1 = new Wheels(HjulInput);
        }
    }

}