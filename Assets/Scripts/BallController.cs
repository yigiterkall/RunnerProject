using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public AudioSource itsOver;
    bool chck = true;
    public GameObject particle;
    public AudioSource bum;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float nspeed;
    public float constantSpeed;
    bool isStart;
    Rigidbody rb;

    bool check1 = true;
    bool check2 = true;
    bool check3 = true;
    bool check4 = true;
    bool check5 = true;
    bool check6 = true;
    bool check7 = true;
    bool check8 = true;
    bool check9 = true;
    bool check10 = true;
    bool check11 = true;
    bool check12 = true;
    bool check13 = true;
    bool check14 = true;
    bool check15 = true;
    bool check16 = true;

    bool isOver;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.interpolation = RigidbodyInterpolation.Interpolate;
    }
    // Start is called before the first frame update
    void Start()
    {
        isStart = false;
        isOver = false;
    }

    // Update is called once per frame
    
    void Update()
    {
        //rb.AddForce(Vector3.forward * 250 * Time.deltaTime);
        /*
        if (!isStart)
        {
            if (Input.GetMouseButton(0))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                //rb.transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
                isStart = true;
                GameManager.i.gameStart();
            }
        }
        */
        
        
        if (!isStart)
        {
            if (Input.touches.Any(x => x.phase == TouchPhase.Began))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                //rb.transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
                isStart = true;
                GameManager.i.gameStart();
            }
        }
        
        if (!Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            isOver = true;
            if (chck)
            {
                itsOver.Play();
                chck = false;
            }
            rb.velocity = new Vector3(0, -20f, 0);
            Camera.main.GetComponent<follower>().isOver = true;

            GameManager.i.gameOver();
            
        }
        
        if (Input.touches.Any(x => x.phase == TouchPhase.Began) && !isOver)
        {
            SwitchDirection();
        }
        /*
        
                if (Input.GetMouseButtonDown(0) && !isOver)
                {
                    SwitchDirection();
                }
        */

        /*
                if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
                {
                    SwitchDirection();
                }
                */
    }
    void SwitchDirection()
    {
        if (rb.velocity.x > 0)
        {
            if(ScoreManager.i.score > 20 && check1)
            {
                nspeed = nspeed -0.25f;
                check1 = false;
            }
            if (ScoreManager.i.score > 40 && check3)
            {
                nspeed = nspeed - 0.25f;
                check3 = false;
            }
            if (ScoreManager.i.score > 60 && check5)
            {
                nspeed = nspeed - 0.25f;
                check5 = false;
            }
            if (ScoreManager.i.score > 80 && check7)
            {
                nspeed = nspeed - 0.25f;
                check7 = false;
            }
            if (ScoreManager.i.score > 100 && check9)
            {
                nspeed = nspeed - 0.25f;
                check9 = false;
            }
            if (ScoreManager.i.score > 120 && check11)
            {
                nspeed = nspeed - 0.25f;
                check11 = false;
            }
            if (ScoreManager.i.score > 140 && check13)
            {
                nspeed = nspeed - 0.25f;
                check13 = false;
            }
            if (ScoreManager.i.score > 180 && check15)
            {
                nspeed = nspeed - 0.25f;
                check15 = false;
            }
            rb.velocity = new Vector3(nspeed, 0, constantSpeed);


        }
        else
        {
            if(ScoreManager.i.score > 20 && check2)
            {
                speed = speed + 0.25f;
                constantSpeed = constantSpeed + 0.5f;
                check2 = false;
            }
            if (ScoreManager.i.score > 40 && check4)
            {
                speed = speed + 0.25f;
                constantSpeed = constantSpeed + 0.5f;
                check4 = false;
            }
            if (ScoreManager.i.score > 60 && check6)
            {
                speed = speed + 0.25f;
                constantSpeed = constantSpeed + 0.5f;
                check6 = false;
            }
            if (ScoreManager.i.score > 80 && check8)
            {
                speed = speed + 0.25f;
                constantSpeed = constantSpeed + 0.5f;
                check8 = false;
            }
            if (ScoreManager.i.score > 100 && check10)
            {
                speed = speed + 0.25f;
                constantSpeed = constantSpeed + 0.5f;
                check10 = false;
            }
            if (ScoreManager.i.score > 120 && check12)
            {
                speed = speed + 0.25f;
                constantSpeed = constantSpeed + 0.5f;
                check12 = false;
            }
            if (ScoreManager.i.score > 140 && check14)
            {
                speed = speed + 0.25f;
                constantSpeed = constantSpeed + 0.5f;
                check14 = false;
            }
            if (ScoreManager.i.score > 180 && check16)
            {
                speed = speed + 0.25f;
                constantSpeed = constantSpeed + 0.5f;
                check16 = false;
            }
            rb.velocity = new Vector3(speed, 0, constantSpeed);

        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "diamond")
        {

            GameObject tempParticle = Instantiate(particle, other.gameObject.transform.position, Quaternion.identity) as GameObject;
            bum.Play();
            ScoreManager.i.score +=3;
            Destroy(other.gameObject);
            Destroy(tempParticle, 2f);
        }
    }
}