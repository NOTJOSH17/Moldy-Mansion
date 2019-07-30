using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour {


	public Transform Firepoint;
	public GameObject bulletPrefab;
	public float Soap;
    float maxSoap = 500;
    float UseSoap = 2f;
    public Image SoapBar;
	bool gunOn;
	public AudioSource SoapSound;
	// Update is called once per frame
	void Start()
    {
        Soap = maxSoap;
        gunOn = true;
    }

	void Update () 
	{
		Soap += 1f;
		if(Soap >= maxSoap)
		{
			Soap = maxSoap;
		}
		SoapBar.fillAmount = Soap / maxSoap;
		if (Input.GetKey(KeyCode.Mouse0))
		{
			if (gunOn == true)
			{
				SoapSound.Play();
				Shoot();
				Soap -= UseSoap;
			}
		}
        if (Soap <= 0)
        {
            Debug.Log("lowsoap");
			gunOn = false;
			
        }
		if (gunOn == false)
		{
			Soap += 1;
			if(Soap >= maxSoap)
			{
				gunOn = true;
			}
		}
	}

	void Shoot()
	{
		Instantiate(bulletPrefab, Firepoint.position, Firepoint.rotation);
	}
}
