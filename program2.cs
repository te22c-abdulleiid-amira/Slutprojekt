using System;
using System.Collections.Generic;
using System.Media;
using System.Drawing;

namespace InteraktivBerattelse
{
// class som representerar scenen i den interactiva berättelsen 
public class Scene
{
    public string Description { get; set; }
    public Dictionary<int, string> Choices { get; set; }
}

// klass som hantera berättelsen och senen 
public class Story
{
    public Dictionary<int, Scene> Scenes { get; private set; }

    public Story()
    {
        // fixa senen och valen
        Scenes = new Dictionary<int, Scene>
        {
            { 1, new Scene { Description = "Du vaknar upp i ett rum med två dörrar där det står 'Döda' eller 'Leva'. Vilken väljer du?", Choices = new Dictionary<int, string> { { 1, "Döda" }, { 2, "Leva" } } } },
            { 2, new Scene { Description = "Du ser en arena där det finns elva plattor.", Choices = new Dictionary<int, string> { { 1, "Stå på en av plattorna." } } } },
            { 3, new Scene { Description = "Du blir tvingad att slåss mot din dubbelgångare. Fight or Flight?", Choices = new Dictionary<int, string> { { 1, "Fight" }, { 2, "Flight" } } } },
            { 4, new Scene { Description = "Du lyckades att fly.", Choices = new Dictionary<int, string>() } },
            { 5, new Scene { Description = "Du besegrade dubbelgångaren.", Choices = new Dictionary<int, string>() } },
            { 6, new Scene { Description = "Du har överlevt.", Choices = new Dictionary<int, string>() } }
        };
    }
}

// class som hantera processen av spelet
public class Game
{
    private Story _story;
    private int _currentSceneId;

    public Game()
    {
        _story = new Story(); // skapa ny saga
        _currentSceneId = 1; // starts från första senen
    }

    // börja spelet
    public void Start()
    {
        while (true)
        {
            // fixa senen
            Scene currentScene = _story.Scenes[_currentSceneId];
            Console.WriteLine(currentScene.Description); // visa senens besrkvining

            if (currentScene.Choices.Count == 0)
            {
                Console.WriteLine("Slut");
                break;
            }

            // visa spelarens val
            foreach (var choice in currentScene.Choices)
            {
                Console.WriteLine($"{choice.Key}. {choice.Value}");
            }

            // läs spelarens val
            if (int.TryParse(Console.ReadLine(), out int choiceId) && currentScene.Choices.ContainsKey(choiceId))
            {
            // updatera senen baserad på spelarens val
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
                Console.WriteLine("Jag fattar inte"); // om någonting går fel
            }
        }
    }
}    
class Program
{
    static void Main(string[] args)
    {
        Game game = new Game(); // skapa nytt såel
        game.Start(); // stata spelet 
    }
}
}
