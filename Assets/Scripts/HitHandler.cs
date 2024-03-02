using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitHandler : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Projectile")
        {
            Debug.Log(other);
            GameObject.FindWithTag("Health").GetComponent<HealthManager>().TakeDamage(20);
            Destroy(other.gameObject);
        }
    }
}
