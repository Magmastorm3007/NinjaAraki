using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    AudioSource audi;
    public Animator f;
    public float movespeed;
    bool fr = true;
    public GameObject ob;
   public float jumpspeed = 3f;
    bool isGrounded = true;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        audi = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        //transform.position += new Vector3(movespeed, 0, 0);


        float horizontalInput = Input.GetAxis("Horizontal");

            //get the Input from Vertical axis
          
        if (horizontalInput < 0 && fr)
        {
            fr = !fr;
            transform.Rotate(0, 180, 0);
           


        }            
        if (horizontalInput > 0 && !fr)
        {
            fr = !fr;
            transform.Rotate(0, 180, 0);
        }
        //update the position




        if (horizontalInput != 0 && Input.GetKey(KeyCode.W) == false && isGrounded)
        {
            ob.GetComponent<Animator>().Play("walk");
            transform.position = transform.position + new Vector3(horizontalInput * movespeed * Time.deltaTime, 0, 0);


        }
        else if(horizontalInput != 0 && !isGrounded)
        {
            ob.GetComponent<Animator>().Play("jump");
            transform.position = transform.position + new Vector3(horizontalInput * movespeed * Time.deltaTime, 0, 0);
          


        }

        if (Input.GetKeyDown(KeyCode.W)&& isGrounded) {

            //transform.position += transform.up * jumpspeed*Time.deltaTime;
            rb.AddForce(Vector3.up * jumpspeed,ForceMode2D.Impulse);
            ob.GetComponent<Animator>().Play("jump");

                } 
       

        if (Input.GetKey(KeyCode.H))
        {
            ob.GetComponent<Animator>().Play("attack");
            audi.Play();

        }


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("surface"))
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("collect"))
        {
            ScoreValue.scoreval++;
            TotalScoreValue.totscore++;
            Destroy(collision.gameObject);
        }
    }


    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("surface"))
        {
            isGrounded = false;
        }
    }


}
