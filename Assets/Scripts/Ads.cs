using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour
{
    public static Ads instance;
    bool temper = true;
   
    void Awake()
    {

 
        Advertisement.Initialize("4115293");
        DontDestroyOnLoad(this.gameObject);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
             
    }
    // Start is called before the first frame update
    void Start()
    {
        //Advertisement.Initialize("4115293");
        //DontDestroyOnLoad(this.gameObject);

        //Ads.instance.showAdd();
        //Advertisement.Initialize("4115293",true);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.i.isOver && temper)
        {
            showAdd();
            temper = false;
        }
        if (!GameManager.i.isOver)
        {
            temper = true;
        }
    }
    public void showAdd()
    {
        if (Advertisement.IsReady("Interstitial_Android"))
        {
            Advertisement.Show("Interstitial_Android");
            
        }
    }
}
