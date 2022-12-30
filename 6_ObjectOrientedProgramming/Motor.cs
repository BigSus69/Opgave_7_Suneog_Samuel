public class Motor
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
    public Motor(string MotorInput, Receipt re){

        //Kunne være int, men jeg gider ikke helt
        List<string> motors = new List<string>(17);
        motors.Add("V0");
        motors.Add("V1");
        motors.Add("V2");
        motors.Add("V3");
        motors.Add("V4");
        motors.Add("V5");
        motors.Add("V6");
        motors.Add("V7");
        motors.Add("V8");
        motors.Add("V9");
        motors.Add("V10");
        motors.Add("V11");
        motors.Add("V12");
        motors.Add("V13");
        motors.Add("V14");
        motors.Add("V15");
        motors.Add("V16");
        motors.Add("Et småt barn fra mellemamerika");
        Console.WriteLine();
        Text("Tusind Tak! Dine muligheder:");
        Console.WriteLine();
        Text("===========================================================================");
        Console.WriteLine();
        // Print original order
        foreach (string a in motors)
            Text(a + (" "));
        Console.WriteLine();
        string colorboi = Console.ReadLine();

        switch (colorboi)
        {

            case "V0":
                Text("'0 hestekræfter = 0 kroner' som min morfar altid plejede at sige, selvfølgelig har tiderne ændret sig siden 200 år f.Kr. Så nu koster motoren 2 kr, med en daglig subscription på 35.000kr men udover det er den stadig meget økonomisk!");
                Console.WriteLine();
                MotorInput = "V0";
                re.AddItem("Motor - V0", 2);
                break;

            case "V1":
                Text("Den eneste motor med sædevarme inkluderet! Godt valg!");
                Console.WriteLine();
                MotorInput = "V1";
                re.AddItem("Hjul - V1", 4);
                break;

            case "V2":
                Text("En motor så simpel at den blev lavet af en Guldfisk ved navn Klaus! Bedste balg til en DIY entusiast som dig!");
                Console.WriteLine();
                MotorInput = "V2";
                re.AddItem("Hjul - V2", 8);
                break;

            case "V3":
                Text("Ad... Eller jeg mener mmmmhhhhh er lyden denne motor vil lave når den rister dit brød for dig mens du stadig puttesover!");
                Console.WriteLine();
                MotorInput = "V3";
                re.AddItem("Hjul - V3", 16);
                break;
            
            case "V4":
                Text("Bedre end en V3 værre end en V7, fantastisk valg!");
                Console.WriteLine();
                MotorInput = "V4";
                re.AddItem("Motor - V4", 32);
                break;
            
            case "V5":
                Text("Okay, mildt flex lige der min ven!");
                Console.WriteLine();
                MotorInput = "V5";
                re.AddItem("Motor - V5", 64);
                break;
            
            case "V6":
                Text("Se det her er faktisk en rigtig motor, og den kan endda være virkelig god! Det er den her ikke, men det er jo dit problem!");
                Console.WriteLine();
                MotorInput = "V6";
                re.AddItem("Motor - V6", 128);
                break;
            
            case "V7":
                Text("Den her må have været et misinput... Nøh faktisk ikke, håber du kan lide den :thumbsup:");
                Console.WriteLine();
                MotorInput = "V7";
                re.AddItem("Motor - V7", 256);
                break;
            
            case "V8":
                Text("I modsætning til V6'eren er den her faktisk god, godt valg!");
                Console.WriteLine();
                MotorInput = "V8";
                re.AddItem("Motor - V8", 512);
                break;
            
            case "V9":
                Text("V9'eren er bare en V4 og en V5 sat sammen, det må du dog ikke sige til nogen da det vil få mig i større problemer med den grønlandske mafia så Shhhhhh...");
                Console.WriteLine();
                MotorInput = "V9";
                re.AddItem("Motor - V9", 1024);
                break;
            
            case "V10":
                Text("Du er den første person der overhovedet har kigget på den her motor! Forfærdeligt valg!");
                Console.WriteLine();
                MotorInput = "V10";
                re.AddItem("Motor - V10", 2048);
                break;
            
            case "V11":
                Text("Den bryder sammen dagligt, men med Romanian Apple Care+ er det ikke et problem, så det må vi jo se på senere!");
                Console.WriteLine();
                MotorInput = "V11";
                re.AddItem("Motor - V11", 4096);
                break;

            case "V12":
                Text("Lad mig lige revve den... [Motor lyde] [Hentai_moaning_sound.mp3 plays] undskyld, men den motorlyd går lige ned i juleklokkerne. Den har du bare at blive glad for!");
                Console.WriteLine();
                MotorInput = "V12";
                re.AddItem("Motor - V12", 8192);
                break;
            
            case "V13":
                Text("Kinda cringe ngl, men du vil sikkert nyde den!");
                Console.WriteLine();
                MotorInput = "V13";
                re.AddItem("Motor - V13", 16384);
                break;
            
            case "V14":
                Text("Den rammer også lige i julekuglerne, men det er hovedsageligt pga. AK47'eren der er fastgjort på den!");
                Console.WriteLine();
                MotorInput = "V14";
                re.AddItem("Motor - V14", 32768);
                break;
            
            case "V15":
                Text("Selvfølgelig vil du have den her motor :nerd:");
                Console.WriteLine();
                MotorInput = "V15";
                re.AddItem("Motor - V15", 65356);
                break;
            
            case "V16":
                Text("Et øje for performance kan jeg se! det kan godt være det bare er en lang række V2'ere der er sat sammen, men denne motor kan snildt køre hurtigere end en eksploderet Ford Focus");
                Console.WriteLine();
                MotorInput = "V16";
                re.AddItem("Motor - V16", 131072);
                break;

            case "Et småt barn fra mellemamerika":
                Text("Ahhh, jeg kan se at du er typen der kan finde en god deal når du ser den! Det kan jo sagtens være barnet koster lidt at anskaffe, men modsat en typisk dieselbil kan den her klarer sig 300 km per rugbrødsmad, og hvis han ikke længere kan det skal du bare sige til, så kan du få en erstatning!");
                Console.WriteLine();
                MotorInput = "Et småt barn fra mellemamerika";
                re.AddItem("Motor - Et småt barn fra mellemamerika", 3000000);
                break;
    }
}
}
