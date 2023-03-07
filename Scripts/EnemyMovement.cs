using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject enemy;
    public float speed = 3f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    
   // public GameObject deathEffect;  
    public int health = 100;

   
    
    public void takeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();    
        }
    }


    public void Die()
    {
       // Instantiate(deathEffect, transform.position,Quaternion.identity);
        Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0); //because we want the enemy to move right to left
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height, Camera.main.transform.position.z));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag=="DeathCollider")
        {
            Destroy(this.gameObject);
        }
    }

}
