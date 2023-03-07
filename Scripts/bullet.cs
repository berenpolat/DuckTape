using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
 
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    private Score score;


    void Start()
    {
        rb.velocity = transform.right * speed;
        score = GameObject.Find("Score").GetComponent<Score>();
    }

    private void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Debug.Log(hitInfo);
        EnemyMovement enemy = hitInfo.GetComponent<EnemyMovement>();
        if (enemy != null)
        {
            enemy.takeDamage(40);
        }

        score.UpdateScore(1);
        Destroy(gameObject);

     //   Instantiate(impactEffect,transform.position,transform.rotation);
    
    }
}
