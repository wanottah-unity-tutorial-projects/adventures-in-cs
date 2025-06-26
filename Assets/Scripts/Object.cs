
using UnityEditor;
using UnityEngine;


public class Object
{
    // name of object - room, character, pickup
    private string _name;

    // description of object - room, character, pickup
    private string _description;



    // 'Object's' object constructor
    // initialise the 'Object's' parameters
    public Object(string objectName, string objectDescription)
    {
        // and assign them to the Object's name and description
        _name = objectName;

        _description = objectDescription;
    }





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
