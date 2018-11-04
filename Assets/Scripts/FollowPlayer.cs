using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    // configurable fields
    public Transform player;
	
	// Update is called once per frame
	void LateUpdate ()
	{
	    if (player.position.y > transform.position.y)
	    {
            Vector3 newPosition = new Vector3(transform.position.x, player.position.y, transform.position.z);
	        transform.position = newPosition;
	    }
	}
}
