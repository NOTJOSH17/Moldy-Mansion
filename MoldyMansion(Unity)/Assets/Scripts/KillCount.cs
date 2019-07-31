using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCount : MonoBehaviour
{
    public int killCount;

    public int scoreValue = 0;
    public Text score; 
    public Text WinScore;

    void Start()
    {
        killCount = 0;
    }

    void Update()
    {
        score.text = "$" + scoreValue + ".00";
        WinScore.text = "$" + scoreValue + ".00";
    }
    public void CounterMoldMan()
    {
        killCount ++;
        scoreValue += 5;
        Debug.Log(killCount);
    }
    public void CounterBlob()
    {
        killCount ++;
        scoreValue += 20;
    }

}
