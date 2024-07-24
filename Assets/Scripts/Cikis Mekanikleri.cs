using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CikisMekanikleri : MonoBehaviour
{
    public TextMeshProUGUI zaman;
    public TextMeshProUGUI skor;
    float simdikiZaman;
    public AudioSource kaynak;
    public AudioClip kazanma , kaybetme;
    void Start()
    {
        if(OyuncuCarpisma.skor==225)
        {
            kaynak.clip=kazanma;
            skor.text="Skor: "+OyuncuCarpisma.skor;
            GameObject.Find("Her Zaman Tekrar Deneyebilirsin!").GetComponent<TextMeshProUGUI>().text="";
            simdikiZaman = 75f - OyunMekanikleri.zaman;
            zaman.text="Süre: "+simdikiZaman.ToString("F1");
        }
        else
        {
            kaynak.clip=kaybetme;
            zaman.text="";
            GameObject.Find("TEBRIKLER!").GetComponent<TextMeshProUGUI>().text="";
            skor.text="Skor: "+OyuncuCarpisma.skor;          
        }
        kaynak.Play();
    }
    public void TekrarOynamakIcin()
    {
        SceneManager.LoadScene("Oyun");
        OyuncuCarpisma.skor=0;
        OyunMekanikleri.zaman=75f;
    }
    public void OyundanCik()
    {
        Application.Quit();
    }
}
