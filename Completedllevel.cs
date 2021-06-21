using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Completedllevel : MonoBehaviour
{
    public static bool levelover;
    public GameObject leveloverpanel;
    // Start is called before the first frame update
    void Start()
    {
        levelover = false;
        leveloverpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (levelover == true)
        {
           
            leveloverpanel.SetActive(true);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            levelover = true;

            Time.timeScale = 0f;
        }

    }
}