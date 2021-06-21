using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ob;
    public int maxh = 10;
    public  static int curh;
    // Start is called before the first frame update
    void Start()
    {
        curh = maxh;

    }

    // Update is called once per frame
    void Update()
    {
       

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(ob, transform.position, Quaternion.identity);
            TotalScoreValue.totscore++;

            Destroy(gameObject);



            



        }


    }
}
