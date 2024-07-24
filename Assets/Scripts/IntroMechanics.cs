using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroMechanics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToPlay()
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
