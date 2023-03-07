using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalColl : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "DeathCollider")
        {
            // Enemy has collided with the enemy collider, so we should destroy it
            Destroy(this.gameObject);
        }
    }
}
