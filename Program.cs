using System;
using System.Drawing;
using System.IO;
using System.Media;

// Spara spelarens namn
string choice = "playerName"; // Utför operationer baserat på valet
Typewriter("Vad heter du?");
string playerName = Console.ReadLine();
SavePlayerName(playerName);
Typewriter($"Välkomen, {playerName}. Vet du vad majoritetsröstning är?");

// Spelets start
Console.Clear();
Typewriter("1");
Långsam("...");
Typewriter("\"Var det den sista?\" ");
Typewriter("\"Jag tror det.\"");
Typewriter("Du vaknar i ett rum med tio andra personer du aldrig sett förut.");
Typewriter("Alla de andra i rummet skiljdes åt kraftigt i utseende och ålder. Det gick från pensionärer till barn.");
Typewriter("Å andra sidan så var det inget märkvärdigt med rummet, vit och liten.");
Typewriter("Men, rummet hade två dörrar framför sig.");
Typewriter("På ena dörren så stod det \"Leva\", och på den andra så stodd det \"Döda\".");
Typewriter("Då så hördes det.");
Typewriter("\"Välkomen, ni alla har tur att få vara experimenten i vårat projekt. Jag ska hålla detta kort så lyssna på mina instruk-tioner noga.\"");
Typewriter("\"Framför er finns det två dörrar. En av dörrarna tar er in på nästa nivå, andra gör inte det. Och med majoritet röstning, så röstar ni tillsammans vilken dörr ni bör ta.\"");
Red("\"Men kom ihåg. En av dörrarna ljuger.\"");
Typewriter("Alla får sin egen surfplatta som ger röstpanelen.");
Typewriter("Vilken dörr väljer du?");

choice = Console.ReadLine();
choice = choice.ToLower();


// Första valen
if (choice == "Leva" || choice == "leva")
{
  Console.Clear();
  Typewriter("1");
  Långsam("...");
  Red("Du röstade på \"Leva\".");
  Typewriter("Det blev tyst.");
  Typewriter("Sedan så hördes det:");
  Typewriter("\"Fem har röstat på.\"");
  Typewriter("\"Döda.\"");
  Typewriter("\"Sex av er har röstat.\"");
  Typewriter("\"Leva.\"");
  Typewriter("\"Vänligen gå till dörren ni röstat på.\"");
  Typewriter("Det tar inte lång tid för alla att ha samlat sig i rummet med dörren \"Leva\". När alla väll var inne tog det inte lång tid för dörren att kraftigt stängas.");
  Typewriter("Luften blev varmare, och snabbt blev det svårt att stå på golvet.");
  Red("\"Ni valde fel dör, straffet börjar nu.\"");
  Typewriter("En efter en, så sprang alla till dörren. För att vara helt ärlig så är det exact vad du också gjorde.");
  Typewriter("Men ingenting fungerade. Det blev varmare, sedan sp blev allt svart.");
  Red("Du dog");
  Console.Clear();

  Typewriter("Vill du försöka igen?");
}
else if (choice == "Döda" || choice == "döda")
{
  Console.Clear();
  Typewriter("0");
  Långsam("...");
  Typewriter("Du röstade på \"Döda\".");
  Typewriter("Sedan så hördes det:");
  Typewriter("\"Fem har röstat på.\"");
  Typewriter("\"Leva\"");
  Typewriter("\"Sex av er har röstat på.\"");
  Typewriter("\"Döda.\"");
  Typewriter("\"Vänligen gå till dörren ni röstat på.\"");
  Typewriter("Det tar inte lång tid för alla att ha samlat sig i rummet med dörren \"Döda\". När alla väll var inne tog det inte lång tid för dörren att kraftigt stängas.");
  Green("\"Ni valde rätt dörr. Nu börjar nästa nivå.\"");
  Console.Clear();
  Långsam("...");
  Typewriter("Ni befinner er i en arena. Arenan är fyld med oöppnade lådor. Dessutom så märkte du elva stycken fyrkanter på marken som stod på rad.");
  Typewriter("\"Kongratulerar, ni klarade uppvärmningen. Var vänligen och ställ er på varsin fyrkant.\"");
  Typewriter("SKRIV FLIGHT");

  choice = Console.ReadLine();
  choice = choice.ToLower();


  // Andra valen
  if (choice == "flight" || choice == "Flight")
  {
    Console.Clear();
    Typewriter("7");
    Långsam("...");
    Typewriter("Du röstade på \"Flight\".");
  }

  else if (choice == "fight")
  {
    Console.Clear();
    Typewriter("3");
    Långsam("...");
    Typewriter("Du bestämmer er för att slås tillbaka.");
    Typewriter("Det är nu eller aldrig.");
    
    int p1Hp = 127;
    int p2Hp = 100;
    string p1Name = $"{playerName}";
    string p2Name = "Doppelganger";

    Random generator = new Random();

    // Här börjar man slås
    while (p1Hp > 0 && p2Hp > 0)
    {
      Typewriter($"{p1Name}: {p1Hp}  {p2Name}: {p2Hp}\n");

      int heroDamage = generator.Next(50);
      p2Hp -= heroDamage;
      p2Hp = Math.Max(0, p2Hp);
      Typewriter($"{p1Name} throws shade at {p2Name} minus {heroDamage} braincells");

      int villainDamage = generator.Next(50);
      p1Hp -= villainDamage;
      p1Hp = Math.Max(0, p1Hp);
      Typewriter($"{p2Name} DRAGGS {p1Name} minus {p1Name} hairstrands");
      Console.ReadLine();
    }

    Console.WriteLine("Nu var tiden ute.");
    Console.WriteLine("Resultatet är...");
    if (p1Hp == 0 && p2Hp == 0)
    {
      Långsam("...");
      Typewriter("Ni båda hade förlorat för mycket blod för att fortsätta och långsamt dog.");
      Typewriter("Oavgjort.");
    }
    else if (p1Hp == 0)
    {
      Långsam("...");
      Red($"{p2Name} har vunnit.");
    }
    else
    {
      Långsam("...");
      Green($"{p1Name} har vunnit.");

    // Sista nivån på spelet blir att lösa den hemliga koden.
    string name = Console.ReadLine().ToLower();
      if (name == "11037")
        {
          Console.Clear();
          Långsam("...");
          Green("Korrekt.");
          Typewriter("Du är fri att gå om.");
          Typewriter("3");
          Typewriter("2");
          Red("1");
          Console.Clear();
        }
      else
        {
         Console.Clear();
         Långsam("...");
         Red("Fel kod.");
         Typewriter("");
         Typewriter("Om du inte listade ut koden så är den \"11037\".");
        }
    }
  }

  else
  {
    Console.WriteLine("skriv tydligt idiot");
  }
}
Console.WriteLine("tryck ENTER för att avsluta");
Console.ReadLine();



// Använder mig av metoden DRY (Don't repeat yourself) för att förkorta koden med hjälp av loopar.
static void Typewriter(string test)
{
  foreach (char c in test)
  {
    Console.Write(c);
    Thread.Sleep(50);
  }
  Console.ReadLine();
}

// Långam text
static void Långsam(string test)
{
  foreach (char c in test)
  {
    Console.Write(c);
    Thread.Sleep(500);
  }
  Console.ReadLine();
}

// Röd text
static void Red(string test) 
    { 
      ConsoleColor orig = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkRed; 
        foreach (char c in test)
  {
    Console.Write(c);
    Thread.Sleep(50);
  }
  Console.ForegroundColor = orig;
  Console.ReadLine();
  } 

// Grön text
static void Green(string test) 
    { 
      ConsoleColor orig = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green; 
        foreach (char c in test)
  {
    Console.Write(c);
    Thread.Sleep(50);
  }
  Console.ForegroundColor = orig;
  Console.ReadLine();
  } 

// Spara spelarens namn
static void SavePlayerName(string playerName)
{
  string fileName = "playerName.txt"; // namn på filen som ska spara spelarens namn
  File.WriteAllText(@"playerName.txt", "wowow");

}