
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public Vector2 StartingVelocity;

    
     private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = StartingVelocity;
        Destroy(gameObject,1);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<Enemy>();
        enemy?.Die();
        Destroy(gameObject);
    }
}
