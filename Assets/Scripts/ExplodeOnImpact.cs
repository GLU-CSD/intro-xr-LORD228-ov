using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnImpact : MonoBehaviour
{
    public float explosionForce = 1000f;      // Kracht van de explosie
    public float explosionRadius = 20f;       // Radius van de explosie
    public float explosionDamage = 75f;

    private Health enemyHealth;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) // Zorg dat vijanden de tag "Enemy" hebben
        {
            Explode();
            //enemyHealth = collision.gameObject.GetComponent<Health>();
            Destroy(gameObject); // Verwijder het object na de explosie
        }
    }

    void Explode()
    {
        // Vind alle objecten in de buurt van de explosie
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }
            enemyHealth = nearbyObject.GetComponent<Health>();
            if (enemyHealth != null)
            {
                    enemyHealth.TakeDamage(explosionDamage);
         
            }
        }
    }
}
