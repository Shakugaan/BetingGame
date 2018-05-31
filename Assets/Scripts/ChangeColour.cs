using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeColour : MonoBehaviour
{
    public Image col1;
    public Image col2;
    public Image col3;
    public Image col4;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    private int i1 = 0;
    private int i2 = 0;
    private int i3 = 0;
    private int i4 = 0;
    private void Start()
    {
        col1.color = new Color(0, 0, 255, 255);
        col2.color = new Color(0, 0, 255, 255);
        col3.color = new Color(0, 0, 255, 255);
        col4.color = new Color(0, 0, 255, 255);
        text1.text = "blue";
        text2.text = "blue";
        text3.text = "blue";
        text4.text = "blue";
    }

    public void col1Change()
    {
        i1++;
        if (i1 == 0)
        {
            col1.color = new Color(0, 0, 255, 255);
            text1.text = "blue";
        }
        if(i1 == 1)
        {
            col1.color = new Color(0, 255, 0, 255);
            text1.text = "green";
        }
        if (i1 == 2)
        {
            col1.color = new Color(255, 0, 0, 255);
            text1.text = "red";
        }
        if (i1 == 3)
        {
            col1.color = new Color(255, 255, 0, 255);
            text1.text = "yellow";
            i1 = -1;
        }
    }

    public void col2Change()
    {
        i2++;
        if (i2 == 0)
        {
            col2.color = new Color(0, 0, 255, 255);
            text2.text = "blue";
        }
        if (i2 == 1)
        {
            col2.color = new Color(0, 255, 0, 255);
            text2.text = "green";
        }
        if (i2 == 2)
        {
            col2.color = new Color(255, 0, 0, 255);
            text2.text = "red";
        }
        if (i2 == 3)
        {
            col2.color = new Color(255, 255, 0, 255);
            text2.text = "yellow";
            i2 = -1;
        }
    }
    public void col3Change()
    {
        i3++;
        if (i3 == 0)
        {
            col3.color = new Color(0, 0, 255, 255);
            text3.text = "blue";
        }
        if (i3 == 1)
        {
            col3.color = new Color(0, 255, 0, 255);
            text3.text = "green";
        }
        if (i3 == 2)
        {
            col3.color = new Color(255, 0, 0, 255);
            text3.text = "red";
        }
        if (i3 == 3)
        {
            col3.color = new Color(255, 255, 0, 255);
            text3.text = "yellow";
            i3 = -1;
        }
    }
    public void col4Change()
    {
        i4++;
        if (i4 == 0)
        {
            col4.color = new Color(0, 0, 255, 255);
            text4.text = "blue";
        }
        if (i4 == 1)
        {
            col4.color = new Color(0, 255, 0, 255);
            text4.text = "green";
        }
        if (i4 == 2)
        {
            col4.color = new Color(255, 0, 0, 255);
            text4.text = "red";
        }
        if (i4 == 3)
        {
            col4.color = new Color(255, 255, 0, 255);
            text4.text = "yellow";
            i4 = -1;
        }
    }











}
