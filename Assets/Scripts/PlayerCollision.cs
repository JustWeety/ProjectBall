using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public static int score=0;
    public TextMeshProUGUI scoreText;
    void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.gameObject.tag=="Coin")
        {
            colliderInfo.gameObject.SetActive(false);
            score+=5;
            scoreText.text="SCORE: "+score;
        }
        if (score==75)
        {
            SceneManager.LoadScene("Outro");
        }
    }

}
