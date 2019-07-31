using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGate : MonoBehaviour
{
    public GameObject Gate_1;  
    public GameObject Frames;
    public AudioSource BossSong;
    public AudioSource BossLoopSong;
    public BossFighter BossStart;
    public GameObject Boss;
    public GameObject Pause;
    public Pause levelMusic;
    

     void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        if (hitInfo.gameObject.tag == "Player")
        {
            Gate_1.SetActive(true);
            Boss.SetActive(true);
            levelMusic.LevelSong.Stop();
            Destroy(Pause);
            BossStart.OpenAnimation();
            Frames.SetActive(false);
            Destroy(gameObject);
        }
        
    }


}
