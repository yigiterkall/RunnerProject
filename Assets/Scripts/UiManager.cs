using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;

    public GameObject gamePanel;
    public GameObject gameOverP;
    public GameObject plsTabText;
    public Text hscore;
    public Text hscore2;
    public Text score;

    public Text ttt;
    int counter = 1;
    
    public GameObject aPanel;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        hscore.text = PlayerPrefs.GetInt("highScore").ToString();
        
    }

    public void GameStart()
    {
        ttt.enabled = true;
        plsTabText.SetActive(false);
        gamePanel.GetComponent<Animator>().Play("Panel");
        
    }

    public void GameOver()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        hscore2.text = PlayerPrefs.GetInt("highScore").ToString();
        ttt.enabled = false;
        gameOverP.SetActive(true);
        //aPanel.SetActive(false);
        
    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
    public void onClick()
    {
        if (counter % 2 == 1)
        {
            aPanel.SetActive(true);
            counter++;
        }
        else
        {
            aPanel.SetActive(false);
            counter++;
        }
        
        
    }
    

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
