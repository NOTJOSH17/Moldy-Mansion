using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoldScript : MonoBehaviour
{
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
		PlayerHealth Player = hitInfo.GetComponent<PlayerHealth>();
		BlobScript blob = hitInfo.GetComponent<BlobScript>();
		if (Player != null)
		{
			Player.TakeDamage(damage);
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
        if (hitInfo.tag == "Bubble")
        {
			Destroy(bullet);
        }
	}
	
	IEnumerator bulletLife()
	{
		yield return new WaitForSeconds(10f);
		Destroy(bullet);
	}
	
}
