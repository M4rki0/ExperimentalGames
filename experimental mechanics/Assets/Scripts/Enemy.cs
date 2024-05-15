using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            var health = other.GetComponent<Health>();
            if (health && health.health <= 0)
            {
                // If player is dead, gain access to player movement script
                other.GetComponent<PlayerMovement>().PossessPawn(gameObject);
                KillPlayer(other.gameObject);
            }
        }
    }

    private void KillPlayer(GameObject player)
    {
        Debug.Log("Enemy killed the player.");
    }
}