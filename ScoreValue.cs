using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreValue : MonoBehaviour
{
    public static int scoreval = 0;
    public static int highscore = 0;
     Text score1;
    // Start is called before the first frame update
    void Start()
    {
        scoreval = 0;
        score1 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score1.text = "Statues Collected: " + scoreval; 
    }
}
