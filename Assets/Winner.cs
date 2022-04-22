using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    public Text winText;
    //private bool FinishLine = false;

    void Start()
    {
        System.Console.WriteLine("Here 1");
        //FinishLine = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            //FinishLine = true;
            winText.text = "You Win";
            System.Console.WriteLine("Here");
        }
    }
}