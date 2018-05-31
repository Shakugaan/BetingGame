using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointController : MonoBehaviour {
    public Text Player1;
    public Text Player2;
    public Text Player3;
    public Text Player4;
    public int betP1 = 0;
    public int betP2 = 0;
    public int betP3 = 0;
    public int betP4 = 0;
    public void AddPointsP1()
    {
        if (Player1.text == "0")
        {
            betP1 = 0;
        }
        betP1++;
        Player1.text = "" + betP1.ToString();
    }
    public void AddPointsP2()
    {
        if (Player2.text == "0")
        {
            betP2 = 0;
        }
        betP2++;
        Player2.text = "" + betP2.ToString();
    }
    public void AddPointsP3()
    {
        if (Player3.text == "0")
        {
            betP3 = 0;
        }
        betP3++;
        Player3.text = "" + betP3.ToString();
    }
    public void AddPointsP4()
    {
        if (Player4.text == "0")
        {
            betP4 = 0;
        }
        betP4++;
        Player4.text = "" + betP4.ToString();
    }
    public void TakePointsP1()
    {
        if (Player1.text == "0")
        {
            betP1 = 0;
        }
        if (betP1 > 0)
        {
            betP1--;
            Player1.text = "" + betP1.ToString();
        }
    }
    public void TakePointsP2()
    {
        if (Player2.text == "0")
        {
            betP2 = 0;
        }
        if (betP2 > 0)
        {
            betP2--;
            Player2.text = "" + betP2.ToString();
        }
    }
    public void TakePointsP3()
    {
        if (Player3.text == "0")
        {
            betP3 = 0;
        }
        if (betP3 > 0)
        {
            betP3--;
            Player3.text = "" + betP3.ToString();
        }
    }
    public void TakePointsP4()
    {
        if (Player4.text == "0")
        {
            betP4 = 0;
        }
        if (betP4 > 0)
        {
            betP4--;
            Player4.text = "" + betP4.ToString();
        }
    }

}

