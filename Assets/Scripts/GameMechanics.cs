using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMechanics : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI timeText;
    public static float time = 75;
    void FixedUpdate()
    {
        time-=0.02f;
        string formattedTime = time.ToString("F1");
        timeText.text="Time: "+formattedTime;
    }    
}
