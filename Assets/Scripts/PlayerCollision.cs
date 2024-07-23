using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    public int score=0;
    public TextMeshProUGUI scoreText;
    void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.gameObject.tag=="Coin")
        {
            colliderInfo.gameObject.SetActive(false);
            score+=5;
            scoreText.text="SCORE: "+score;
        }
    }

}
