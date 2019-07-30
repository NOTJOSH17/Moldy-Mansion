using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody2D rb;

	private float t = 0.0f;
	private bool moving;
	public Animator anim;
	public int MoveNum;
	float speed = 650;

	void Awake()
	{
		//SpriteRenderer sprRend = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
		
		rb = gameObject.GetComponent<Rigidbody2D>();
		//rb.bodyType = RigidbodyType2D.Kinematic;	
	}

	void Start () 
	{
		//gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("image128x128");
		gameObject.transform.Translate(0.0f,0.0f,0.0f);
		MoveNum = 1;
		moving = false;
	}
	
	// Update is called once per frame
	void Update () 
	{

		Movement();
	}


	void Movement()
	{

		//Press the Up arrow key to move the RigidBody upwards
        if (Input.GetKey(KeyCode.W))
        {
		   transform.Translate(Vector2.up * Time.deltaTime * 7);
		   //rb.AddForce (Vector2.up * speed * Time.deltaTime);
            moving = true;
            t = 0.0f;
			MoveNum = 1;
			MovingAnim();
        }
		
        //Press the Down arrow key to move the RigidBody downwards
        if (Input.GetKey(KeyCode.S))
        {
			transform.Translate(Vector2.down * Time.deltaTime * 7);
			//rb.AddForce (Vector2.down * speed * Time.deltaTime);
            moving = true;
            t = 0.0f;
			MoveNum = 1;
			MovingAnim();
        }
		if (Input.GetKey(KeyCode.D))
        {
			transform.Translate(Vector2.right * Time.deltaTime * 7);
			//rb.AddForce (Vector2.right * speed * Time.deltaTime);
            moving = true;
            t = 0.0f;
			MoveNum = 1;
			moving = false;
			MovingAnim();
		}
		if (Input.GetKey(KeyCode.A))
        {
			transform.Translate(Vector2.left * Time.deltaTime * 7);
			//rb.AddForce (Vector2.left * speed * Time.deltaTime);
            moving = true;
            t = 0.0f;
			MoveNum = 1;
			MovingAnim();
        }
		
	
	}

	void MovingAnim()
	{
		anim.Play("PlayerMove");
	}

	void NotMoving()
	{

	}

}
