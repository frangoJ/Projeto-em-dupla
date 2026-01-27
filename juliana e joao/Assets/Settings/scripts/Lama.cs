using UnityEngine;

public class Lama : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Rigidbody2D rb = col.GetComponent<Rigidbody2D>();
            rb.linearDamping = 5f; 
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Rigidbody2D rb = col.GetComponent<Rigidbody2D>();
            rb.linearDamping = 0.5f; 
        }
    }
}