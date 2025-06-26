
using UnityEngine;


// room object
// inherits from object
public class Room : Object
{
    // room exits
    private int _n;

    private int _s;

    private int _e;

    private int _w;



    // Room's object constructor
    // initialise the 'Room's' parameters and call (base) the parent class ('Object')
    public Room(string roomName, string roomDescription, int aN, int aS, int aE, int aW) : base(roomName, roomDescription)
    {
        _n = aN;

        _s = aS;

        _e = aE;

        _w = aW;
    }



    // getters and setters
    // north
    public int N
    {
        // getter - only allows the value to be read
        get
        {
            return _n;
        }

        // setter - allows the value to be set
        set
        {
            _n = value;
        }
    }


    // south
    public int S
    {
        // getter - only allows the value to be read
        get
        {
            return _s;
        }

        // setter - allows the value to be set
        set
        {
            _s = value;
        }
    }


    // east
    public int E
    {
        // getter - only allows the value to be read
        get
        {
            return _e;
        }

        // setter - allows the value to be set
        set
        {
            _e = value;
        }
    }


    // west
    public int W
    {
        // getter - only allows the value to be read
        get
        {
            return _w;
        }

        // setter - allows the value to be set
        set
        {
            _w = value;
        }
    }


} // end of class
