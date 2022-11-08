class Story{

    void Text(string text, int time = 50) 
    { 
        foreach (char c in text)
         { 
            Console.Write(c); 
            Thread.Sleep(time); 
            } 
        }
    public Story(){
    
    Text("Du kommer ind i Mihneas dealership");
    Console.WriteLine();
    Text("Du ser hans mange lovligt anskaffede biler og bildele");
    Console.WriteLine();
    Text("Mihnea spørger om du er interesseret i en bil");
    Console.WriteLine();
    Text("Mihnea sætter dig ned ved det store bord og spørger hvad for en farve bil du vil have");
    Console.WriteLine();
    Colors color1 = new Colors();
    }
    
    //EEEEEEE
}