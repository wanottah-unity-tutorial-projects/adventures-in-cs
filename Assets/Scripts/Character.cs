
using UnityEngine;


// character object
// inherits from object
public class Character : Object
{
    // character's current location
    // read from the room object
    private Room _location;



    // 'Character's' object constructor
    // initialise the 'Character's' parameters and call (base) the parent class ('Object')
    public Character(string characterName, string characterDescription, Room currentRoom) : base(characterName, characterDescription)
    {
        // and assign the character's location, read from 'Room' object
        _location = currentRoom;
    }



    // getters and setters
    // location
    public Room Location
    {
        // getter - only allows the value to be read
        get
        {
            return _location;
        }

        // setter - allows the value to be set
        set
        {
            _location = value;
        }
    }


} // end of class
