
using UnityEngine;


public class Object
{
    // name of object - room, character, pickup
    private string _name;

    // description of object - room, character, pickup
    private string _description;





    // getters and setters
    // name
    public string Name
    {
        // getter - only allows the value to be read
        get
        {
            return _name;
        }

        // setter - allows the value to be set
        set
        {
            _name = value;
        }
    }


    // description
    public string Description
    {
        // getter - only allows the value to be read
        get
        {
            return _description;
        }

        // setter - allows the value to be set
        set
        {
            _description = value;
        }
    }


} // end of class
