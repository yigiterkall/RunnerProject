using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follower : MonoBehaviour
{
    public bool isOver;
    public GameObject ball;
    // Vector3 offset;
    //public float lerpRate;
    private Vector3 vv = new Vector3(0,0,2f);
    // Start is called before the first frame update
    void Start()
    {
        //offset = ball.transform.position - transform.position;
        isOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        // if (!isOver)
        //{
        //  Follow();
        // }
      /*  if (!isOver)
        {
            Follow();
        }
      */
    }

    void Follow()
    {
        /*
        Vector3 pos = transform.position;
        Vector3 toPosition = ball.transform.position - offset;
        pos = Vector3.Lerp(pos, toPosition, lerpRate * Time.deltaTime);
        transform.position = pos;
        */
        
        /*
        transform.position = new Vector3(transform.position.x, transform.position.y,
            ball.transform.position.z -0.8f);
        */
        transform.position = Vector3.SmoothDamp(new Vector3(transform.position.x,
            transform.position.y, ball.transform.position.z - 0.8f), new Vector3(
                transform.position.x, transform.position.y,
                ball.transform.position.z),ref vv,0.1f);
        
    }
     void FixedUpdate()
    {
        /*
        if (!isOver)
        {
            Follow();
        }
        */
     /*   if (!isOver)
        {
            Follow();
        }
     */
    }
    void LateUpdate()
    {
        if (!isOver)
        {
            Follow();
        }
       
    }
}
