using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
	//public AudioSource damageSound;
	public AudioSource DieSound;
	public bool PlaySound;
	public Animator anim;
	public KillCount Adddeath;
	//public int killCount;

	//public KillCount Adddeath;

	// Use this for initialization
	public void TakeDamage (int damage)
	{
		PlaySound = true;
		health -= damage;
		HitAnim();
		//StartCoroutine(HitSound());
		if (health <= 0)
		{
			DieSound.Play();
			killCounter();
			Die();
		}
	}

	public void PlayDamageSound()
	{
		
	}

	void HitAnim()
	{
		anim.Play("Hit");
	}

	void Die()
	{
		Destroy(gameObject);
	}
	public void killCounter()
	{
		Adddeath.CounterBlob();
	}
}
