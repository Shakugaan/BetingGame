using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AddPoint : MonoBehaviour {
    public Text myText = null;
    
    public int bet = 0;
    
    public void AddPoints()
    {
        if(myText.text=="0")
        {
            bet = 0;
        }
        bet++;
        myText.text = "" + bet.ToString();
    }
    public void TakePoints()
    {
        if (myText.text == "0")
        {
            bet = 0;
        }
        if (bet > 0)
        {
            bet--;
            myText.text = "" + bet.ToString();
        }
    }
}
