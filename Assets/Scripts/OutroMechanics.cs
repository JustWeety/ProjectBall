using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OutroMechanics : MonoBehaviour
{
    public TextMeshProUGUI time;
    public TextMeshProUGUI bestTimeText;
    public TextMeshProUGUI score;
    public TextMeshProUGUI bestScoreText;
    private float bestTime = 75;
    private int bestScore=0;
    void Start()
    {
        if(PlayerCollision.score==75)
        {
            score.text = "";
            bestScoreText.text = "";
            GameObject.Find("You Can Always Try Again!").GetComponent<TextMeshProUGUI>().text="";
            time.text="Time: "+(75f-GameMechanics.time).ToString("F1");
            if(GameMechanics.time>75f-bestTime)
            {
                bestTime=75f-GameMechanics.time;
            }
            bestTimeText.text="Best Time :"+bestTime.ToString("F1");

        }
        else
        {
            bestTimeText.text = "";
            time.text="";
            GameObject.Find("Congratulations!").GetComponent<TextMeshProUGUI>().text="";
            score.text="Score: "+PlayerCollision.score;
            if(PlayerCollision.score>bestScore)
            {
                bestScore=PlayerCollision.score;
            }
            bestScoreText.text="High Score: "+bestScore;            
        }
    }
    public void ToPlayAgain()
    {

    }
}
