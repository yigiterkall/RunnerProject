using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static GameManager i;
    public bool isOver;
    public Ads ads;
    
    private void Awake()
    {
        if(i == null)
        {
            i = this;
        }
    }
    void Start()
    {
        isOver = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gameStart()
    {
        UiManager.instance.GameStart();
        ScoreManager.i.StartScore();
    }
    public void gameOver()
    {
        UiManager.instance.GameOver();
        ScoreManager.i.StopScore();
        isOver = true;
        
    }
   
}
