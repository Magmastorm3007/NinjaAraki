using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Health hbar;
    public int maxh = 100;
    public int curh;
    // Start is called before the first frame update
    void Start()
    {
        curh = maxh;
        hbar.SetMaxHealth(maxh);
    }

    // Update is called once per frame
    void Update()
    {
        if (curh == 0)
            RestartPanel.ret = true;
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {

            curh -= 5;
            hbar.SetHealth(curh);


        }
     
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "rep")
        {
            curh += 10;
            hbar.SetHealth(curh);
            Destroy(collision.gameObject);


        }
    }
}
