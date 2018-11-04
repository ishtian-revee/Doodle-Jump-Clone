using UnityEngine;

public class Platform : MonoBehaviour {

    // configurable fields
    public float upwardForce;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            // getting the collider rigidbody2d component
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                // adding the velocity on the collider to upwards
                Vector2 velocity = rb.velocity;
                velocity.y = upwardForce;
                rb.velocity = velocity;
            }
        }
    }
}
