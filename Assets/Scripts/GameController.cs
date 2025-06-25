
using UnityEngine;

using TMPro;


public class GameController : MonoBehaviour
{
    // reference to text box
    public TMP_Text outputText;



    public void button1()
    {
        // create a new room object
        Room r = new Room();

        r.name = "Troll Room";

        r.n = 1;
        r.s = 2;
        r.e = 3;
        r.w = 4;

        outputText.text = $"You are in the {r.name}.  There are exits to the {r.n}, {r.s}, {r.e} and {r.w}.";
    }

} // end of class
