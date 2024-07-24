using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GirisMekanikleri : MonoBehaviour
{
    public GameObject hakkindaIcinResim;
    public GameObject kapatma;
    public void OynamakIcin()
    {
        SceneManager.LoadScene("Oyun");
        OyuncuCarpisma.skor=0;
        OyunMekanikleri.zaman=75f;
    }
    public void OyundanCik()
    {
        Application.Quit();
    }
    public void HakkindaAc()
    {
        kapatma.SetActive(true);
        hakkindaIcinResim.SetActive(true);
        GameObject.Find("Hakkindaicinyazi").GetComponent<TextMeshProUGUI>().text="Proje Top 3 boyutlu oyunu bitirmek icin haritanin cesitli yerlerine dagilmis 45 tane altin parayi 75 saniye dolmadan toplamaniz gereken bir parkur oyunudur. Hareket etmek icin W A S D tuslarini kullanabilir oyunu durdurmak icin P'ye bolumu denemek icin R'ye basabilirsiniz. Bol Sans!";
    }
    public void HakkindaKapat()
    {
        kapatma.SetActive(false);
        hakkindaIcinResim.SetActive(false);
        GameObject.Find("Hakkindaicinyazi").GetComponent<TextMeshProUGUI>().text="";
    }
}
