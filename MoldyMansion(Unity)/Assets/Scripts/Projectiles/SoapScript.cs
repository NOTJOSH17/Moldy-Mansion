using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoapScript : MonoBehaviour {

	public float Speed = 10f;
	public Rigidbody2D rb;
	public GameObject bullet;
	public int damage = 1;

	// Use this for initialization
	void Start () 
	{
		rb.velocity = transform.up * Speed;
		StartCoroutine(bulletLife());
	}

	void OnTriggerEnter2D(Collider2D hitInfo)
	{
		//Debug.Log(hitInfo.name);
		EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
		BlobScript blob = hitInfo.GetComponent<BlobScript>();
		if (enemy != null)
		{
			enemy.TakeDamage(damage);
			Destroy(bullet);
		} 
		if (hitInfo.tag == "Walls")
		{
			Destroy(bullet);
		}
		if (hitInfo.tag == "Blob")
		{
			blob.TakeDamage(damage);
			Destroy(bullet);
		}
		if (hitInfo.tag == "Mold")
		{
			Destroy(bullet);
		}
	}
	
	IEnumerator bulletLife()
	{
		yield return new WaitForSeconds(.25f);
		Destroy(bullet);
	}
	
}
