using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public int health;

	//public int killCount;

	public KillCount Adddeath;

	public Animator EnemyAnim;
	public bool IsBoss;
	public GameObject[] MoldMonsters;
	public GameObject EndFrame;
	public AudioSource BossLoopMusic;
	// Use this for initialization
	public void TakeDamage (int damage)
	{
		
		health -= damage;
		if(IsBoss == true)
		{
			TakeDamage();
		}
		if (health <= 0)
		{
			Die();
			
		}
		if (health == 0)
		{
			killCounter();
		}
		
	}
	void Die()
	{
		if(IsBoss)
		{
			MoldMonsters = GameObject.FindGameObjectsWithTag("Enemy");
			for(int i = 0; i <  MoldMonsters.Length; i++)
			{
				Destroy(MoldMonsters[i]);
				
			}
			EndFrame.SetActive(false);
			BossLoopMusic.Stop();

		}
		Destroy(gameObject);
	}
	void TakeDamage()
	{
		
		EnemyAnim.Play("Damage");
	}

	public void killCounter()
	{
		Adddeath.CounterMoldMan();
	}
}
