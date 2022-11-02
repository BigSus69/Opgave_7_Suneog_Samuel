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
    Text("");
    }
    
}