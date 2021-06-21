using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject ob;
    public GameObject dm;
    public int maxh = 30;
    public int curh;
    // Start is called before the first frame update
    void Start()
    { 
        curh = maxh;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (curh <= 0)
        {
            Instantiate(ob,transform.position,Quaternion.identity);

            Destroy(gameObject);


        }
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "sword")
        { 
           


    curh -= 10;
            if (curh != 0)
                Instantiate(dm, transform.position, Quaternion.identity);

        }

        
    }
}
