
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



    // player's current room
    private int currentRoom;



    private void Start()
    {
        InitialiseGame();

        InitialiseButtons();

        StartGame();
    }



    private void InitialiseGame()
    {
        // create the new room objects
        room0 = new Room();

        room1 = new Room();

        room2 = new Room();

        room3 = new Room();


        // initialise the map array
        map = new Room[4];


        // assign the room objects to the map array
        map[0] = room0;

        map[1] = room1;

        map[2] = room2;

        map[3] = room3;


        // initialise the room data
        // room 0
        room0.name = "Troll Room";

        room0.description = "a dark, dank room that smells of troll";

        room0.n = -1;
        room0.s = 2;
        room0.e = 1;
        room0.w = -1;

        // room 1
        room1.name = "Forest";

        room1.description = "a light, airy forest shimmering with sunlight";

        room1.n = -1;
        room1.s = -1;
        room1.e = -1;
        room1.w = 0;

        // room 2
        room2.name = "Cave";

        room2.description = "a vast cave with walls covered by luminous moss";

        room2.n = 0;
        room2.s = -1;
        room2.e = 3;
        room2.w = -1;

        // room 3
        room3.name = "Dungeon";

        room3.description = "a gloomy dungeon. Rats scurry across its floor";

        room3.n = -1;
        room3.s = -1;
        room3.e = -1;
        room3.w = 2;


        // set player's current room
        currentRoom = 0;
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
        outputText.text = $"Welcome to the Great Adventure!\nYou are in the {map[currentRoom].name}.  It is {map[currentRoom].description}\n";

        outputText.text += "Where do you want to go now?\n";

        outputText.text += "Click a direction button: NORTH, SOUTH, EAST or WEST\n";
    }


    private void MovePlayer(int newRoom)
    {
        // if the new room to move to equals -1
        if (newRoom == -1)
        {
            // then display a message to in say no exit in that direction
            outputText.text = "There is no exit in that direction\n";
        }

        // otherwise
        else
        {
            // move to the new room
            currentRoom = newRoom;

            // and display the room description
            outputText.text = $"You are now in the {map[currentRoom].name}\n";
        }
    }


    private void LookButton()
    {
        outputText.text = $"You are in the {map[currentRoom].name}.  It is {map[currentRoom].description}\n";
    }


    private void NorthButton()
    {
        MovePlayer(map[currentRoom].n);
    }


    private void SouthButton()
    {
        MovePlayer(map[currentRoom].s);
    }


    private void EastButton()
    {
        MovePlayer(map[currentRoom].e);
    }


    private void WestButton()
    {
        MovePlayer(map[currentRoom].w);
    }


} // end of class
