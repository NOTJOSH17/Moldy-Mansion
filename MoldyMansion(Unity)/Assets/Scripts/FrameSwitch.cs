using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameSwitch : MonoBehaviour {

	public GameObject Frame1;
	public GameObject Frame2;

	void Update()
	{
		Physics2D.IgnoreLayerCollision(8, 11);
	}
	private void OnTriggerEnter2D(Collider2D hitInfo)
	{ 
		//Debug.Log(hitInfo.name);
		if (hitInfo.tag == "RoomDetector")
		{
			//Debug.Log("Found PlayerDetector");
			if (Frame1.active == true)
			{
				Frame2.SetActive(true);
			}
		}
		
	}
}
