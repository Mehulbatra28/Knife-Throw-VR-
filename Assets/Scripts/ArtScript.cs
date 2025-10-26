using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArtScript : MonoBehaviour
{
    public TMP_Text buttonText;
    public Button[] artButtons;
    public void OnButtonClick(int index)
    {
        if (index == 0)
        {
            buttonText.text = "Mountains";
        }
        else if (index == 1)
        {
            buttonText.text = "Green Bridge";
        }
        else if (index == 2)
        {
            buttonText.text = "Tree";
        }
        else if (index == 3)
        {
            buttonText.text = "Camera";
        }
        else if (index == 4)
        {
            buttonText.text = "Girl With Camera";
        }
        else if (index == 5)
        {
            buttonText.text = "Butterfly";
        }
        else if (index == 6)
        {
            buttonText.text = "Bear";
        }
        else if (index == 7)
        {
            buttonText.text = "Tree and sunrays";
        }
        else if (index == 8)
        {
            buttonText.text = "Scenery";
        }
        else if (index == 9)
        {
            buttonText.text = "Girl";
        }
        else if (index == 10)
        {
            buttonText.text = "Boat";
        }
        else if (index == 11)
        {
            buttonText.text = "Girl Shadow";
        }
        else if (index == 12)
        {
            buttonText.text = "River";
        }
        else if (index == 13)
        {
            buttonText.text = "Eye";
        }

    }
}
