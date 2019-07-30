using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {
	public float damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
	void OnTriggerStay2D(Collider2D hitInfo)
	{
		PlayerHealth player = hitInfo.GetComponent<PlayerHealth>();
		if(player != null)
		{
			player.TakeDamage(damage);
		}
		
		
	}


}
