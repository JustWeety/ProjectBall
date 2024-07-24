using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OyuncuCarpisma : MonoBehaviour
{
    public static int skor=0;
    public TextMeshProUGUI skorMetni;
    void OnTriggerEnter(Collider Bilgi)
    {
        if (Bilgi.gameObject.tag=="Coin")
        {
            Bilgi.gameObject.SetActive(false);
            skor+=5;
            skorMetni.text="SKOR: "+skor;
        }
        if (skor==225)
        {
            SceneManager.LoadScene("Bitis Ekrani");
        }
    }

}
