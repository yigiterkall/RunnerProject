using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager i;
    public int score;
    public int highScore;

    public Text scrs;
    // Start is called before the first frame update
    private void Awake()
    {
        if (i == null)
        {
            i = this;
        }
    }
    void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("score", score);
    }

    // Update is called once per frame
    void Update()
    {
        scrs.text = score.ToString();
    }

    void incrementScore()
    {
        score++;
    }

    public void StartScore()
    {
        InvokeRepeating("incrementScore", 0.1f, 0.5f);
    }
    public void StopScore()
    {
        CancelInvoke("incrementScore");
        PlayerPrefs.SetInt("score", score);

        if (PlayerPrefs.HasKey("highScore"))
        {
            if(score > PlayerPrefs.GetInt("highScore"))
            {
                PlayerPrefs.SetInt("highScore", score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("highScore", score);
        }
    }

}
