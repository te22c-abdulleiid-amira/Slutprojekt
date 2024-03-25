using System;
using System.Drawing;
using System.IO;
using System.Media;

string choice = "playerName";

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
Typewriter("Det blev tyst. Alla i rummet såg lika förvirrade ut.");
Typewriter("Då kom rösten tillbaka.");
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
  Red("Du röstade på \"Leva\"");
  Typewriter("Det blev tyst.");
  Typewriter("Alla visste att det var en 50% chans att de tog rätt dörr, men om rösterna blev 50/50, vad skulle hända då?");
  Typewriter("Sedan så hördes det:");
  Typewriter("\"Fem har röstat på.\"");
  Typewriter("\"Döda.\"");
  Typewriter("\"Sex av er har röstat.\"");
  Typewriter("\"Leva.\"");
  Typewriter("\"Vänligen gå till dörren ni röstat på.\"");
  Typewriter("Det tar inte lång tid för alla att ha samlat sig i rummet med dörren \"Leva\". När alla väll var inne- tog det inte lång tid för dörren att kraftigt stängas.");
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
  Typewriter("Du röstade på \"Döda\"");
  Typewriter("Alla visste att det var en 50% chans att de tog rätt dörr, men om rösterna blev 50/50, vad skulle hända då?");
  Typewriter("Sedan så hördes det:");
  Typewriter("\"Fem har röstat på.\"");
  Typewriter("\"Leva\"");
  Typewriter("\"Sex av er har röstat på.\"");
  Typewriter("\"Döda.\"");
  Typewriter("\"Vänligen gå till dörren ni röstat på.\"");
  Typewriter("Det tar inte lång tid för alla att ha samlat sig i rummet med dörren \"Döda\". När alla väll var inne- tog det inte lång tid för dörren att kraftigt stängas.");
  Green("\"Ni valde rätt dörr. Nu börjar nästa nivå.\"");

  Console.WriteLine("hjälper du henne?");

  choice = Console.ReadLine();
  choice = choice.ToLower();


  // Andra valen
  if (choice == "flight")
  {
    Console.Clear();
    Typewriter("7");
    Långsam("...");
    Console.WriteLine("en efter en puttar du av hennes fingrar från fönsteret, tills hon hänger kvar på sitt lilfinger.");
    Console.WriteLine("när du väll puttat av alla hennes fingrar så hör du hennes röst försvinna ner mot marken tills du hör ett plask");
    Console.WriteLine("nu när hon var borta så kan du see utsikten som gömde sig bakom henne.");
    Console.WriteLine("allt du såg var något som såg ut som en stad, men nu var den förstörd.");
    Console.WriteLine("det du nu tittar på är din förstörda stad.");
    Console.WriteLine("din värld");
    Console.WriteLine("ditt hem");
    Console.WriteLine("ditt mästerverk");
  }

  else if (choice == "fight")
  {
    Console.Clear();
    Typewriter("3");
    Långsam("...");
    Typewriter("Du bestämmer er för att slås tillbaka.");
    int p1Hp = 127;
    int p2Hp = 127;

    string p1Name = "player 1";
    string p2Name = "player 2";

    Random generator = new Random();

    // Här börjar man slås
    while (p1Hp > 0 && p2Hp > 0)
    {
      Console.WriteLine("!! FIGHT !!");
      Console.WriteLine($"{p1Name}: {p1Hp}  {p2Name}: {p2Hp}\n");

      int heroDamage = generator.Next(20);
      p2Hp -= heroDamage;
      p2Hp = Math.Max(0, p2Hp);
      Console.WriteLine($"{p1Name} throws shade at {p2Name} minus {heroDamage} braincells");

      int villainDamage = generator.Next(20);
      p1Hp -= villainDamage;
      p1Hp = Math.Max(0, p1Hp);
      Console.WriteLine($"{p2Name} DRAGGS {p1Name} minus {p1Name} hairstrands");

      Console.WriteLine("slå keyboarden för att fortsätta");
      Console.ReadLine();
    }

    Console.WriteLine("!! FREEZE !!");
    Console.WriteLine("Resultatet är...");

    if (p1Hp == 0 && p2Hp == 0)
    {
      Console.WriteLine("a tie?");
    }
    else if (p1Hp == 0)
    {
      Console.WriteLine($"{p2Name} wins total drama island!");
    }
    else
    {
      Console.WriteLine($"{p1Name} is this seasons winner of rupauls drag race!");
    }

    Console.WriteLine("Ni har besegrat monstret");
    Console.ReadKey();


  }
  else
  {
    Console.WriteLine("skriv tydligt idiot");
  }
}
else
{
  Console.WriteLine("du dog för att du inte kunde stava");
}

Console.WriteLine("tryck ENTER för att avsluta");
Console.ReadLine();

// Sista nivån på spelet blir att lösa den hemliga koden.
string name = Console.ReadLine().ToLower();
if (name == "11037")
{
  Console.Clear();
  Långsam("...");
  Green("Korrekt.");
}
else
{
  Console.Clear();
  Långsam("...");
  Red("Fel kod.");
}


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

static void Långsam(string test)
{
  foreach (char c in test)
  {
    Console.Write(c);
    Thread.Sleep(500);
  }
  Console.ReadLine();
}

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



static void SavePlayerName(string playerName)
{
  string fileName = "playerName.txt"; // namn på filen som ska spara spelarens namn
  File.WriteAllText(@"playerName.txt", "Banana");

}