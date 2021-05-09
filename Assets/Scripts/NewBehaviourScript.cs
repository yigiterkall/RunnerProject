using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject platform;
    Vector3 lastPos;
    float size;
    public bool isOver;
    public GameObject diamond;
    
    // Start is called before the first frame update
    void Start()
    {
        lastPos = platform.transform.position;
        size = platform.transform.localScale.z;

        for(int i = 0; i <350 ; i++)
        {
            SpawnPlatforms();
        }
       // InvokeRepeating("SpawnPlatforms", 1f, 4f);
    }
   
    // Update is called once per frame
    void Update()
    {
        if (GameManager.i.isOver == true)
        {
            //CancelInvoke("SpawnPlatforms");
        }
    }
    void SpawnZ()
    {
        Vector3 pos = lastPos;
        pos.z = pos.z + size;
        lastPos = pos;

        
       
        int oldersS = 0;
        int oldersP = 0;
        int ranPos = Random.Range(-8, 9);
        int ranSc = Random.Range(3, 8);

        while((ranSc / 2 + ranPos - oldersS / 2 - oldersP) <= -2 || (ranPos - ranSc / 2 - oldersS / 2 + oldersP) >= -2){
            ranPos = Random.Range(-8, 9);
            ranSc = Random.Range(3, 7);
        }

        platform.transform.localScale = new Vector3(ranSc, platform.transform.localScale.y, platform.transform.localScale.z);
        Instantiate(platform, new Vector3(ranPos, pos.y, pos.z), Quaternion.identity);
        pos.x = ranPos;
        


        //Instantiate(platform, pos, Quaternion.identity);
        int adanax = (int)platform.transform.localScale.x;
        adanax = adanax / 2;
        int possx = (int)pos.x;
        //int randy = Random.Range(possx-(adanax/2)+2, possx + (adanax/2)-2);
        int tememem = (int)platform.transform.position.x;
        int randy = Random.Range(possx- adanax+1, possx + adanax-1);
        int rand = Random.Range(0, 25);
        if(rand < 6)
        {
            Instantiate(diamond, new Vector3(randy ,pos.y + 1.3f, pos.z), diamond.transform.rotation);
        }
        else
        {

        }

    }
    void SpawnPlatforms()
    {
        SpawnZ();
    }
}
