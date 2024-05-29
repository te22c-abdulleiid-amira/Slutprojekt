using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows;
using System.Threading;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace InteraktivBerattelse
{
// klass som representerar en scen i berättelsen
public class Scene
    {
        public string Description { get; set; } // beskrivning av scenen
        public Dictionary<int, string> Choices { get; set; } // val spelaren kan göra
    }
}


namespace InteraktivBerattelse
{
    // klass som hanterar berättelsen och dess scener
    public class Story
    {
        public Dictionary<int, Scene> Scenes { get; private set; }

        public Story()
        {
            // initiera scener och val
            Scenes = new Dictionary<int, Scene>
            {
                { 1, new Scene { Description = "Du varknar upp i ett rum med två dörrar där det står \"Döda\" eller \"Leva\". Vilken väljer du?", Choices = new Dictionary<int, string> { { 1, "Döda" }, { 2, "Leva" } } } },
                { 2, new Scene { Description = "Du ser en arena där det finns elva plattor.", Choices = new Dictionary<int, string> { { 1, "Stå på en av plattorna." } } } },
                { 3, new Scene { Description = "Du blir tvingad att sloss mot din dubbelgångare. Fight or Flight?", Choices = new Dictionary<int, string> { { 1, "Fight" }, { 2, "Flight" } } } },
                { 4, new Scene { Description = "Du lyckades att fly.", Choices = new Dictionary<int, string>() } },
                { 5, new Scene { Description = "Du besegrade dubbelgångaren.", Choices = new Dictionary<int, string>() } },
                { 6, new Scene { Description = "Du har överlevt.", Choices = new Dictionary<int, string>() } }
            };
        }
    }
}

namespace InteraktivBerattelse
{
    // klass som hanterar spelprocessen
    public class Game
    {
        private Story _story;
        private int _currentSceneId;

    public Game()
    {
    _story = new Story(); // skapa en ny berättelse
    _currentSceneId = 1; // starta vid första scenen
    }

// start
    public void Start()
    {
        while (true)
    {
    // hämta den aktuella scenen
    Scene currentScene = _story.Scenes[_currentSceneId];
    Console.WriteLine(currentScene.Description); // hisa scenbeskrivningen

    if (currentScene.Choices.Count == 0)
    {
        Console.WriteLine("slut");
        break;
    }

    // visa valen spelaren kan göra
    foreach (var choice in currentScene.Choices)
    {
        Console.WriteLine($"{choice.Key}. {choice.Value}");
    }

    // läs spelarens val
    if (int.TryParse(Console.ReadLine(), out int choiceId) && currentScene.Choices.ContainsKey(choiceId))
    {
        // uppdatera scen baserat på spelarens val
        _currentSceneId = choiceId switch
        {
            1 when _currentSceneId == 1 => 2,
            2 when _currentSceneId == 1 => 3,
            1 when _currentSceneId == 2 => 4,
            1 when _currentSceneId == 3 => 5,
            2 when _currentSceneId == 3 => 6,
            _ => _currentSceneId
        };
        }
        else
        {
            Console.WriteLine("jag fattar inte"); // om någonting går fel
        }
        }
    }
}
}

namespace InteraktivBerattelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(); // skapa ett nytt spel
            game.Start(); // starta spelet
        }
    }
}