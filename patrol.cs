using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour
{
    public float movespeed;

    public float distance;



    private bool movingRight = true;



    public Transform groundDetection;


    private void Update()

    {
        
        RaycastHit2D groundinfo = Physics2D.Raycast(groundDetection.position,Vector2.down,2f);
        if (groundinfo.collider == false)
        {
            if (movingRight == true) {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;

            }


        }

    }

    
}