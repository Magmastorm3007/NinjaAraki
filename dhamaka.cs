using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dhamaka : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hmm");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("oh");
            RestartPanel.ret = true;

        }
          
    }
}
