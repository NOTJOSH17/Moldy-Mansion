using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialougeTrigger : MonoBehaviour
{
   
    public GameObject Dialouge_1;
    public GameObject Dialouge_2;
    public GameObject Dialouge_3;
    public GameObject Dialouge_4;
    public float Timer = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Timer);
        Timer += Time.deltaTime;
        if(Timer >= .5)
        {
            if (Timer >= .8)
            {
                Dialouge_1.SetActive(true);
            }
                  
        }
        if(Timer >= 4)
        {
           if (Timer >= 6)
            {
                Dialouge_1.SetActive(false);
                Dialouge_2.SetActive(true);    
            }    
        }
        if(Timer >= 8)
        {
           if (Timer >= 10)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }    
        }



    
    }
}
