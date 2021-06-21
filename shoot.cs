using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public int time = 3;
    public GameObject ob;
    public GameObject ob1;
    public GameObject ob2;
    GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(shoo());

    }

    // Update is called once per frame



    IEnumerator shoo()
    {
        

        while (true)
        {
           
            yield return new WaitForSeconds(4);
           temp= Instantiate(ob, transform.position, Quaternion.identity);
            Instantiate(ob1, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(time);
            Instantiate(ob2, temp.transform.position, Quaternion.identity);
            Destroy(temp);

        }
    }
}