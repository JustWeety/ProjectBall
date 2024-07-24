using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OyunMekanikleri : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI zamanMetni;
    public static float zaman = 75;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Durdur();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            TekrarDene();
        }
    }
    void FixedUpdate()
    {
        zaman-=0.02f;
        string formatlizaman = zaman.ToString("F1");
        zamanMetni.text="Süre: "+formatlizaman;
        if(zaman<=0)
        {
            SceneManager.LoadScene("Bitis Ekrani");
        }
    }
    public void Durdur()
    {
        if(Time.timeScale==1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

    }   
    public void TekrarDene()
    {
        SceneManager.LoadScene("Oyun");
        OyuncuCarpisma.skor=0;
        zaman=75;
    } 
}
