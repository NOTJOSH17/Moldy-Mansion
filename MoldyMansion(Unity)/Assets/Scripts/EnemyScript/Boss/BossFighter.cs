using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFighter : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Firepoint;
    public Transform Firepoint_2;
    public GameObject moldPrefab;
    public GameObject MonstPrefab;    
    public GameObject Player;
    int PatrolChoice;
    public bool right;
    public bool left;
    public Animator anim;
    public float Timer = 0;
    public float ShootTime = 0;
    public float EnemyTime = 0;
    float openTimer = 0;
    public float MusicTimer;
    bool IsShooting;
    public AudioSource BossOpenSong;
    bool PlaySong;
    public AudioSource BossLoopSong;
    public GameObject[] MoldMonsters;
    public GameObject InvincinlityBarrier;

    void Start()
    {
        
    }

    void Update()
    {

        Vector3 mousePosition = Player.transform.position;
		Vector2 direction = new Vector2( Player.transform.position.x - Firepoint.position.x, Player.transform.position.y - Firepoint.position.y);
		Firepoint.up = direction;

		Vector2 direction_2 = new Vector2( Player.transform.position.x - Firepoint_2.position.x, Player.transform.position.y - Firepoint_2.position.y);
		Firepoint_2.up = direction_2;
        openTimer += Time.deltaTime;
        if(PlaySong == true)
        {
            MusicTimer += Time.deltaTime;
            if(MusicTimer >= 16)
            {
                if(MusicTimer >= 17)
                {
                    BossLoopSong.Play();
                    BossOpenSong.Stop();
                    MusicTimer = 0;
                    PlaySong = false;
                }  
            }
        } 

        if(openTimer >= 17)
        {
                InvincinlityBarrier.SetActive(false);
                ShootTime += Time.deltaTime;
                if(ShootTime >= .5f)
                {
                    if(ShootTime >= 1)
                    {
                        Shoot();
                        ShootTime = 0;
                    }
                }
                EnemyTime += Time.deltaTime;
                if(EnemyTime >= 15)
                {
                    if (EnemyTime >= 16)
                    {
                        ShootEnemy();
                        EnemyTime = 0;
                    }
                }
                Timer += Time.deltaTime;
                if(Timer >= 5)
                {
                    Movement();
                    Timer = 0;
                    PatrolChoice ++;
                }
            
        }
        
       
    }

    void MoveLeft()
    {
        anim.Play("MoveLeft");
    }

    void MoveLeftCenter()
    {
        anim.Play("MoveCenter(Left)");
    }

    void MoveRight()
    {
        anim.Play("MoveRight");
    }

    void MoveRightCenter()
    {
        anim.Play("MoveCenter(Right)");
    }

    public void OpenAnimation()
    {
        //Play Animation for open;
        BossOpenSong.Play();
        PlaySong = true;
    }

    void Movement()
    {
        if (PatrolChoice == 1)
        {
            MoveRight();
        }
        
        if (PatrolChoice == 2)
        {
            MoveRightCenter();
        }

        if (PatrolChoice == 3)
        {
            MoveLeft();
        }
        if (PatrolChoice == 4)
        {
            MoveLeftCenter();
            PatrolChoice = 0;
        }
    }
    
    
    void Shoot()
    {
        Instantiate(moldPrefab, Firepoint.position, Firepoint.rotation);
        Instantiate(moldPrefab, Firepoint_2.position, Firepoint_2.rotation);
    }
    void ShootEnemy()
    {
        Instantiate(MonstPrefab, Firepoint.position, Firepoint.rotation);
        Instantiate(MonstPrefab, Firepoint_2.position, Firepoint_2.rotation);
    }

}
