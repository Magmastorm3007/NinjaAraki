using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowStars : MonoBehaviour
{
    public GameObject[] stars;
    public int fullscore;
    int scoreleft;
    
    // Start is called before the first frame update
    void Start()
    {
        stars[0].SetActive(false);
        stars[1].SetActive(false);
        stars[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int d = TotalScoreValue.totscore;


        float perc =float.Parse(d.ToString() )/ float.Parse(fullscore.ToString()) * 100f;
        if (perc <= 32f)
        {
            stars[0].SetActive(true);
        }
        
        
      
        else if (perc >= 33f && perc <= 85f)
        {
            stars[0].SetActive(true);

            stars[1].SetActive(true);

        }
       else if (perc >= 86)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);

        }
    }
}
