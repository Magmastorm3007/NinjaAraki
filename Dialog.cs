using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public float typespeed=0.02f;
    public TextMeshProUGUI textdisplay;
    public string[] sentences;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(type());
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    IEnumerator type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textdisplay.text += letter;
            yield return new WaitForSeconds(typespeed);

           
            
        }

      
    }


    void newsent()
    {
        if (index < sentences.Length - 1)
        {
           
            index++;

            StartCoroutine(type());




        }

        else
        {
            textdisplay.text = "";

        }
    }

}
