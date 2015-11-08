using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public bool grounded;
    public LayerMask whatIsGround;
    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D myRigidBody;
    private Collider2D myCollider;

	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        // is the player on the ground?!
        // returns true if collider is touching another collider
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        // do not change y value
        myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);

        // when space bar is pressed, character jumps
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // player can only jump if on ground
            if (grounded)
            {
                // do not change x value
                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce);
            }
        }
	}
}
