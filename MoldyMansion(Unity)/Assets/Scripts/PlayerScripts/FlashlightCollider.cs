using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightCollider : MonoBehaviour
{

    public bool SeeEnemy;
    public bool followPlayer;
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Debug.Log(hitInfo);
        EnemyMovement enemy = hitInfo.GetComponent<EnemyMovement>();
        if(enemy != null)
		{
            enemy.Confused();
		}  
    }
    void OnTriggerExit2D(Collider2D hitInfo)
    {
        EnemyMovement enemy = hitInfo.GetComponent<EnemyMovement>();
        if (enemy == null)
        {
           enemy.Move = true;
        }
    }
    IEnumerator WaitToFollow()
    {
        yield return new WaitForSeconds(.5f);
        followPlayer = true;
    }
}
