using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OutroMechanics : MonoBehaviour
{
    public TextMeshProUGUI time;
    public TextMeshProUGUI score;
    float currentTime;
    public AudioSource source;
    public AudioClip win , lose;
    void Start()
    {
        if(PlayerCollision.score==225)
        {
            source.clip=win;
            score.text = "";
            GameObject.Find("You Can Always Try Again!").GetComponent<TextMeshProUGUI>().text="";
            currentTime = 75f - GameMechanics.time;
            time.text="Time: "+currentTime.ToString("F1");
        }
        else
        {
            source.clip=lose;
            time.text="";
            GameObject.Find("Congratulations!").GetComponent<TextMeshProUGUI>().text="";
            score.text="Score: "+PlayerCollision.score;          
        }
        source.Play();
    }
    public void ToPlayAgain()
    {
        SceneManager.LoadScene("Game");
        PlayerCollision.score=0;
        GameMechanics.time=75f;
    }
    public void QuitTheGame()
    {
        Application.Quit();
    }
}
