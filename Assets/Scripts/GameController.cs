
using UnityEngine;

using TMPro;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    // reference to text box
    [SerializeField] private TMP_Text outputText;

    // reference to buttons
    // look
    [SerializeField] private Button lookButton;

    // north
    [SerializeField] private Button northButton;

    // south
    [SerializeField] private Button southButton;

    // east
    [SerializeField] private Button eastButton;

    // west
    [SerializeField] private Button westButton;



    // declare new room objects to create a map
    Room room0;

    Room room1;

    Room room2;

    Room room3;


    // declare a map array of room objects for the map
    Room[] map;


    // declare a player object
    private Character _player;




    private void Start()
    {
        InitialiseGame();

        InitialiseButtons();

        StartGame();
    }



    private void InitialiseGame()
    {
        // create the new room objects
        room0 = new Room("Troll Room", "a dark, dank room that smells of troll", -1, 2, 1, -1);

        room1 = new Room("Forest", "a light, airy forest shimmering with sunlight", -1, -1, -1, 0);

        room2 = new Room("Cave", "a vast cave with walls covered by luminous moss", 0, -1, 3, -1);

        room3 = new Room("Dungeon", "a gloomy dungeon. Rats scurry across its floor", -1, -1, -1, 2);


        // initialise the map array
        map = new Room[4];


        // assign the room objects to the map array
        map[0] = room0;

        map[1] = room1;

        map[2] = room2;

        map[3] = room3;


        // set player's current room
        _player = new Character("You", "The Player", room0);
    }


    private void InitialiseButtons()
    {
        lookButton.onClick.AddListener(LookButton);

        northButton.onClick.AddListener(NorthButton);

        southButton.onClick.AddListener(SouthButton);

        eastButton.onClick.AddListener(EastButton);

        westButton.onClick.AddListener(WestButton);
    }


    private void StartGame()
    {
        outputText.text = $"Welcome to the Great Adventure!\nYou are in the {_player.Location.Name}.  It is {_player.Location.Description}\n";

        outputText.text += "Where do you want to go now?\n";

        outputText.text += "Click a direction button: NORTH, SOUTH, EAST or WEST\n";
    }


    private void MovePlayer(int newRoom)
    {
        // if the new room to move to cannot be reached
        if (newRoom == -1)
        {
            // then display a message to in say no exit in that direction
            outputText.text = "There is no exit in that direction\n";
        }

        // otherwise
        else
        {
            // move player to the new room
            _player.Location = map[newRoom];

            // and display the room description
            outputText.text = $"You are now in the {_player.Location.Name}\n";
        }
    }


    private void LookButton()
    {
        outputText.text = $"You are in the {_player.Location.Name}.  It is {_player.Location.Description}\n";
    }


    private void NorthButton()
    {
        MovePlayer(_player.Location.N);
    }


    private void SouthButton()
    {
        MovePlayer(_player.Location.S);
    }


    private void EastButton()
    {
        MovePlayer(_player.Location.E);
    }


    private void WestButton()
    {
        MovePlayer(_player.Location.W);
    }


} // end of class
