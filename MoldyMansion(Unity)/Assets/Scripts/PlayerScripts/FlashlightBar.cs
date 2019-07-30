using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashlightBar : MonoBehaviour
{
    public float bLife;
	float maxBLife = 100f;
    public bool lightOn;
	public Image barImage;
    public GameObject Flash;
    public float damage;
    public GameObject Light;
    Flashlight FLon;
    // Start is called before the first frame update
    void Start()
    {
    FLon = GetComponent<Flashlight>();
      
       bLife = maxBLife;
    }

    void Update()
    {
        barImage.fillAmount = bLife / maxBLife;
		
        if(lightOn == true)
        {
           bLife -= damage; 
           barImage.fillAmount = bLife / maxBLife;

        }
        if (bLife <= 0)
		{
            //Light.SetActive(false);
            bLife = 0f;
            Light.SetActive(false);
            FLon.ClickDeactivator();
		}
    }
    public void LightActive()
    {
        lightOn = true;
    }
    public void LightDeactive()
    {
        lightOn = false;
    }
    public void AddBLife()
    {
        bLife += 50;
        if(bLife >= maxBLife)
        {
            bLife = maxBLife;
        }
        if (lightOn == true)
        {
            Light.SetActive(true);
            FLon.Activator();
            FLon.ClicKActivator();
            //lightOn = false;
        }
    }
    
}
