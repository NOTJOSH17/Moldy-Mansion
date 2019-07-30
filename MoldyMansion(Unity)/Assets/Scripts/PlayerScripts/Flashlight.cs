using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject Light;
    public bool FlightOn;
    private int clickCounter;
    public FlashlightBar lightLife;
    public bool OnClickCounter;
    //public EnemyMovement enemyController;
  
    // Start is called before the first frame update
    void Start()
    {
        lightLife = GetComponent<FlashlightBar>();
        clickCounter = 1;
        FlightOn = true;
        OnClickCounter = true;
    }

    // Update is called once per frame
    public void Update()
    {
        if (OnClickCounter == true)
        {
             if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                clickCounter += 1;

                if (clickCounter == 1 && OnClickCounter == true)
               {
                
                   FlightOn = true;
                
              }
              if (clickCounter == 2 && OnClickCounter == true)
               {
                   
                   FlightOn = false;
                }
               if (clickCounter == 2 && OnClickCounter == true)
               {
                 clickCounter = 0;
                }

                if(FlightOn == true )
                {
                    lightLife.LightActive();
                    Light.SetActive(true);
                }
                if(FlightOn == false)
                {
                   lightLife.LightDeactive();
                    Light.SetActive(false);
                }
            }
        
        }
    }
    public void Activator()
    {
        //Light.SetActive(true);
        FlightOn = false;
        //clickCounter = 0;
    } 
    public void Deactivaor()
    {
       Light.SetActive(false);
    }
    public void ClicKActivator()
    {
        OnClickCounter = true;
    }
    public void ClickDeactivator()
    {
        OnClickCounter = false;
    }
}
