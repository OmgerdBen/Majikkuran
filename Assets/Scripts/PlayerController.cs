using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public bool grounded;
    public LayerMask whatIsGround;
    //public LayerMask whatIsObstacle;
   // public LayerMask whatIsFruit;
    public float moveSpeed;
    public float jumpForce;
    public int HealthAmt;
    public int ScoreAmt;
    public Text Score;
    public Text Health;
   //Collision2D collision;

    private Rigidbody2D myRigidBody;
    private Collider2D myCollider;

	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        Health = GameObject.Find("Health").GetComponent<Text>();
        Score = GameObject.Find("Score").GetComponent<Text>();
        
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

        /*
        if(collision.gameObject.tag == "Obstacle")
        {
            HealthAmt -= 10;
            Health.text = "HP: " + HealthAmt;
        }
        
        if(Physics2D.IsTouchingLayers(myCollider, whatIsObstacle))
        {
            HealthAmt -= 10;
            Health.text = "HP: " + HealthAmt;
        }
        if(Physics2D.IsTouchingLayers(myCollider, whatIsFruit))
        {
            ScoreAmt += 100;
            Score.text = "Score: " + Score;
        }
        */
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Obstacle")
            HealthAmt -= 10;
            Health.text = "HP: " + HealthAmt;

    }
    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Obstacle")
            coll.gameObject.GetComponent<CircleCollider2D>().isTrigger = true;

    }
}
