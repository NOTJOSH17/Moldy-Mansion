using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGate : MonoBehaviour
{
    public GameObject Gate_1;  
    public GameObject Frames;
    public AudioSource MainSong;
    public AudioSource BossSong;
    public AudioSource BossLoopSong;
    public BossFighter BossStart;
    public GameObject Boss;
    

     void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        if (hitInfo.gameObject.tag == "Player")
        {
            MainSong.Stop();
            Gate_1.SetActive(true);
            Boss.SetActive(true);
            BossStart.OpenAnimation();
            Frames.SetActive(false);
            Destroy(gameObject);
        }
        
    }

}
