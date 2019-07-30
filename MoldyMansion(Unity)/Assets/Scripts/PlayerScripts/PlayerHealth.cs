using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
	
	public float health;
	float maxHealth = 100f;
	public Image barImage;
	public GameOverScript GameOverCall;

	void Start()
	{
		//barImage = GetComponent<Image>();
		health = maxHealth;
		barImage.fillAmount = health / maxHealth;
	}
	
	public void TakeDamage (float damage)
	{
		health -= damage;
		barImage.fillAmount = health / maxHealth;
		if (health <= 0)
		{
			Die();
		}
		
	}
	void Die()
	{
		GameOverCall.GameOver();
		//Destroy(gameObject);
	}
	public void AddHealth(float lifeAmount)
	{
		health += lifeAmount;
		barImage.fillAmount = health / maxHealth;
		if(health >= maxHealth)
		{
			health = maxHealth;
		}
	}
}
