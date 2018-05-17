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
