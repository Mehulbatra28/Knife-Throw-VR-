using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 20f;
    public AudioClip EnemyDamageClip;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Alien"))
        {
            // Get the target's health script
            TargetScript target = other.collider.GetComponent<TargetScript>();

            if (target != null)
            {
                target.TakeDamage(damage); // Apply damage
            }

            Destroy(gameObject); // Destroy bullet after hit
        }
    }
}
