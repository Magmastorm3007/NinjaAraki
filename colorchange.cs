using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange: MonoBehaviour
{
    private Renderer rend;

    [SerializeField]
    private Color colortoturnto = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rend.material.color = colortoturnto;
            
        }
        
    }
}
