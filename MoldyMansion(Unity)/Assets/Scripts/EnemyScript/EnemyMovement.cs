using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public GameObject Player;
	private int damage = 1;
	public Flashlight Flight;
	public bool Move;
	public Animator anim;

	// Use this for initialization
	void Start () {
		Move = true;
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () 
	{
		anim.SetBool("IsMoving", false);
	}
	public void LookatPlayer()
	{
		Vector3 mousePosition = Player.transform.position;
		Vector2 direction = new Vector2( Player.transform.position.x - transform.position.x, Player.transform.position.y - transform.position.y);
		transform.up = direction;
	}
	
	public void MoveTowardsPlayer()
	{
		if(Move == true)
		{
			transform.Translate(Vector2.up * Time.deltaTime * 3);
			anim.Play("MoldMonsterWalk");
			//anim.SetBool("IsMoving", true);
		}
		else
		{
			//anim.SetBool("IsMoving", false);
			anim.Play("MoldMonsterIdle");
		}//
		
	}

	public void MoveEnemy()
	{
		Move = true;
		
	}

	public void Confused()
	{
		Move = false;
		StartCoroutine(WaitToFollow());
		//Debug.Log("Stop Moving");
		//anim.SetBool("IsMoving", false);
	}
	IEnumerator WaitToFollow()
    {
        yield return new WaitForSeconds(1f);
        Move = true;
    }
}
