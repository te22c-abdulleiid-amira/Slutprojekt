using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows;
using System.Threading;
using System.Runtime.InteropServices;




// Spara spelarens namn
string choice = "playerName"; // Utför operationer baserat på valet
Typewriter("Vad heter du?");
string playerName = Console.ReadLine();
SavePlayerName(playerName);
Typewriter($"Välkomen, {playerName}. Vet du vad majoritetsröstning är?");
Console.Clear();

// Kaptiel vall
Typewriter("Vill du hoppa till en annat kapitel eller köra spelet från början?");
Typewriter("Skriv Ja eller Nej.");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "ja" || choice == "Ja")
{
  Typewriter("Vilken kapitel vill du till?");
  Typewriter("Skriv 1 eller 2");
  choice = Console.ReadLine();
  choice = choice.ToLower();
}
else if (choice == "nej" || choice == "Nej")
{


  // Spelets start
  Console.Clear();
  Typewriter("1");
  Långsam("...");
  Typewriter("Du vaknar i ett rum med tio andra personer du aldrig sett förut.");
  Typewriter("Alla de andra i rummet skiljdes åt kraftigt i utseende och ålder.");
  Typewriter("Men, rummet hade två dörrar framför sig.");
  Typewriter("På ena dörren så stod det \"Leva\", och på den andra så stodd det \"Döda\".");
  Typewriter("\"Välkomen, ni alla har tur att få vara experimenten i vårat projekt. Jag ska hålla detta kort så lyssna på mina instruk-tioner noga.\"");
  Typewriter("\"Framför er finns det två dörrar. En av dörrarna tar er in på nästa nivå, andra gör inte det. Och med majoritet röstning, så röstar ni tillsammans vilken dörr ni bör ta.\"");
  Red("\"Men kom ihåg. En av dörrarna ljuger.\"");
  Typewriter("Alla får sin egen surfplatta som ger röstpanelen.");
  Typewriter("Vilken dörr väljer du?");
  choice = Console.ReadLine();
  choice = choice.ToLower();
}


// Första valen
if (choice == "Leva" || choice == "leva") // alternativen där med hjälp av "||" variablen kan jag lägga till flera alternativ som ger samma resultat
{
  Console.Clear(); //rensa texten från innan 
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
  Typewriter("Men ingenting fungerade. Det blev varmare, sedan så blev allt svart.");
  Död();
}
else if (choice == "Döda" || choice == "döda" || choice == "1")
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
  // Del 2
  Långsam("...");
  Typewriter("Ni befinner er i en arena. Arenan är fyld med oöppnade lådor. Dessutom så märkte du elva stycken fyrkanter på marken som stod på rad.");
  Typewriter("\"Kongratulerar, ni klarade uppvärmningen. Var vänligen och ställ er på varsin fyrkant.\"");
  Typewriter("Du och alla de andra går till varsin fyrkant.");
  Typewriter("Inte långt efter så börjar golvet att skaka.");
  Typewriter("Elva luckor på marken öppnas framför varje person i arenan och sedan så stack ett huvud ut på luckan framför dig.");
  Typewriter("Då såg du en otolig bekant person, en person du kände bäst, men såg mindre en andra.");
  Typewriter("Personen du såg framför dig var");
  Red("Du.");
  Typewriter("Det var helt otroligt hur mycket personen liknade dig, till och med du själv blev lurad för en sekund.");
  Typewriter("\"Välkommen till nivå två. Här får ni ett vall. Väljer du att slåss mot din dubbelgångare, eller fly?\"");
  Typewriter("\"Ni båda får varsit svärd. Den sista som står på både benen av er tar sig till nästa nivå.\"");
  Typewriter("Vad röstar du på? Fight or Flight");

  choice = Console.ReadLine();
  choice = choice.ToLower();


  // Andra valen
  if (choice == "flight" || choice == "Flight")
  {
    Console.Clear();
    Typewriter("7");
    Långsam("...");
    Typewriter("Du röstade på \"Flight\".");
    Typewriter("Alla blir tilldelade varsit svärd, även dubbelgångarna får varsin.");
    Typewriter("Tiden börjar därmed räkna ner.");
    Långsam("3 ...  2  ... 1");
    Typewriter("Du hörde ett skott och märkte att alla började springa. Du ser även någon springa med snabba steg mot dig.");
    Typewriter("Du hinner inte reagera innan du känner en obegriplig smärta i din mage. Du ser ett svärd åka in och ut från din mage.");
    Typewriter("Du var för sen och kolapsade.");
    Typewriter("Din syn var blurrig, men du hörde fotspår närma sig.");
    Typewriter("Du gör ditt bästa för att titta på din motståndare så tittar ner på dig.");
    Typewriter("Direkt innan du tappar sinnet hör du den säga:");
    Red($"Jag är {playerName} nu.");
    Död();
  }

  else if (choice == "fight" || choice == "Fight" || choice == "2")
  {
    Console.Clear();
    Typewriter("3");
    Långsam("...");
    Typewriter("Du bestämmer dig för att slås tillbaka.");
    Typewriter("Det är nu eller aldrig.");
    Typewriter("Ni får varsit svärd och så börjar tiden att gå ner.");
    Långsam("3 ...  2  ... 1");
    Typewriter("Du håller hårt i ditt svärd och tittar din motståndare i ögonen.");
    Typewriter("Det är nu det händer.");

    int p1Hp = 100;
    int p2Hp = 100;
    string p1Name = "Dubbelgångaren";
    string p2Name = $"{playerName}";

    Random generator = new Random();

    // Här börjar man slås
    while (p1Hp > 0 && p2Hp > 0)
    {
      Console.Clear();
      Typewriter($"{p2Name} har {p2Hp} energi och {p1Name} har {p1Hp} energi.\n");

      int heroDamage = generator.Next(50);
      p2Hp -= heroDamage;
      p2Hp = Math.Max(0, p2Hp);
      Typewriter($"{p1Name} träffar {p2Name} med sitt svärd och förlorar mycket blood. Minus {heroDamage} energi.");

      int villainDamage = generator.Next(30);
      p1Hp -= villainDamage;
      p1Hp = Math.Max(0, p1Hp);
      Typewriter($"{p2Name} träffar {p1Name} på benet.{p1Name} förlorar {villainDamage} energi.");
      Console.ReadLine();
    }

    Typewriter("Nu var tiden ute.");
    Typewriter("Resultatet är...");
    if (p1Hp == 0 && p2Hp == 0)
    {
      Console.Clear();
      Långsam("...");
      Typewriter("Ni båda hade förlorat för mycket blod för att fortsätta och långsamt dog.");
      Typewriter("Oavgjort.");
      Rödscreen();
    }

    else if (p2Hp == 0)
    {
      Console.Clear();
      Långsam("...");
      Red($"{p1Name} har vunnit.");
      Typewriter("Din syn var blurrig, men du hörde fotspår närma sig.");
      Typewriter("Du gör ditt bästa för att titta på din motståndare så tittar ner på dig.");
      Typewriter("Du ser siffrorna \"11037\" på din motståndares tröja, varför är det vikigt?");
      Typewriter("Direkt innan du tappar sinnet hör du den säga:");
      Red($"Jag är {playerName} nu.");
      Död();
    }

    else
    {
      Långsam("...");
      Green($"{p2Name} har vunnit.");
      Typewriter("Du ser sin föredetta motståndare liga på marken, nästan helt livlöst.");
      Typewriter("Du börjar undra, var det en riktig människa?");
      Typewriter("Den blöder som en vanlig männsika skulle");
      Typewriter("");


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
        Död();
        Långsam("...");
        Typewriter("Om du inte listade ut koden så är den \"11037\".");
      }
    }
  }

  else
  {
    Typewriter("!Om du har svårt att skriva in dina svar, tryck enter en gång innan du skriver in ditt svar!");
  }

}


Rödscreen();
Typewriter("Var fösiktig och tryck inte ENTER för mycket annars går spelet sönder.");
Typewriter("Tryck ENTER för att avsluta");
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

// Långsam text
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



// Röd effekt 
static void Rödscreen()
{
  // inlednande itensiteten av den röda färgen
  int intensity = 15;

  // öka intensiteten av den röda färgen
  for (; intensity <= 15; intensity++)
  {
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.Clear();
    Thread.Sleep(5); 
  }

  // vänta en specific tif för att få röd skärm.
  Thread.Sleep(100); // millisekunder

  // svart och röd blinkande
  for (; intensity >= 0; intensity--)
  {
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.Clear();
    Thread.Sleep(5); 

    // minska intensiteten av röd
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Clear();
    Thread.Sleep(2); 
  }
  // rensa consolen ater blinkandet
  Console.Clear();
}

// Metod när man dör
void Död()
{
  Red("Du dog.");
  Rödscreen();
  Console.Clear();
}