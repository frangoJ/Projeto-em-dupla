using UnityEngine;

public class Madeira : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<Rigidbody2D>().AddTorque(-300f);
        }
    }
}
