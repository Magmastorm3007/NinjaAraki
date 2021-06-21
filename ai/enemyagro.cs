using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyagro : MonoBehaviour
{
    public GameObject ob;
    public Transform player;
    public float dist;
    public float speed;
        public float close;

    public Transform groundDetection;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D groundinfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f);
        dist = transform.position.x-player.position.x ;

        if(dist<=close&& dist>3&& groundinfo.collider == true)
        {
            transform.Translate(Vector2.right * speed * Time.fixedDeltaTime);
            ob.GetComponent<Animator>().Play("walk1");
        }

        if (dist <= 3 && dist>=-1 && groundinfo.collider == true)
        {
            ob.GetComponent<Animator>().Play("swing");
        }
        if (groundinfo.collider == false)
        {
            transform.Rotate(0, 180, 0);
        }




        if (dist < 0)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);

            if (dist > -close && dist < -3 && groundinfo.collider==true)
            {
            

                transform.Translate(Vector2.right * speed * Time.fixedDeltaTime);
                ob.GetComponent<Animator>().Play("walk1");
            }

            else if (dist < -1.7 && groundinfo.collider == true)
            {
                ob.GetComponent<Animator>().Play("swing");
            }
        }



    }
   
}
