using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humpkar : MonoBehaviour
{
    public bool ok = true;
    public float jumpspeed;
 public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W)&&ok)
            rb.AddForce(Vector2.up * jumpspeed);
      
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("surface"))
        {
            ok = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("surface"))
        {
           ok = false;
        }
    }

}