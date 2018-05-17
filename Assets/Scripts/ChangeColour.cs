using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeColour : MonoBehaviour
{
    public Image Clr;
    public Text text;
    private int i = 0;

    private void Start()
    {
        Clr.color = new Color(0, 0, 255, 255);
        text.text = "blue";
    }

    public void ClrChange()
    {
        i++;
        if (i == 0)
        {
            Clr.color = new Color(0, 0, 255, 255);
            text.text = "blue";
        }
        if(i == 1)
        {
            Clr.color = new Color(0, 255, 0, 255);
            text.text = "green";
        }
        if (i == 2)
        {
            Clr.color = new Color(255, 0, 0, 255);
            text.text = "red";
        }
        if (i == 3)
        {
            Clr.color = new Color(255, 255, 0, 255);
            text.text = "yellow";
            i = -1;
        }
    }
    
}
