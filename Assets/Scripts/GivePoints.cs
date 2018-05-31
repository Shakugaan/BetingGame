using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GivePoints : MonoBehaviour {

    public Text ScoreP1;
    public Text BetingP1;
    public Text ColP1;

    public Text ScoreP2;
    public Text BetingP2;
    public Text ColP2;

    public Text ScoreP3;
    public Text BetingP3;
    public Text ColP3;

    public Text ScoreP4;
    public Text BetingP4;
    public Text ColP4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NPC green"))
        {
            DestroyAll();
            gameObject.SetActive(false);
            if (ColP1.text=="green")
            { int bet = Int32.Parse(ScoreP1.text) + Int32.Parse(BetingP1.text);
                ScoreP1.text = "" + bet.ToString();
            }
            BetingP1.text = "0";
            if (ColP2.text == "green")
            {
                int bet = Int32.Parse(ScoreP2.text) + Int32.Parse(BetingP2.text);
                ScoreP2.text = "" + bet.ToString();
            }
            BetingP2.text = "0";
            if (ColP3.text == "green")
            {
                int bet = Int32.Parse(ScoreP3.text) + Int32.Parse(BetingP3.text);
                ScoreP3.text = "" + bet.ToString();
            }
            BetingP3.text = "0";
            if (ColP4.text == "green")
            {
                int bet = Int32.Parse(ScoreP4.text) + Int32.Parse(BetingP4.text);
                ScoreP4.text = "" + bet.ToString();
            }
            BetingP4.text = "0";
        }

        if (other.gameObject.CompareTag("NPC blue"))
        {
            DestroyAll();
            gameObject.SetActive(false);

            if (ColP1.text == "blue")
            {
                int bet = Int32.Parse(ScoreP1.text) + Int32.Parse(BetingP1.text);
                ScoreP1.text = "" + bet.ToString();
            }
            BetingP1.text = "0";

            if (ColP2.text == "blue")
            {
                int bet = Int32.Parse(ScoreP2.text) + Int32.Parse(BetingP2.text);
                ScoreP2.text = "" + bet.ToString();
            }
            BetingP2.text = "0";

            if (ColP3.text == "blue")
            {
                int bet = Int32.Parse(ScoreP3.text) + Int32.Parse(BetingP3.text);
                ScoreP3.text = "" + bet.ToString();
            }
            BetingP3.text = "0";

            if (ColP4.text == "blue")
            {
                int bet = Int32.Parse(ScoreP4.text) + Int32.Parse(BetingP4.text);
                ScoreP4.text = "" + bet.ToString();
            }
            BetingP4.text = "0";
        }

        if (other.gameObject.CompareTag("NPC red"))
        {
            DestroyAll();
            gameObject.SetActive(false);

            if (ColP1.text == "red")
            {
                int bet = Int32.Parse(ScoreP1.text) + Int32.Parse(BetingP1.text);
                ScoreP1.text = "" + bet.ToString();
            }
            BetingP1.text = "0";

            if (ColP2.text == "red")
            {
                int bet = Int32.Parse(ScoreP2.text) + Int32.Parse(BetingP2.text);
                ScoreP2.text = "" + bet.ToString();
            }
            BetingP2.text = "0";

            if (ColP3.text == "red")
            {
                int bet = Int32.Parse(ScoreP3.text) + Int32.Parse(BetingP3.text);
                ScoreP3.text = "" + bet.ToString();
            }
            BetingP3.text = "0";

            if (ColP4.text == "red")
            {
                int bet = Int32.Parse(ScoreP4.text) + Int32.Parse(BetingP4.text);
                ScoreP4.text = "" + bet.ToString();
            }
            BetingP4.text = "0";
        }

        if (other.gameObject.CompareTag("NPC yellow"))
        {
            DestroyAll();
            gameObject.SetActive(false);

            if (ColP1.text == "yellow")
            {
                int bet = Int32.Parse(ScoreP1.text) + Int32.Parse(BetingP1.text);
                ScoreP1.text = "" + bet.ToString();
            }
            BetingP1.text = "0";

            if (ColP2.text == "yellow")
            {
                int bet = Int32.Parse(ScoreP2.text) + Int32.Parse(BetingP2.text);
                ScoreP2.text = "" + bet.ToString();
            }
            BetingP2.text = "0";

            if (ColP3.text == "yellow")
            {
                int bet = Int32.Parse(ScoreP3.text) + Int32.Parse(BetingP3.text);
                ScoreP3.text = "" + bet.ToString();
            }
            BetingP3.text = "0";

            if (ColP4.text == "yellow")
            {
                int bet = Int32.Parse(ScoreP4.text) + Int32.Parse(BetingP4.text);
                ScoreP4.text = "" + bet.ToString();
            }
            BetingP4.text = "0";
        }

    }
    void DestroyAll()
    {
        
        Destroy(GameObject.FindGameObjectWithTag("NPC green"));
        Destroy(GameObject.FindGameObjectWithTag("NPC red"));
        Destroy(GameObject.FindGameObjectWithTag("NPC blue"));
        Destroy(GameObject.FindGameObjectWithTag("NPC yellow"));
    }
}
