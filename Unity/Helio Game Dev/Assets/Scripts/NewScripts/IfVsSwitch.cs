using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfVsSwitch : MonoBehaviour
{
    public string playerLevel = "Apprentace";

    // Use this for initialization
    void Start()
    {
        switch (playerLevel)
        {
            case "Wizard": 
			case "Wizard2":
                print("Wizard");
                break;
            case "Warlock":
                print("Warlock");
                break;
            case "Mage":
                print("Mage");
                break;
            case "High Wizard":
                print("High Wizard");
                break;
            default:
                print("You are not at a high enough level!");
                break;
        }
    }
}
