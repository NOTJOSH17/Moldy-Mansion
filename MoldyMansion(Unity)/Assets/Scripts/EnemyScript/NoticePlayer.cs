using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoticePlayer : MonoBehaviour {

	public GameObject enemy;
	public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
	void OnTriggerStay2D(Collider2D hitInfo)
	{
		//Debug.Log(hitInfo.name);
		PlayerMovement player = hitInfo.GetComponent<PlayerMovement>();
		EnemyMovement followPlayer = enemy.GetComponent<EnemyMovement>();
		if(player != null)
		{
			followPlayer.LookatPlayer();
			followPlayer.MoveTowardsPlayer();
			//anim.Play("MoldMonsterWalk");
			//anim.SetBool("IsMoving", true);
		}
	}

	void OnTriggerExit2D(Collider2D hitInfo)
	{
		//PlayerMovement player = hitInfo.GetComponent<PlayerMovement>();
		if(hitInfo.gameObject.tag == "Player")
		{
			anim.Play("MoldMonsterIdle");
		}
	}

}
