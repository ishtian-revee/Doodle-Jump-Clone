using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

    // configurable fields
    public Rigidbody2D rb;
    public float sideWayForce;

    private float movement;

	// Use this for initialization
	void Start ()
	{
	    rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    movement = Input.GetAxis("Horizontal") * sideWayForce;
	}

    void FixedUpdate ()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}
