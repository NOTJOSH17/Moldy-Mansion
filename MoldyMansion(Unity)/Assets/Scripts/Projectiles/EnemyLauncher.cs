using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLauncher : MonoBehaviour
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

	IEnumerator bulletLife()
	{
		yield return new WaitForSeconds(.25f);
		Destroy(bullet);
	}
}
